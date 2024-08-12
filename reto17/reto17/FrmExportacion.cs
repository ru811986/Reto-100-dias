using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reto17.Archivos_CSV
{
    public partial class FrmExportacion : Form
    {
        public FrmExportacion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtRutaFichero.Text))
            {
                MessageBox.Show("Introduzca la ruta completa del fichero");
                return;
            }
            StreamReader sr = new StreamReader("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto17\\reto17\\Archivos CSV\\Tareas.csv");
            string datosFichero = sr.ReadToEnd();
            sr.Close();
            string rutaFichero = txtRutaFichero.Text;
            StreamWriter sw = new StreamWriter(rutaFichero, false, Encoding.UTF8);
            sw.Write(datosFichero);
            sw.Close();
            txtRutaFichero.Text = "";
        }
    }
}
