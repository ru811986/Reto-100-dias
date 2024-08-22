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
    public partial class FrmEliminacionLibro : Form
    {
        public FrmEliminacionLibro()
        {
            InitializeComponent();
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            Libro libro = new Libro();
            libro.Titulo = titulo;
            libro.Autor = autor;
            libro.Signatura = libro.HallarSignatura();
            string sRuta = "E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto20\\reto20\\archivos\\libros.csv";
            string signatura = libro.Signatura;
            int indiceColumna = 0;
            var lineas = File.ReadAllLines(sRuta);
            var lineasFiltradas = lineas.Where(linea =>
            {
                var columnas = linea.Split(';');
                return columnas.Length > indiceColumna && columnas[indiceColumna] != signatura;
            });
            File.WriteAllLines(sRuta, lineasFiltradas);
            txtTitulo.Text = "";
            txtAutor.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
