using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reto28
{
    public partial class FrmInsercion : Form
    {
        public FrmInsercion()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            SQLiteConnection conn = new SQLiteConnection("Data Source=E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto28\\reto28\\database\\reto28.db;Version=3;New=True;Compress=True");
            conn.Open();
            SQLiteCommand cmd =conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO persona(nombre, edad) VALUES('{nombre}', {edad})";
            cmd.ExecuteNonQuery();
            conn.Close();
            txtNombre.Text = "";
            txtEdad.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
