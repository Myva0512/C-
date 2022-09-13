using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concecionario
{
    public partial class impresion : Form
    {
        string path = @"c:\Windows\temp\Imprimir.txt";
        int i = 0;
        public impresion()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void imprimir()
        {
            StreamReader sr = new StreamReader(path);
            {
                string s = "";
                while ((s = sr.ReadLine()) != null) 
                {
                    label3.Text += "\n" + s;
                }
            }
            timer1.Enabled = false;
        }

        private void impresion_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i == 0)
            {
                label1.Visible = true;
                i++;
            }else if (i == 1)
            {
                label2.Visible = true;
                i++;
            }else if (i == 2)
            {
                imprimir();
                i = 0;
            }
        }
    }
}
