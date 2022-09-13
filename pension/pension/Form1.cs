using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se reciben numeros", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtEdad.Text) >= 62 && chkMasculino.Checked)
            {
                MessageBox.Show(txtNombre.Text + " Tiene la edad para pensionarse");

            }

            else if (Convert.ToInt32(txtEdad.Text) < 62 && chkMasculino.Checked)
            {
                MessageBox.Show((txtNombre.Text + " Le faltan " + (62 - Convert.ToInt32(txtEdad.Text)) + " años para pensionarse"));

            }

            else if (Convert.ToInt32(txtEdad.Text) >= 57 && chkFemenino.Checked)
            {

                MessageBox.Show(txtNombre.Text + " Tiene la edad para pensionarse");
            }

            else if (Convert.ToInt32(txtEdad.Text) < 57 && chkFemenino.Checked)
            {
                MessageBox.Show(txtNombre.Text + " Le faltan " + (57 - Convert.ToInt32(txtEdad.Text)) + " años para pensionarse");
                
            }
        }
    }
}
