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
    public partial class FrmEliminacion : Form
    {
        public FrmEliminacion()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            SQLiteConnection conn = new SQLiteConnection("Data Source=E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto28\\reto28\\database\\reto28.db;Version=3;New=True;Compress=True");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"DELETE FROM persona WHERE codigo = {codigo}";
            cmd.ExecuteNonQuery();
            conn.Close();
            txtCodigo.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
