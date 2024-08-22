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
    public partial class FrmActualizacionLibro : Form
    {
        public FrmActualizacionLibro()
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

        private void btnActualizarLibro_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();
            libro.Signatura = txtSignatura.Text;
            libro.Titulo = txtTitulo.Text;
            libro.Autor = txtAutor.Text;
            string sLibro = libro.FormatearCadena();
            StreamWriter sw = new StreamWriter("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto20\\reto20\\archivos\\libros.csv", true, Encoding.UTF8);
            sw.Write(sLibro);
            sw.Close();
            txtSignatura.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtSignatura.Enabled = true;
            txtTitulo.Enabled = false;
            txtAutor.Enabled = false;
            rbTitulo.Checked = false;
            rbAutor.Checked = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (rbTitulo.Checked)
            {
                txtTitulo.Enabled = true;
            } else if (rbAutor.Checked)
            {
                txtAutor.Enabled = true;
            }
        }

        private void btnCargarLibro_Click(object sender, EventArgs e)
        {
            string signatura = txtSignatura.Text;
            StreamReader sr = new StreamReader("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto20\\reto20\\archivos\\libros.csv");
            string libros = sr.ReadToEnd();
            List<string> listaDeLibros = libros.Split('\n').ToList();
            for (int i = 0; i < listaDeLibros.Count; i++)
            {
                if (!"".Equals(listaDeLibros[i]))
                {
                    string[] datos = listaDeLibros[i].Split(';');
                    Libro libro = new Libro();
                    libro.Signatura = datos[0];
                    libro.Titulo = datos[1];
                    libro.Autor = datos[2];
                    if (signatura.Equals(libro.Signatura))
                    {
                        txtTitulo.Text = libro.Titulo;
                        txtAutor.Text = libro.Autor;
                    }
                }
            }
            sr.Close();
            StreamWriter sw = new StreamWriter("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto20\\reto20\\archivos\\libros.csv", false, Encoding.UTF8);
            for (int i = 0; i < listaDeLibros.Count; i++)
            {
                if (!"".Equals(listaDeLibros[i]))
                {
                    if (!signatura.Equals(txtSignatura.Text))
                    {
                        sw.WriteLine(listaDeLibros[i]);
                    }
                }
            }
            sw.Close();
            txtSignatura.Enabled = false;
        }
    }
}
