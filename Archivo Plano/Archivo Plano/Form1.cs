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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace Archivo_Plano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool leer = false;
        string direccion;
        string patchCarpeta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Planos";

        public void Leer(string direccion, string line = "")
        {
            try
            {
                using (StreamReader reader = new StreamReader(direccion))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        txbEscritorio.Text += line + "\r\n";
                    }
                } leer = true;
            }
            catch (Exception) { }
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            btnBorrar2.Visible = false;
            txbTitulo.Visible = false;
            lblTitulo.Visible = false;
            btnGuardar.Visible = false;

            txbEscritorio.Clear();


            try
            {
                Explorador.Title = "BUSQUEDA";
                Explorador.ShowDialog();
                direccion = Explorador.FileName;
                Leer(direccion);
            }
            catch (Exception) { }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            txbTitulo.Visible = false;
            btnBorrar2.Visible = false;

            if (leer == true)
            {
                txbEscritorio.ReadOnly = false;
                btnGuardar.Visible = true;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(direccion))
                {
                    
                    foreach (string linea in txbEscritorio.Lines)
                    {
                        if (linea == null)
                        {
                            writer.WriteLine("\n");
                        }
                        else
                        {
                            writer.WriteLine(linea);
                        }
                    }
                }
                MessageBox.Show("Archivo guardado");
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = true;
            txbTitulo.Visible = true;
            btnBorrar2.Visible = true;
            
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            txbTitulo.Visible = true;
            lblTitulo.Visible = true;
            btnGUARDAR2.Visible = true;
            if (!Directory.Exists(patchCarpeta))
            {
                Directory.CreateDirectory(patchCarpeta);
            }
            if (txbTitulo.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.");
            }
            else if (!File.Exists(patchCarpeta + $"\\{txbTitulo.Text}.txt"))
            {
                try
                {
                    using (StreamWriter sw = File.CreateText(patchCarpeta + $"\\{txbTitulo.Text}.txt"))
                    {
                        MessageBox.Show("Archivo generado correctamente.");
                    }
                }
                catch (Exception exp)
                {
                    Console.Write(exp.Message);
                }
                direccion = patchCarpeta + $"\\{txbTitulo.Text}.txt"; Leer(direccion);
            }
            else
            {
                MessageBox.Show("Ya existe un archivo con ese nombre.");
            }
        }

        private void btnBorrar2_Click(object sender, EventArgs e)
        {
            if (txbTitulo.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.");
            }
            else if (!File.Exists(patchCarpeta + $"\\{txbTitulo.Text}.txt"))
            {
                MessageBox.Show("El archivo no existe.");
            }
            else
            {
                File.Delete(patchCarpeta + $"\\{txbTitulo.Text}.txt");
                MessageBox.Show("Archivo borrado correctamente.");
                txbEscritorio.Clear();
            }
            txbTitulo.Clear();
        }

        private void btnGUARDAR2_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(patchCarpeta)) { Directory.CreateDirectory(patchCarpeta); }
            if (txbTitulo.Text == "") { MessageBox.Show("Ingrese un nombre."); }
            else if (!File.Exists(patchCarpeta + $"\\{txbTitulo.Text}.txt"))
            {
                try
                {
                    using (StreamWriter sw = File.CreateText(patchCarpeta + $"\\{txbTitulo.Text}.txt"))
                    {
                        MessageBox.Show("Archivo generado correctamente.");
                    }
                }
                catch (Exception exp) { Console.Write(exp.Message); }
                direccion = patchCarpeta + $"\\{txbTitulo.Text}.txt"; Leer(direccion);
            }
            else { MessageBox.Show("Ya existe un archivo con ese nombre."); }
        }
    }
    
}