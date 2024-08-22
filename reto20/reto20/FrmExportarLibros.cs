using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reto20
{
    public partial class FrmExportarLibros : Form
    {
        public FrmExportarLibros()
        {
            InitializeComponent();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto20\\reto20\\archivos\\libros.csv");
            string textoFichero = sr.ReadToEnd();
            sr.Close();
            string ruta = txtNombreRuta.Text;
            StreamWriter sw = new StreamWriter(ruta, false, Encoding.UTF8);
            sw.Write(textoFichero);
            sw.Close();
            txtNombreRuta.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
