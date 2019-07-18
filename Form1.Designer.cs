namespace EzBot
{
    partial class fMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.actionGrid = new System.Windows.Forms.DataGridView();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtActualX = new System.Windows.Forms.TextBox();
            this.txtActualY = new System.Windows.Forms.TextBox();
            this.txtNewX = new System.Windows.Forms.TextBox();
            this.txtNewY = new System.Windows.Forms.TextBox();
            this.cbAccion = new System.Windows.Forms.ComboBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerAccion = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siempreVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreMiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreElProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupActions = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.actionGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionGrid
            // 
            this.actionGrid.AllowUserToAddRows = false;
            this.actionGrid.AllowUserToDeleteRows = false;
            this.actionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actionGrid.Location = new System.Drawing.Point(12, 197);
            this.actionGrid.MultiSelect = false;
            this.actionGrid.Name = "actionGrid";
            this.actionGrid.RowHeadersVisible = false;
            this.actionGrid.Size = new System.Drawing.Size(347, 150);
            this.actionGrid.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(19, 376);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(100, 376);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Detener";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // txtActualX
            // 
            this.txtActualX.Location = new System.Drawing.Point(265, 384);
            this.txtActualX.Name = "txtActualX";
            this.txtActualX.Size = new System.Drawing.Size(38, 20);
            this.txtActualX.TabIndex = 5;
            // 
            // txtActualY
            // 
            this.txtActualY.Location = new System.Drawing.Point(309, 384);
            this.txtActualY.Name = "txtActualY";
            this.txtActualY.Size = new System.Drawing.Size(38, 20);
            this.txtActualY.TabIndex = 18;
            // 
            // txtNewX
            // 
            this.txtNewX.Location = new System.Drawing.Point(147, 100);
            this.txtNewX.Name = "txtNewX";
            this.txtNewX.Size = new System.Drawing.Size(75, 20);
            this.txtNewX.TabIndex = 7;
            this.txtNewX.TextChanged += new System.EventHandler(this.TxtNewX_TextChanged);
            // 
            // txtNewY
            // 
            this.txtNewY.Location = new System.Drawing.Point(228, 100);
            this.txtNewY.Name = "txtNewY";
            this.txtNewY.Size = new System.Drawing.Size(75, 20);
            this.txtNewY.TabIndex = 8;
            this.txtNewY.TextChanged += new System.EventHandler(this.TxtNewY_TextChanged);
            // 
            // cbAccion
            // 
            this.cbAccion.FormattingEnabled = true;
            this.cbAccion.Location = new System.Drawing.Point(147, 45);
            this.cbAccion.Name = "cbAccion";
            this.cbAccion.Size = new System.Drawing.Size(156, 21);
            this.cbAccion.TabIndex = 9;
            this.cbAccion.SelectedIndexChanged += new System.EventHandler(this.CbAccion_SelectedIndexChanged);
            // 
            // txtTexto
            // 
            this.txtTexto.Enabled = false;
            this.txtTexto.Location = new System.Drawing.Point(147, 72);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(156, 20);
            this.txtTexto.TabIndex = 10;
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(147, 129);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(75, 20);
            this.txtDelay.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(228, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Agregar ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Coordenadas";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Acción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Texto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Delay (ms)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Coordenadas actuales";
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // TimerAccion
            // 
            this.TimerAccion.Tick += new System.EventHandler(this.TimerAccion_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.acercaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbrir,
            this.menuGuardar});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // menuAbrir
            // 
            this.menuAbrir.Name = "menuAbrir";
            this.menuAbrir.Size = new System.Drawing.Size(180, 22);
            this.menuAbrir.Text = "Abrir";
            this.menuAbrir.Click += new System.EventHandler(this.MenuAbrir_Click);
            // 
            // menuGuardar
            // 
            this.menuGuardar.Name = "menuGuardar";
            this.menuGuardar.Size = new System.Drawing.Size(180, 22);
            this.menuGuardar.Text = "Guardar";
            this.menuGuardar.Click += new System.EventHandler(this.MenuGuardar_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siempreVisibleToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // siempreVisibleToolStripMenuItem
            // 
            this.siempreVisibleToolStripMenuItem.Checked = true;
            this.siempreVisibleToolStripMenuItem.CheckOnClick = true;
            this.siempreVisibleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.siempreVisibleToolStripMenuItem.Name = "siempreVisibleToolStripMenuItem";
            this.siempreVisibleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.siempreVisibleToolStripMenuItem.Text = "Siempre visible";
            this.siempreVisibleToolStripMenuItem.Click += new System.EventHandler(this.SiempreVisibleToolStripMenuItem_Click);
            // 
            // acercaToolStripMenuItem
            // 
            this.acercaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreMiToolStripMenuItem,
            this.sobreElProgramaToolStripMenuItem});
            this.acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            this.acercaToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.acercaToolStripMenuItem.Text = "Información";
            // 
            // sobreMiToolStripMenuItem
            // 
            this.sobreMiToolStripMenuItem.Name = "sobreMiToolStripMenuItem";
            this.sobreMiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreMiToolStripMenuItem.Text = "Sobre mi";
            this.sobreMiToolStripMenuItem.Click += new System.EventHandler(this.SobreMiToolStripMenuItem_Click);
            // 
            // sobreElProgramaToolStripMenuItem
            // 
            this.sobreElProgramaToolStripMenuItem.Name = "sobreElProgramaToolStripMenuItem";
            this.sobreElProgramaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreElProgramaToolStripMenuItem.Text = "Sobre el programa";
            this.sobreElProgramaToolStripMenuItem.Click += new System.EventHandler(this.SobreElProgramaToolStripMenuItem_Click);
            // 
            // groupActions
            // 
            this.groupActions.Location = new System.Drawing.Point(4, 177);
            this.groupActions.Name = "groupActions";
            this.groupActions.Size = new System.Drawing.Size(362, 182);
            this.groupActions.TabIndex = 20;
            this.groupActions.TabStop = false;
            this.groupActions.Text = "Lista de acciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Pulsa F2 para auto obtener las coordenadas";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 409);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.cbAccion);
            this.Controls.Add(this.txtNewY);
            this.Controls.Add(this.txtNewX);
            this.Controls.Add(this.txtActualY);
            this.Controls.Add(this.txtActualX);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.actionGrid);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EzBot by Ezequiel C.C.";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actionGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView actionGrid;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtActualX;
        private System.Windows.Forms.TextBox txtActualY;
        private System.Windows.Forms.TextBox txtNewX;
        private System.Windows.Forms.TextBox txtNewY;
        private System.Windows.Forms.ComboBox cbAccion;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer TimerAccion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAbrir;
        private System.Windows.Forms.ToolStripMenuItem siempreVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreMiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreElProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuGuardar;
        private System.Windows.Forms.GroupBox groupActions;
        private System.Windows.Forms.Label label6;
    }
}

