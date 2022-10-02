using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
        FolderBrowserDialog abrirfolder = new FolderBrowserDialog();
       
        string[] archivo, ruta;

        private void abrir_Click(object sender, EventArgs e)
        {
            if (abrirfolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lblNombre.Text = abrirfolder.SelectedPath;
            }
        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Multiselect = true;
            OpenFileDialog1.InitialDirectory = lblNombre.Text;
            OpenFileDialog1.Filter = "Archivo MP3 (*.mp3)|*.mp3 | Archivo MP4 (*.mp4)|*.mp4 ";
            if (OpenFileDialog1.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                archivo = OpenFileDialog1.SafeFileNames;
                ruta = OpenFileDialog1.FileNames;

                for(int i = 0; i < archivo.Length; i++)
                {
                    lb_Lista.Items.Add(archivo[i]);
                }
            }
        }

        
        private void limpiar_Lista_Click(object sender, EventArgs e)
        {
            lb_Lista.Items.Clear();

        }

       
        private void lb_Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta[lb_Lista.SelectedIndex];
        }

        
        private void play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta[lb_Lista.SelectedIndex];
        }

       
        private void restaurar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        

        private void pausar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        

        private void stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        
        private void antes_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
        }

       

        private void siguiente_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
