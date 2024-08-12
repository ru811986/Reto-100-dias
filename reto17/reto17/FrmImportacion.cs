using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reto17
{
    public partial class FrmImportacion : Form
    {
        public FrmImportacion()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtRutaFichero.Text))
            {
                MessageBox.Show("Introduzca la ruta completa del fichero");
                return;
            }
            string rutaFichero = txtRutaFichero.Text;
            StreamReader sr = new StreamReader(rutaFichero);
            string datosFichero = sr.ReadToEnd();
            sr.Close();
            StreamWriter sw = new StreamWriter("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto17\\reto17\\Archivos CSV\\Tareas.csv", true, Encoding.UTF8);
            sw.Write(datosFichero);
            sw.Close();
            txtRutaFichero.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
