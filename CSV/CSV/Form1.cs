using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CSV
{
    public partial class formCSV : Form
    {
        public string CustomerName;
        public string Title;
        public DateTime Deadline;

        public formCSV()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlficheroCSV = new OpenFileDialog();
            dlficheroCSV.Title = "Abrir Fichero CSV...";
            dlficheroCSV.Filter = "Ficheros de texto y CSV (*.txt,*.csv) |*.txt,*.csv|" +
                "Ficheros de texto (*.txt) |*.txt|" +
                "Fichero CSV (*.csv) |*.csv|" +
                "Todos los ficheros (*.*) | *.*";
            dlficheroCSV.FilterIndex = 1;
            dlficheroCSV.RestoreDirectory = true;

            if (dlficheroCSV.ShowDialog() == DialogResult.OK)
            {
               txtLeer.Text = dlficheroCSV.FileName;
               
            }


        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtLeer.Text))
            {
                try
                {
                    CargarDatosCSV(txtLeer.Text,
                        Convert.ToChar(txbComa.Text), chkTitulos.Checked, txbComillas.Text);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error al leer CSV...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show("No existe el fichero CSV seleccionado",
                    "Fichero no encontrado...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarDatosCSV (String ficheroCSV, char separador, bool primeraLineaTitulo,String separadorCampos)
        {
            dtg1.DataSource = null;
            dtg1.Rows.Clear();

            DataTable tablaDatos = new DataTable();
            string[] lineas = File.ReadAllLines(ficheroCSV, Encoding.Default);

            if (lineas.Length > 0)
            {
                //Si la primea línea contiene el título  
                string[] etiquetaTitulosFinal;
                if (primeraLineaTitulo)
                {
                    string primelaLinea = lineas[0];
                    string[] etiquetaTitulos = primelaLinea.Split(separador);
                    List<string> lista = new List<string>();
                    foreach (string campoActual in etiquetaTitulos)
                    {
                        string valor = campoActual;
                        // Quitamos el posible carácter de inicio y fin de valor
                        if (separadorCampos != "")
                        {
                            valor = valor.TrimEnd(Convert.ToChar(separadorCampos));
                            valor = valor.TrimStart(Convert.ToChar(separadorCampos));
                        }
                        tablaDatos.Columns.Add(new DataColumn(valor));
                        lista.Add(valor);
                    }
                    etiquetaTitulosFinal = lista.ToArray();
                }
                else
                {
                    string primelaLinea = lineas[0];
                    string[] etiquetaTitulos = primelaLinea.Split(separador);
                    int numero = 0;
                    List<string> lista = new List<string>();
                    foreach (string campoActual in etiquetaTitulos)
                    {
                        string valor = "C" + Convert.ToString(numero);
                        // Quitamos el posible carácter de inicio y fin de valor
                        if (separadorCampos != "")
                        {
                            valor = valor.TrimEnd(Convert.ToChar(separadorCampos));
                            valor = valor.TrimStart(Convert.ToChar(separadorCampos));
                        }

                        tablaDatos.Columns.Add(new DataColumn(valor));
                        lista.Add(valor);
                        numero++;
                    }
                    etiquetaTitulosFinal = lista.ToArray();
                }
                //Resto de filas de datos
                int inicioFila = 0;
                if (primeraLineaTitulo)
                    inicioFila = 1;

                for (int i = inicioFila; i < lineas.Length; i++)
                {
                    string[] filasDatos = lineas[i].Split(separador);
                    DataRow dataGridS = tablaDatos.NewRow();
                    int columnIndex = 0;
                    foreach (string campoActual in etiquetaTitulosFinal)
                    {
                        string valor = filasDatos[columnIndex++];
                        // Quitamos el posible carácter de inicio y fin de valor
                        if (separadorCampos != "")
                        {
                            valor = valor.TrimEnd(Convert.ToChar(separadorCampos));
                            valor = valor.TrimStart(Convert.ToChar(separadorCampos));
                        }
                        dataGridS[campoActual] = valor;
                    }
                    tablaDatos.Rows.Add(dataGridS);
                }
            }
            if (tablaDatos.Rows.Count > 0)
            {
                dtg1.DataSource = tablaDatos;
            }
        

    
        }

        private void btnSeleccionarExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlFicheroCSV = new SaveFileDialog();
            dlFicheroCSV.Title = "Exportar fichero CSV...";
            dlFicheroCSV.Filter = "Ficheros de texto y CSV (*.txt, *.csv)|*.txt;*.csv|" +
                "Ficheros de texto (*.txt)|*.txt|" +
                "Ficheros CSV (*.csv)|*.csv|" +
                "Todos los ficheros (*.*)|*.*";
            dlFicheroCSV.FilterIndex = 1;
            dlFicheroCSV.OverwritePrompt = true;
            if (dlFicheroCSV.ShowDialog() == DialogResult.OK)
            {
                txtExportar.Text = dlFicheroCSV.FileName;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string caracterSeparadorCampos = txbPuntoyComa.Text;
            if (txtExportar.Text == "" || caracterSeparadorCampos == "")
            {
                MessageBox.Show("Debe indicar el fichero CSV en el que se exportará " +
                    "la información, así como el separador a usar.", "Exportar a CSV...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtExportar.Focus();
            }
            else
            {
                string caracterSeparadorValores = txbComilla1.Text;
                if (Directory.Exists(Path.GetDirectoryName(txtExportar.Text)))
                {
                    StringBuilder csvMemoria = new StringBuilder();

                    //para los títulos de las columnas, encabezado
                    for (int i = 0; i < dtg1.Columns.Count; i++)
                    {
                        if (i == dtg1.Columns.Count - 1)
                        {
                            csvMemoria.Append(String.Format(caracterSeparadorValores + "{0}" +
                                caracterSeparadorValores,
                                dtg1.Columns[i].HeaderText));
                        }
                        else
                        {
                            csvMemoria.Append(String.Format(caracterSeparadorValores + "{0}" +
                                caracterSeparadorValores + caracterSeparadorCampos,
                                dtg1.Columns[i].HeaderText));
                        }
                    }
                    csvMemoria.AppendLine();

                    for (int m = 0; m < dtg1.Rows.Count; m++)
                    {
                        for (int n = 0; n < dtg1.Columns.Count; n++)
                        {
                            //si es la última columna no poner el separador
                            if (n == dtg1.Columns.Count - 1)
                            {
                                csvMemoria.Append(String.Format(caracterSeparadorValores + "{0}" +
                                    caracterSeparadorValores,
                                     dtg1.Rows[m].Cells[n].Value));
                            }
                            else
                            {
                                csvMemoria.Append(String.Format(caracterSeparadorValores + "{0}" +
                                    caracterSeparadorValores + caracterSeparadorCampos,
                                    dtg1.Rows[m].Cells[n].Value));
                            }
                        }
                        csvMemoria.AppendLine();
                    }
                    try
                    {
                        System.IO.StreamWriter sw =
                            new System.IO.StreamWriter(txtExportar.Text, false,
                               System.Text.Encoding.Default);
                        sw.Write(csvMemoria.ToString(), Encoding.Default);
                        sw.Close();
                        MessageBox.Show("Se ha exportado el contenido del grid al fichero CSV correctamente.",
                            "Exportado a fichero CSV...",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error al exportar CSV...",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtExportar.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("La carpeta indicada para el fichero de exportación CSV no existe.",
                        "Exportar a fichero CSV...",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnSeleccionarCrear_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlFicheroCSV = new SaveFileDialog();
            dlFicheroCSV.Title = "Exportar fichero CSV...";
            dlFicheroCSV.Filter = "Ficheros de texto y CSV (*.txt, *.csv)|*.txt;*.csv|" +
                "Ficheros de texto (*.txt)|*.txt|" +
                "Ficheros CSV (*.csv)|*.csv|" +
                "Todos los ficheros (*.*)|*.*";
            dlFicheroCSV.FilterIndex = 1;
            dlFicheroCSV.OverwritePrompt = true;
            if (dlFicheroCSV.ShowDialog() == DialogResult.OK)
            {
                txtCrear.Text = dlFicheroCSV.FileName;
            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtLeer.Text))
            {
                try
                {
                    CargarDatosCSV(txtLeer.Text,
                        Convert.ToChar(txbComa.Text), chkTitulos.Checked, txbComillas.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error al leer CSV...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No existe el fichero CSV seleccionado",
                    "Fichero no encontrado...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
    }
  
}
