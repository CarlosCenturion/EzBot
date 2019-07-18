using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace EzBot
{
    public partial class fMain : Form
    {
        GHook gHook;

        private bool isActive = false;
        private int accionActual;

        DataTable dt = new DataTable();

              

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);


        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }

        }
        public fMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            isActive = false;
            //Carga el GlobalHook y lo inicializa
            gHook = new GHook();
            gHook.KeyUp += new KeyEventHandler(gHook_KeyUp);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);
            gHook.hook();

            //Carga el diccionario para el Combobox
            Dictionary<string, string> userCache = new Dictionary<string, string>
            {
              {"Clic izquierdo (mci)", "mci"},
              {"Doble clic (mdc)", "mdc"},
              {"Click derecho (mcd)", "mcd"},
              {"Escribir texto (txt)", "txt"},              
            };

            cbAccion.DataSource = new BindingSource(userCache, null);
            cbAccion.DisplayMember = "Key";
            cbAccion.ValueMember = "Value";

            // Agrega las columnas al datatable
            dt.Columns.Add("Tipo", typeof(int));
            dt.Columns.Add("Acción", typeof(string));
            dt.Columns.Add("X", typeof(int));
            dt.Columns.Add("Y", typeof(int));
            dt.Columns.Add("Delay", typeof(int));
            dt.Columns.Add("Texto", typeof(string));

            DataRow dr = dt.NewRow();

            //Carga el Datatable al Grid
            actionGrid.DataSource = dt;
            actionGrid.Columns["Tipo"].Visible = false;
            actionGrid.Columns["Acción"].Width = 50;
            actionGrid.Columns["X"].Width = 40;
            actionGrid.Columns["Y"].Width = 40;
            actionGrid.Columns["Delay"].Width = 40;            
            actionGrid.Columns["Texto"].Width = 175;

        }


        public void gHook_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:

                    // al pulsar la tecla el hook carga las cordenadas a los respectivos textBoxes
                    Point OriginalPoint = System.Windows.Forms.Cursor.Position;
                    txtNewX.Text = OriginalPoint.X.ToString();
                    txtNewY.Text = OriginalPoint.Y.ToString();
                    break;
            }


            if (e.KeyCode == Keys.Escape)
            {
                isActive = false;

            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Muestra las coordenadas actuales del mouse
            Point OriginalPoint = System.Windows.Forms.Cursor.Position;
            txtActualX.Text = OriginalPoint.X.ToString();
            txtActualY.Text = OriginalPoint.Y.ToString();
        }

        private void CbAccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = cbAccion.SelectedValue.ToString();
            if (val == "txt")
                txtTexto.Enabled = true;
            else
                
                txtTexto.Enabled = false;
                txtTexto.Text = "";

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            row["X"] = txtNewX.Text;
            row["Y"] = txtNewY.Text;
            row["Acción"] = cbAccion.SelectedValue;
            row["Delay"] = txtDelay.Text;
            row["Texto"] = txtTexto.Text;
            dt.Rows.Add(row);
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (actionGrid.RowCount < 1)
            {
                MessageBox.Show("¡La lista está vacía! ", "¡ERROR!");
            }
            else
            {            

                isActive = true;
                accionActual = 0;
                TimerAccion.Interval = Int32.Parse(actionGrid.Rows[accionActual].Cells["Delay"].Value.ToString());
                TimerAccion.Enabled = true;

            }
        }

        //Reproduccion de Eventos

        private void TimerAccion_Tick(object sender, EventArgs e)
        {
            TimerAccion.Enabled = false;

            if (isActive && accionActual < actionGrid.RowCount)
            {
                string cmd = actionGrid.Rows[accionActual].Cells["Acción"].Value.ToString();
                int x = Int32.Parse(actionGrid.Rows[accionActual].Cells["X"].Value.ToString());
                int y = Int32.Parse(actionGrid.Rows[accionActual].Cells["Y"].Value.ToString());
                string txt = actionGrid.Rows[accionActual].Cells["Texto"].Value.ToString();

                switch (cmd)
                {
                    

                    case "mci":
                        SetCursorPosition(x, y);
                        MouseEvent(MouseEventFlags.LeftDown);
                        MouseEvent(MouseEventFlags.LeftUp);
                        break;

                    case "mdc":
                        SetCursorPosition(x, y);
                        MouseEvent(MouseEventFlags.LeftDown);
                        MouseEvent(MouseEventFlags.LeftUp);
                        MouseEvent(MouseEventFlags.LeftDown);
                        MouseEvent(MouseEventFlags.LeftUp);
                        break;

                    case "mcd":
                        SetCursorPosition(x, y);
                        MouseEvent(MouseEventFlags.RightDown);
                        MouseEvent(MouseEventFlags.RightUp);
                        break;

                    case "txt":
                        SetCursorPosition(x, y);
                        SendKeys.Send(txt);
                        break;
                  
                }

                TimerAccion.Interval = Int32.Parse(actionGrid.Rows[accionActual].Cells["Delay"].Value.ToString());
                TimerAccion.Enabled = true;
                accionActual++;
            }
        }

        // Mouse Events

        public static MousePoint GetCursorPosition()
        {
            MousePoint currentMousePoint;
            var gotPoint = GetCursorPos(out currentMousePoint);
            if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }
            return currentMousePoint;
        }

        public static void MouseEvent(MouseEventFlags value)
        {
            MousePoint position = GetCursorPosition();

            mouse_event
                ((int)value,
                 position.X,
                 position.Y,
                 0,
                 0)
                ;
        }       

        [Flags]
        public enum MouseEventFlags
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightDown = 0x00000008,
            RightUp = 0x00000010
        }

        public static void SetCursorPosition(int X, int Y)
        {
            SetCursorPos(X, Y);
        }

        public static void SetCursorPosition(MousePoint point)
        {
            SetCursorPos(point.X, point.Y);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
            TimerAccion.Enabled = false;
        }

        

        private void SiempreVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = siempreVisibleToolStripMenuItem.Checked;
        }

        private void MenuAbrir_Click(object sender, EventArgs e)
        {
            string strLine;
            bool isFirstLine = true;

            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "ezbot (*.ezbot)|*.ezbot";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.CheckFileExists = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    StreamReader file = new StreamReader(openFileDialog1.FileName);
                    while ((strLine = file.ReadLine()) != null)
                    {
                        if (isFirstLine)
                        {
                            isFirstLine = false;
                            if (strLine != "0.1")
                            {
                                MessageBox.Show("Versión incompatible!");
                                file.Close();
                                return;
                            }

                            if (dt.Rows.Count > 0)
                                dt.Rows.Clear();
                        }
                        else
                        {
                            string[] cols = strLine.Split(';');
                            DataRow row = dt.NewRow();
                            row["Acción"] = cols[0].Trim();
                            row["X"] = cols[1].Trim();
                            row["Y"] = cols[2].Trim();
                            row["Delay"] = cols[3].Trim();
                            row["Texto"] = cols[4].Trim();
                            dt.Rows.Add(row);
                        }
                    }
                    file.Close();
                }
                else
                {
                    MessageBox.Show("¡No has seleccionado un archivo válido!");
                }
            }
        }

        private void MenuGuardar_Click(object sender, EventArgs e)
        {
            string strListRow, strCmd, strX, strY, strDelay, strText;

            if (actionGrid.RowCount < 1)
            {
                MessageBox.Show("Lista Vacia!", "ERROR!");
            }
            else
            {
                strListRow = "0.1";

                for (int i = 0; i < actionGrid.RowCount; i++)
                {
                    strCmd = actionGrid.Rows[i].Cells["Acción"].Value.ToString();
                    strX = actionGrid.Rows[i].Cells["X"].Value.ToString();
                    strY = actionGrid.Rows[i].Cells["Y"].Value.ToString();
                    strDelay = actionGrid.Rows[i].Cells["Delay"].Value.ToString();
                    strText = actionGrid.Rows[i].Cells["Texto"].Value.ToString();

                    strListRow += Environment.NewLine + strCmd + ";" + strX + ";" + strY + ";" + strDelay + ";" + strText;
                }

                DateTime now = DateTime.Now;
                string strNow = "EzBot-List_" + now.ToString();
                strNow = strNow.Replace(" ", "_");
                strNow = strNow.Replace(".", "");
                strNow = strNow.Replace(":", "");

                saveFileDialog1.FileName = strNow;
                saveFileDialog1.Filter = "ezbot (*.ezbot)|*.ezbot";
                saveFileDialog1.Title = "Guardar Lista";
                saveFileDialog1.OverwritePrompt = true;
                saveFileDialog1.CreatePrompt = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.FileName != "")
                    {
                        StreamWriter Kayit = new StreamWriter(saveFileDialog1.FileName);
                        Kayit.WriteLine(strListRow);
                        Kayit.Close();
                    }
                }
            }
        }

        private void SobreMiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe am = new AboutMe();
            am.Show();
        }

        private void SobreElProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAPP ap = new AboutAPP();
            ap.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtNewX_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNewY_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
