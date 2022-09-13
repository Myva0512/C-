namespace concecionario
{
    public partial class Form1 : Form
    {
        int n, i=0,m = 2, validar = 0, btn = 0;
        int mod1 = 0,mod2 = 0,mod3 = 0,mod4 = 0;
        string path = @"c:\Windows\temp\Imprimir.txt";
        string[,]nm;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, KeyPressEventArgs e)
        {
            if (validar == 0)
            {
                if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    MessageBox.Show("Solo se reciben numeros", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
                {
                    MessageBox.Show("Solo letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
            
        }
        private void Numeros(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se reciben numeros", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || Convert.ToInt32(textBox1.Text) <= 0)
            {
                MessageBox.Show("Cantidad de trabajadores incorrecta.");
            }
            else
            {
                n = Convert.ToInt32(textBox1.Text);
                nm = new string[n, 6];
                button2.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                button1.Visible = false;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                validar = 1;
                label3.Text = "Ingrese el nombre del vendedor 1";
                textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" && btn == 0)
            {
                MessageBox.Show("Ingrese un nombre");
            }else if (btn == 0)
            {
                int j = 0;
                if (i < n)
                {
                    nm[i, j] = textBox1.Text;
                    textBox1.Clear();
                    j++;
                    if (checkBox1.Checked == true)
                    {
                        if (textBox3.Text == "")
                        {
                            nm[i, j] = "0";
                        }
                        else
                        {
                            nm[i, j] = textBox3.Text;
                            mod1 = ((70000000 * Convert.ToInt32(textBox3.Text)) * 3) / 100;
                        }
                    }
                    else
                    {
                        nm[i, j] = "0";
                    }
                    j++;
                    if (checkBox2.Checked == true)
                    {
                        if (textBox4.Text == "")
                        {
                            nm[i, j] = "0";
                        }
                        else
                        {
                            nm[i, j] = textBox4.Text;
                            mod2 = ((60000000 * Convert.ToInt32(textBox4.Text)) * 3) / 100;
                        }
                    }
                    else
                    {
                        nm[i, j] = "0";
                    }
                    j++;
                    if (checkBox3.Checked == true)
                    {
                        if (textBox5.Text == "")
                        {
                            nm[i, j] = "0";
                        }
                        else
                        {
                            nm[i, j] = textBox5.Text;
                            mod3 = ((74000000 * Convert.ToInt32(textBox5.Text)) * 3) / 100;
                        } 
                    }
                    else
                    {
                        nm[i, j] = "0";
                    }
                    j++;
                    if (checkBox4.Checked == true)
                    {
                        if (textBox6.Text == "")
                        {
                            nm[i, j] = "0";
                        }
                        else
                        {
                            nm[i, j] = textBox6.Text;
                            mod4 = ((80000000 * Convert.ToInt32(textBox6.Text)) * 3) / 100;
                        }
                    }
                    else
                    {
                        nm[i, j] = "0";
                    }
                    j++;
                    nm[i, j] = Convert.ToString(2000000 + (mod1 + mod2 + mod3 + mod4));
                    mod1 = 0; mod2 = 0; mod3 = 0; mod4 = 0;
                    i++;
                    if (m <= n)
                    {
                        label3.Text = "Ingrese el nombre del vendedor " + m;
                        m++;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        checkBox4.Checked = false;
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                    }
                    else
                    {
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        checkBox4.Checked = false;
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        checkBox1.Visible = false;
                        checkBox2.Visible = false;
                        checkBox3.Visible = false;
                        checkBox4.Visible = false;
                        textBox3.Visible = false;
                        textBox4.Visible = false;
                        textBox5.Visible = false;
                        textBox6.Visible = false;
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        button2.Text = "Imprimir";
                        btn = 1;
                        textBox1.Visible = false;
                        label3.Text = "Registro completado";
                    }
                }
            } else if (btn == 1)
            {
                this.Hide();
                impresion impre = new impresion();
                impre.Show();
                StreamWriter sw = new StreamWriter(path);
                i = 0;
                while (i < n)
                {
                    {
                        sw.WriteLine((i + 1) + "                  " + nm[i,0] + "                         " + nm[i,1] + "                             " + nm[i,2] + 
                            "                          " + nm[i,3] + "                              " + nm[i,4] + "                     " + nm[i,5]);
                        sw.WriteLine("\n");
                        i++;
                    }
                }
                sw.Close();
            }
        }
    }
}