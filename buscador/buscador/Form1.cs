using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buscador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            web.ScriptErrorsSuppressed= true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            web.Navigate("www.google.com");
            txb_Url.Text = "www.google.com";
        }

        

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            web.GoBack();
        }

        private void btn_Adelante_Click(object sender, EventArgs e)
        {
            web.GoForward();
        }

        private void btn_Ir_Click(object sender, EventArgs e)
        {
            web.Navigate(txb_Url.Text);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            web.Refresh();
        }
    }
}
