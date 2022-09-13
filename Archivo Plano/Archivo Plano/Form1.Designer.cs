namespace Archivo_Plano
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.btnBorrar2 = new System.Windows.Forms.Button();
            this.txbEscritorio = new System.Windows.Forms.TextBox();
            this.Explorador = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGUARDAR2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(12, 33);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(118, 43);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "LEER";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 82);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(118, 43);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 131);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(118, 43);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(12, 180);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(118, 43);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(23, 305);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(86, 16);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Ingresar titulo";
            this.lblTitulo.Visible = false;
            // 
            // txbTitulo
            // 
            this.txbTitulo.Location = new System.Drawing.Point(12, 336);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(118, 22);
            this.txbTitulo.TabIndex = 6;
            this.txbTitulo.Visible = false;
            // 
            // btnBorrar2
            // 
            this.btnBorrar2.Location = new System.Drawing.Point(12, 380);
            this.btnBorrar2.Name = "btnBorrar2";
            this.btnBorrar2.Size = new System.Drawing.Size(118, 43);
            this.btnBorrar2.TabIndex = 7;
            this.btnBorrar2.Text = "BORRAR";
            this.btnBorrar2.UseVisualStyleBackColor = true;
            this.btnBorrar2.Visible = false;
            this.btnBorrar2.Click += new System.EventHandler(this.btnBorrar2_Click);
            // 
            // txbEscritorio
            // 
            this.txbEscritorio.Location = new System.Drawing.Point(166, 12);
            this.txbEscritorio.Multiline = true;
            this.txbEscritorio.Name = "txbEscritorio";
            this.txbEscritorio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbEscritorio.Size = new System.Drawing.Size(607, 476);
            this.txbEscritorio.TabIndex = 8;
            // 
            // Explorador
            // 
            this.Explorador.FileName = "openFileDialog1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 229);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 43);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGUARDAR2
            // 
            this.btnGUARDAR2.Location = new System.Drawing.Point(12, 445);
            this.btnGUARDAR2.Name = "btnGUARDAR2";
            this.btnGUARDAR2.Size = new System.Drawing.Size(118, 43);
            this.btnGUARDAR2.TabIndex = 10;
            this.btnGUARDAR2.Text = "GUARDAR";
            this.btnGUARDAR2.UseVisualStyleBackColor = true;
            this.btnGUARDAR2.Visible = false;
            this.btnGUARDAR2.Click += new System.EventHandler(this.btnGUARDAR2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.btnGUARDAR2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbEscritorio);
            this.Controls.Add(this.btnBorrar2);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnLeer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Button btnBorrar2;
        private System.Windows.Forms.TextBox txbEscritorio;
        private System.Windows.Forms.OpenFileDialog Explorador;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnGUARDAR2;
    }
}

