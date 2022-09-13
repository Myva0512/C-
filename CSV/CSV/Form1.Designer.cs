namespace CSV
{
    partial class formCSV
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.chkTitulos = new System.Windows.Forms.CheckBox();
            this.lblLeerFichero = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lblSeparadorValores = new System.Windows.Forms.Label();
            this.labelExportar = new System.Windows.Forms.Label();
            this.btnSeleccionarExportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblSeparadorCampos = new System.Windows.Forms.Label();
            this.lblSeparadorValoresExportar = new System.Windows.Forms.Label();
            this.txtLeer = new System.Windows.Forms.TextBox();
            this.txtExportar = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtCrear = new System.Windows.Forms.TextBox();
            this.lblCrear = new System.Windows.Forms.Label();
            this.txbComa = new System.Windows.Forms.TextBox();
            this.txbComillas = new System.Windows.Forms.TextBox();
            this.txbPuntoyComa = new System.Windows.Forms.TextBox();
            this.txbComilla1 = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(708, 37);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(54, 23);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "...";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dtg1
            // 
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Location = new System.Drawing.Point(12, 126);
            this.dtg1.Name = "dtg1";
            this.dtg1.RowHeadersWidth = 51;
            this.dtg1.RowTemplate.Height = 24;
            this.dtg1.Size = new System.Drawing.Size(849, 292);
            this.dtg1.TabIndex = 2;
            // 
            // chkTitulos
            // 
            this.chkTitulos.AutoSize = true;
            this.chkTitulos.Location = new System.Drawing.Point(539, 91);
            this.chkTitulos.Name = "chkTitulos";
            this.chkTitulos.Size = new System.Drawing.Size(326, 20);
            this.chkTitulos.TabIndex = 3;
            this.chkTitulos.Text = "la primera lina contiene los titulos de las columnas";
            this.chkTitulos.UseVisualStyleBackColor = true;
            // 
            // lblLeerFichero
            // 
            this.lblLeerFichero.AutoSize = true;
            this.lblLeerFichero.Location = new System.Drawing.Point(12, 9);
            this.lblLeerFichero.Name = "lblLeerFichero";
            this.lblLeerFichero.Size = new System.Drawing.Size(107, 16);
            this.lblLeerFichero.TabIndex = 9;
            this.lblLeerFichero.Text = "Leer fichero CSV";
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(781, 38);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(83, 23);
            this.btnLeer.TabIndex = 10;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.Location = new System.Drawing.Point(12, 85);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(214, 16);
            this.lblSeparador.TabIndex = 11;
            this.lblSeparador.Text = "Caracter de separador de campos";
            // 
            // lblSeparadorValores
            // 
            this.lblSeparadorValores.AutoSize = true;
            this.lblSeparadorValores.Location = new System.Drawing.Point(283, 88);
            this.lblSeparadorValores.Name = "lblSeparadorValores";
            this.lblSeparadorValores.Size = new System.Drawing.Size(210, 16);
            this.lblSeparadorValores.TabIndex = 13;
            this.lblSeparadorValores.Text = "Caracter de separador de valores";
            // 
            // labelExportar
            // 
            this.labelExportar.AutoSize = true;
            this.labelExportar.Location = new System.Drawing.Point(12, 434);
            this.labelExportar.Name = "labelExportar";
            this.labelExportar.Size = new System.Drawing.Size(173, 16);
            this.labelExportar.TabIndex = 15;
            this.labelExportar.Text = "Exportar  grid  a fichero CSV";
            // 
            // btnSeleccionarExportar
            // 
            this.btnSeleccionarExportar.Location = new System.Drawing.Point(708, 452);
            this.btnSeleccionarExportar.Name = "btnSeleccionarExportar";
            this.btnSeleccionarExportar.Size = new System.Drawing.Size(54, 23);
            this.btnSeleccionarExportar.TabIndex = 17;
            this.btnSeleccionarExportar.Text = "...";
            this.btnSeleccionarExportar.UseVisualStyleBackColor = true;
            this.btnSeleccionarExportar.Click += new System.EventHandler(this.btnSeleccionarExportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(781, 453);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(80, 23);
            this.btnExportar.TabIndex = 18;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblSeparadorCampos
            // 
            this.lblSeparadorCampos.AutoSize = true;
            this.lblSeparadorCampos.Location = new System.Drawing.Point(12, 501);
            this.lblSeparadorCampos.Name = "lblSeparadorCampos";
            this.lblSeparadorCampos.Size = new System.Drawing.Size(214, 16);
            this.lblSeparadorCampos.TabIndex = 19;
            this.lblSeparadorCampos.Text = "Caracter de separador de campos";
            // 
            // lblSeparadorValoresExportar
            // 
            this.lblSeparadorValoresExportar.AutoSize = true;
            this.lblSeparadorValoresExportar.Location = new System.Drawing.Point(283, 501);
            this.lblSeparadorValoresExportar.Name = "lblSeparadorValoresExportar";
            this.lblSeparadorValoresExportar.Size = new System.Drawing.Size(210, 16);
            this.lblSeparadorValoresExportar.TabIndex = 21;
            this.lblSeparadorValoresExportar.Text = "Caracter de separador de valores";
            // 
            // txtLeer
            // 
            this.txtLeer.Location = new System.Drawing.Point(15, 39);
            this.txtLeer.Name = "txtLeer";
            this.txtLeer.Size = new System.Drawing.Size(673, 22);
            this.txtLeer.TabIndex = 23;
            // 
            // txtExportar
            // 
            this.txtExportar.Location = new System.Drawing.Point(15, 454);
            this.txtExportar.Name = "txtExportar";
            this.txtExportar.Size = new System.Drawing.Size(659, 22);
            this.txtExportar.TabIndex = 24;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(781, 565);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 29;
            this.btnCrear.Text = "Crear CSV";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtCrear
            // 
            this.txtCrear.Location = new System.Drawing.Point(12, 565);
            this.txtCrear.Name = "txtCrear";
            this.txtCrear.Size = new System.Drawing.Size(659, 22);
            this.txtCrear.TabIndex = 30;
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.Location = new System.Drawing.Point(12, 546);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(87, 16);
            this.lblCrear.TabIndex = 31;
            this.lblCrear.Text = "Crear un CSV";
            // 
            // txbComa
            // 
            this.txbComa.Location = new System.Drawing.Point(233, 81);
            this.txbComa.Name = "txbComa";
            this.txbComa.Size = new System.Drawing.Size(18, 22);
            this.txbComa.TabIndex = 32;
            this.txbComa.Text = ";";
            // 
            // txbComillas
            // 
            this.txbComillas.Location = new System.Drawing.Point(500, 85);
            this.txbComillas.Name = "txbComillas";
            this.txbComillas.Size = new System.Drawing.Size(22, 22);
            this.txbComillas.TabIndex = 33;
            this.txbComillas.Text = "\"";
            // 
            // txbPuntoyComa
            // 
            this.txbPuntoyComa.Location = new System.Drawing.Point(232, 501);
            this.txbPuntoyComa.Name = "txbPuntoyComa";
            this.txbPuntoyComa.Size = new System.Drawing.Size(18, 22);
            this.txbPuntoyComa.TabIndex = 34;
            this.txbPuntoyComa.Text = ";";
            // 
            // txbComilla1
            // 
            this.txbComilla1.Location = new System.Drawing.Point(500, 500);
            this.txbComilla1.Name = "txbComilla1";
            this.txbComilla1.Size = new System.Drawing.Size(22, 22);
            this.txbComilla1.TabIndex = 35;
            this.txbComilla1.Text = "\"";
            // 
            // btnSeleccionarCrear
            // 
            this.btnSeleccionarCrear.Location = new System.Drawing.Point(708, 564);
            this.btnSeleccionarCrear.Name = "btnSeleccionarCrear";
            this.btnSeleccionarCrear.Size = new System.Drawing.Size(54, 23);
            this.btnSeleccionarCrear.TabIndex = 36;
            this.btnSeleccionarCrear.Text = "...";
            this.btnSeleccionarCrear.UseVisualStyleBackColor = true;
            this.btnSeleccionarCrear.Click += new System.EventHandler(this.btnSeleccionarCrear_Click);
            // 
            // formCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 613);
            this.Controls.Add(this.btnSeleccionarCrear);
            this.Controls.Add(this.txbComilla1);
            this.Controls.Add(this.txbPuntoyComa);
            this.Controls.Add(this.txbComillas);
            this.Controls.Add(this.txbComa);
            this.Controls.Add(this.lblCrear);
            this.Controls.Add(this.txtCrear);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtExportar);
            this.Controls.Add(this.txtLeer);
            this.Controls.Add(this.lblSeparadorValoresExportar);
            this.Controls.Add(this.lblSeparadorCampos);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnSeleccionarExportar);
            this.Controls.Add(this.labelExportar);
            this.Controls.Add(this.lblSeparadorValores);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.lblLeerFichero);
            this.Controls.Add(this.chkTitulos);
            this.Controls.Add(this.dtg1);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "formCSV";
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dtg1;
        private System.Windows.Forms.CheckBox chkTitulos;
        private System.Windows.Forms.Label lblLeerFichero;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label lblSeparadorValores;
        private System.Windows.Forms.Label labelExportar;
        private System.Windows.Forms.Button btnSeleccionarExportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblSeparadorCampos;
        private System.Windows.Forms.Label lblSeparadorValoresExportar;
        private System.Windows.Forms.TextBox txtLeer;
        private System.Windows.Forms.TextBox txtExportar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtCrear;
        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.TextBox txbComa;
        private System.Windows.Forms.TextBox txbComillas;
        private System.Windows.Forms.TextBox txbPuntoyComa;
        private System.Windows.Forms.TextBox txbComilla1;
        private System.Windows.Forms.Button btnSeleccionarCrear;
    }
}

