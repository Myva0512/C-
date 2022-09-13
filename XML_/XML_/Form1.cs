using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Contracts;

namespace XML_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string patchCarpeta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Planos";
        string direccion;
        

        public void Leer(string direccion, string line = "")
        {
            try
            {
                using (StreamReader reader = new StreamReader(direccion))
                {

                }
            }
            catch (Exception) { }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            List<Nombres> p1 = new List<Nombres>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Nombres>));
            p1.Add(new Nombres() { Nombre = "", Apellido = "", Edad = 0, Barrio= ""  });
            

            btnGuardar.Visible = false;

            if (!Directory.Exists(patchCarpeta))
            {
                Directory.CreateDirectory(patchCarpeta);
            }
            if (txbNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.");
            }
            else if (!File.Exists(patchCarpeta + $"\\{txbNombre.Text}.xml"))
            {
                List<Nombres> p2 = new List<Nombres>();
                XmlSerializer serial1 = new XmlSerializer(typeof(List<Nombres>));

                for (int i = 0; i < dtg1.Rows.Count - 1; i++)
                {
                    p1.Add(new Nombres()
                    {
                        Nombre = "" ,
                        Apellido = "" ,
                        Edad = 0 ,
                        Barrio = "" 
                    });
                }
                using (System.IO.FileStream nw = new FileStream(patchCarpeta + $"\\{txbNombre.Text}.xml", FileMode.Create, FileAccess.Write))
                {
                    serial.Serialize(nw, p1);
                    MessageBox.Show("Archivo creado correctamente");
                }
                direccion = patchCarpeta + $"\\{txbNombre.Text}.xml"; Leer(direccion);
            }
            else
            {
                MessageBox.Show("Ya existe un archivo con ese nombre.");
            }


        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlficheroXML = new OpenFileDialog();
            dlficheroXML.Title = "Abrir Fichero XML...";
            dlficheroXML.Filter = "Ficheros de texto y XML (*.txt,*.xml) |*.txt,*.xml|" +
                "Ficheros de texto (*.txt) |*.txt|" +
                "Fichero XML (*.xml) |*.xml|" +
                "Todos los ficheros (*.*) | *.*";
            dlficheroXML.FilterIndex = 1;
            dlficheroXML.RestoreDirectory = true;

            if (dlficheroXML.ShowDialog() == DialogResult.OK)
            {
                txbNombre.Text = dlficheroXML.FileName;
            }
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(txbNombre.Text);
            dtg1.DataSource = dataSet.Tables[0];

            btnGuardar.Visible = false;
            txbNombre.Visible = true;
            lblNombre.Visible = true;

        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            dtg1.ReadOnly = false;
            btnGuardar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Nombres> p1 = new List<Nombres>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Nombres>));

            for (int i = 0; i < dtg1.Rows.Count -1; i++)
            {
                p1.Add(new Nombres()
                {
                    Nombre = "" + dtg1.Rows[i].Cells[0].Value,
                    Apellido = "" + dtg1.Rows[i].Cells[1].Value,
                    Edad = 0 + Convert.ToInt32(dtg1.Rows[i].Cells[2].Value),
                    Barrio = "" + dtg1.Rows[i].Cells[3].Value
                });
            }
            using (System.IO.FileStream nw = new FileStream(direccion, FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(nw,p1);
                MessageBox.Show("Archivo guardado correctamente");
            }




        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = false;
            File.Delete (patchCarpeta + $"\\{txbNombre.Text}.xml");
            dtg1.Visible = false;
           
        }
    }
}
