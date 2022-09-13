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

namespace xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            List<person> p1 = new List<person>();
            XmlSerializer serial = new XmlSerializer(typeof(List<person>));
            p1.Add(new person() { id = 1, nombre = "julian" });
            p1.Add(new person() { id = 2, nombre = "pedro" });

            using (System.IO.FileStream fs = new FileStream(Environment.CurrentDirectory + "\\personas.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, p1);
                MessageBox.Show("Creado");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            List<person> p1 = new List<person>();
            XmlSerializer serial = new XmlSerializer(typeof(List<person>));
            using (System.IO.FileStream fs = new FileStream(Environment.CurrentDirectory + "\\personas.xml", FileMode.Open, FileAccess.Read))
            {
               p1= serial.Deserialize(fs) as List<person>;                
            }
            dataGridView1.DataSource = p1;
        }
    }
}
