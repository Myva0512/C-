namespace buscador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_Url = new System.Windows.Forms.TextBox();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Ir = new System.Windows.Forms.Button();
            this.btn_Adelante = new System.Windows.Forms.Button();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.web = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txb_Url);
            this.panel1.Controls.Add(this.btn_Actualizar);
            this.panel1.Controls.Add(this.btn_Ir);
            this.panel1.Controls.Add(this.btn_Adelante);
            this.panel1.Controls.Add(this.btn_Atras);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 100);
            this.panel1.TabIndex = 0;
            // 
            // txb_Url
            // 
            this.txb_Url.Location = new System.Drawing.Point(218, 39);
            this.txb_Url.Name = "txb_Url";
            this.txb_Url.Size = new System.Drawing.Size(573, 22);
            this.txb_Url.TabIndex = 4;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(927, 38);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(91, 23);
            this.btn_Actualizar.TabIndex = 3;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Ir
            // 
            this.btn_Ir.Location = new System.Drawing.Point(817, 38);
            this.btn_Ir.Name = "btn_Ir";
            this.btn_Ir.Size = new System.Drawing.Size(75, 23);
            this.btn_Ir.TabIndex = 2;
            this.btn_Ir.Text = "Ir";
            this.btn_Ir.UseVisualStyleBackColor = true;
            this.btn_Ir.Click += new System.EventHandler(this.btn_Ir_Click);
            // 
            // btn_Adelante
            // 
            this.btn_Adelante.Location = new System.Drawing.Point(110, 39);
            this.btn_Adelante.Name = "btn_Adelante";
            this.btn_Adelante.Size = new System.Drawing.Size(81, 23);
            this.btn_Adelante.TabIndex = 1;
            this.btn_Adelante.Text = "Adelante";
            this.btn_Adelante.UseVisualStyleBackColor = true;
            this.btn_Adelante.Click += new System.EventHandler(this.btn_Adelante_Click);
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(10, 39);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(75, 23);
            this.btn_Atras.TabIndex = 0;
            this.btn_Atras.Text = "Atras";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(12, 107);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(1008, 494);
            this.web.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 613);
            this.Controls.Add(this.web);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_Url;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Ir;
        private System.Windows.Forms.Button btn_Adelante;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.WebBrowser web;
    }
}

