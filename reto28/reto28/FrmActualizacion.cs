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
    public partial class FrmActualizacion : Form
    {
        public FrmActualizacion()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            SQLiteConnection conn = new SQLiteConnection("Data Source=E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto28\\reto28\\database\\reto28.db;Version=3;New=True;Compress=True");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM persona WHERE codigo = {codigo}";
            SQLiteDataReader dr = cmd.ExecuteReader();
            string[] datos = new string[3];
            if (dr.Read())
            {
                datos[0] = dr.GetInt32(0).ToString();
                datos[1] = dr.GetString(1);
                datos[2] = dr.GetInt32(2).ToString();
            }
            dr.Close();
            conn.Close();
            txtCodigo.Enabled = false;
            txtNombre.Text = datos[1];
            txtEdad.Text = datos[2];
            txtNombre.Enabled = true;
            txtEdad.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            int codigo = int.Parse(txtCodigo.Text);
            SQLiteConnection conn = new SQLiteConnection("Data Source=E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto28\\reto28\\database\\reto28.db;Version=3;New=True;Compress=True");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"UPDATE persona SET nombre = '{nombre}', edad = {edad} WHERE codigo = {codigo}";
            cmd.ExecuteNonQuery();
            conn.Close();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtEdad.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
