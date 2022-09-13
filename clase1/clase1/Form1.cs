using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase1
{
    public partial class Form1 : Form
    {
        int n=0 ,j=0, i=0, bandera1=0, bandera2=0, bandera3=0;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tmr1.Enabled = true;
            tmr2.Enabled = true;
            tmr3.Enabled = true;
            
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
           

            if (bandera1== 0 && n <100)
            {
                
                n++;

                lbl.Text = n.ToString();

                if (n == 100)
                {
                    bandera1 = 1;

                }

            }

            else if (bandera1 == 1)
            {
                n--;
                lbl.Text = n.ToString();


                if (n == 0)
                {
                    bandera1 = 0;

                }
            }


           

        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            if (bandera2 == 0 && j < 20)
            {

                j++;

                lbl2.Text = j.ToString();

                if (j == 20)
                {
                    bandera2 = 1;

                }

            }

            else if (bandera2 == 1)
            {
                j--;
                lbl2.Text = j.ToString();


                if (j == 0)
                {
                    bandera2 = 0;

                }
            }

            

        
        }

        private void tmr3_Tick(object sender, EventArgs e)
        {
            if (bandera3 == 0 && i < 50)
            {

                i++;

                lbl3.Text = i.ToString();

                if (i == 50)
                {
                    bandera3 = 1;

                }

            }

            else if (bandera3 == 1)
            {
                i--;
                lbl3.Text = i.ToString();


                if (i == 0)
                {
                    bandera3 = 0;

                }
            }
        }

    }
}
