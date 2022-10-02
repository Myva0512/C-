namespace Reproductor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionar = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiar_Lista = new System.Windows.Forms.ToolStripMenuItem();
            this.play = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.pausar = new System.Windows.Forms.ToolStripMenuItem();
            this.stop = new System.Windows.Forms.ToolStripMenuItem();
            this.antes = new System.Windows.Forms.ToolStripMenuItem();
            this.siguiente = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lb_Lista = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.play,
            this.restaurar,
            this.pausar,
            this.stop,
            this.antes,
            this.siguiente,
            this.salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrir,
            this.seleccionar,
            this.limpiar_Lista});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(60, 26);
            this.Menu.Text = "Menu";
            // 
            // abrir
            // 
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(178, 26);
            this.abrir.Text = "Abrir";
            this.abrir.Click += new System.EventHandler(this.abrir_Click);
            // 
            // seleccionar
            // 
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(178, 26);
            this.seleccionar.Text = "Seleccionar";
            this.seleccionar.Click += new System.EventHandler(this.seleccionar_Click);
            // 
            // limpiar_Lista
            // 
            this.limpiar_Lista.Name = "limpiar_Lista";
            this.limpiar_Lista.Size = new System.Drawing.Size(178, 26);
            this.limpiar_Lista.Text = "Limpiar_Lista";
            this.limpiar_Lista.Click += new System.EventHandler(this.limpiar_Lista_Click);
            // 
            // play
            // 
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(50, 26);
            this.play.Text = "Play";
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // restaurar
            // 
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(85, 26);
            this.restaurar.Text = "Restaurar";
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // pausar
            // 
            this.pausar.Name = "pausar";
            this.pausar.Size = new System.Drawing.Size(65, 26);
            this.pausar.Text = "Pausar";
            this.pausar.Click += new System.EventHandler(this.pausar_Click);
            // 
            // stop
            // 
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(54, 26);
            this.stop.Text = "Stop";
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // antes
            // 
            this.antes.Name = "antes";
            this.antes.Size = new System.Drawing.Size(69, 26);
            this.antes.Text = "Previus";
            this.antes.Click += new System.EventHandler(this.antes_Click);
            // 
            // siguiente
            // 
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(54, 26);
            this.siguiente.Text = "Next";
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // salir
            // 
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(52, 26);
            this.salir.Text = "Salir";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(12, 385);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(0, 19);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.UseCompatibleTextRendering = true;
            // 
            // lb_Lista
            // 
            this.lb_Lista.BackColor = System.Drawing.Color.Black;
            this.lb_Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Lista.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_Lista.FormattingEnabled = true;
            this.lb_Lista.ItemHeight = 16;
            this.lb_Lista.Location = new System.Drawing.Point(1, 77);
            this.lb_Lista.Name = "lb_Lista";
            this.lb_Lista.Size = new System.Drawing.Size(276, 288);
            this.lb_Lista.TabIndex = 3;
            this.lb_Lista.SelectedIndexChanged += new System.EventHandler(this.lb_Lista_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(12, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 16);
            this.lblNombre.TabIndex = 4;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(320, 77);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(748, 327);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1080, 427);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lb_Lista);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem abrir;
        private System.Windows.Forms.ToolStripMenuItem seleccionar;
        private System.Windows.Forms.ToolStripMenuItem limpiar_Lista;
        private System.Windows.Forms.ToolStripMenuItem play;
        private System.Windows.Forms.ToolStripMenuItem restaurar;
        private System.Windows.Forms.ToolStripMenuItem pausar;
        private System.Windows.Forms.ToolStripMenuItem stop;
        private System.Windows.Forms.ToolStripMenuItem antes;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.ListBox lb_Lista;
        private System.Windows.Forms.Label lblNombre;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolStripMenuItem siguiente;
        private System.Windows.Forms.ToolStripMenuItem salir;
    }
}

