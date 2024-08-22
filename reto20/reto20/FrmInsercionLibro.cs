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
    public partial class FrmInsercionLibro : Form
    {
        public FrmInsercionLibro()
        {
            InitializeComponent();
        }

        private void btnHallarSignatura_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            libro.Titulo = txtTitulo.Text;
            libro.Autor = txtAutor.Text;
            libro.Signatura = libro.HallarSignatura();
            txtSignatura.Text = libro.Signatura;
        }

        private void btnInsertarLibro_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtSignatura.Text) || "".Equals(txtTitulo.Text) || "".Equals(txtAutor.Text))
            {
                MessageBox.Show("Hay que introducir todos los campos salvo el de la signatura que se halla con los campos título y autor");
                return;
            }
            Libro libro = new Libro();
            libro.Signatura = txtSignatura.Text;
            libro.Titulo = txtTitulo.Text;
            libro.Autor = txtAutor.Text;
            StreamWriter sw = new StreamWriter("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto20\\reto20\\archivos\\libros.csv", true, Encoding.UTF8);
            sw.WriteLine(libro.FormatearCadena());
            sw.Close();
            txtSignatura.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
