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
    public partial class FrmVerLibros : Form
    {
        public FrmVerLibros()
        {
            InitializeComponent();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.Rows.Count > 0)
            {
                dgvLibros.Rows.Clear();
            }
            StreamReader sr = new StreamReader("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto20\\reto20\\archivos\\libros.csv");
            string registros = sr.ReadToEnd();
            sr.Close();
            List<string> listaDeLibros = registros.Split('\n').ToList();
            foreach (string libro in listaDeLibros)
            {
                if (!"".Equals(libro))
                {
                    string[] datosLibro = libro.Split(';');
                    dgvLibros.Rows.Add(datosLibro);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            FrmExportarLibros frm = new FrmExportarLibros();
            frm.ShowDialog();
        }
    }
}
