using System.Data.SQLite;
using System.Text;

namespace reto28
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void insertarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsercion frm = new FrmInsercion();
            frm.ShowDialog();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dgvPersonas.Rows.Clear();
            SQLiteConnection conn = new SQLiteConnection("Data Source=E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto28\\reto28\\database\\reto28.db;Version=3;New=True;Compress=True");
            conn.Open();
            List<string> listaDePersonas = new List<string>();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM persona";
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string persona = $"{dr.GetInt32(0)};{dr.GetString(1)};{dr.GetInt32(2)}";
                listaDePersonas.Add(persona);
            }
            conn.Close();
            for (int i = 0; i < listaDePersonas.Count; i++)
            {
                if (!"".Equals(listaDePersonas[i]))
                {
                    string[] datos = listaDePersonas[i].Split(';');
                    dgvPersonas.Rows.Add(datos);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto28\\reto28\\database\\reto28.db;Version=3;New=True;Compress=True");
            conn.Open();
            List<string> listaDePersonas = new List<string>();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM persona";
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string persona = $"{dr.GetInt32(0)};{dr.GetString(1)};{dr.GetInt32(2)}";
                listaDePersonas.Add(persona);
            }
            conn.Close();
            StreamWriter sw = new StreamWriter("C:\\Users\\USUARIO\\Desktop\\ficheroExportado.csv", false, Encoding.UTF8);
            for (int i = 0; i < listaDePersonas.Count; i++)
            {
                if (!"".Equals(listaDePersonas[i]))
                {
                    sw.Write(listaDePersonas[i]);
                }
            }
            sw.Close();
        }

        private void actualizarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizacion frm = new FrmActualizacion();
            frm.ShowDialog();
        }

        private void eliminarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminacion frm = new FrmEliminacion();
            frm.ShowDialog();
        }
    }
}