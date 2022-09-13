using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string patchCarpeta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Planos";
        string direccion;
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlficheroRtf = new OpenFileDialog();
            dlficheroRtf.Title = "Abrir Fichero RTF...";
            dlficheroRtf.Filter = "Ficheros de texto y RTF (*.rtf) |*.rtf|" +
                "Fichero RTF (*.rtf) |*.rtf|" +
                "Todos los ficheros (*.*) | *.*";
            dlficheroRtf.FilterIndex = 1;
            dlficheroRtf.RestoreDirectory = true;

            if (dlficheroRtf.ShowDialog() == DialogResult.OK)
            {
                txtLeer.Text = dlficheroRtf.FileName;

                Rtb1.LoadFile(txtLeer.Text);

            }
        }

            private void btnGuardar_Click(object sender, EventArgs e)
            {
                SaveFileDialog dlFicheroRtf = new SaveFileDialog();
                dlFicheroRtf.Title = "Exportar fichero RTF...";
                dlFicheroRtf.Filter = "Ficheros de texto y RTF (*.rtf) |*.rtf|" +
                      "Fichero RTF (*.rtf) |*.rtf|" +
                    "Todos los ficheros (*.*)|*.*";
                dlFicheroRtf.FilterIndex = 1;
                dlFicheroRtf.OverwritePrompt = true;
                if (dlFicheroRtf.ShowDialog() == DialogResult.OK)
                {
                    txtGuardar.Text = dlFicheroRtf.FileName;
                }
            }

            private void btnBorrar_Click(object sender, EventArgs e)
            {
                File.Delete(patchCarpeta + $"\\{txbNombre.Text}.rtf");
            }

            private void btnCrear_Click(object sender, EventArgs e)
            {


                if (!Directory.Exists(patchCarpeta))
                {
                    Directory.CreateDirectory(patchCarpeta);
                }
                if (txbNombre.Text == "")
                {
                    MessageBox.Show("Ingrese un nombre.");
                }

                else if ((!File.Exists(patchCarpeta + $"\\{txbCrear.Text}.rtf")))
                {
                    using (System.IO.FileStream nw = new FileStream(patchCarpeta + $"\\{txbCrear.Text}.rtf", FileMode.Create, FileAccess.Write))
                    {

                        MessageBox.Show("Archivo creado correctamente");
                    }
                    direccion = patchCarpeta + $"\\{txbCrear.Text}.rtf";
                }
                else
                {
                    MessageBox.Show("Ya existe un archivo con ese nombre.");
                }
            }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Rtb1.ReadOnly = false;
        }

        
    }
}

