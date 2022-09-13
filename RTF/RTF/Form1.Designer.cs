namespace RTF
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtLeer = new System.Windows.Forms.TextBox();
            this.txtGuardar = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbCrear = new System.Windows.Forms.TextBox();
            this.Rtb1 = new System.Windows.Forms.RichTextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(23, 108);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(118, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir RTF";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(23, 254);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar RTF";
            this.btnGuardar.UseVisualStyleBackColor = true;
           
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(23, 352);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(118, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar RTF";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(23, 34);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(118, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear RTF";
            this.btnCrear.UseVisualStyleBackColor = true;
            
            // 
            // txtLeer
            // 
            this.txtLeer.Location = new System.Drawing.Point(23, 137);
            this.txtLeer.Name = "txtLeer";
            this.txtLeer.Size = new System.Drawing.Size(118, 22);
            this.txtLeer.TabIndex = 5;
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(23, 283);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(118, 22);
            this.txtGuardar.TabIndex = 6;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(23, 63);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(118, 22);
            this.txbNombre.TabIndex = 7;
            // 
            // txbCrear
            // 
            this.txbCrear.Location = new System.Drawing.Point(23, 381);
            this.txbCrear.Name = "txbCrear";
            this.txbCrear.Size = new System.Drawing.Size(118, 22);
            this.txbCrear.TabIndex = 8;
            // 
            // Rtb1
            // 
            this.Rtb1.Location = new System.Drawing.Point(147, 12);
            this.Rtb1.Name = "Rtb1";
            this.Rtb1.ReadOnly = true;
            this.Rtb1.Size = new System.Drawing.Size(641, 426);
            this.Rtb1.TabIndex = 9;
            this.Rtb1.Text = "";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(23, 179);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(118, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar RTF";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.Rtb1);
            this.Controls.Add(this.txbCrear);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.txtLeer);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtLeer;
        private System.Windows.Forms.TextBox txtGuardar;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbCrear;
        private System.Windows.Forms.RichTextBox Rtb1;
        private System.Windows.Forms.Button btnModificar;
    }
}

