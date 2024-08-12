using reto17.Archivos_CSV;

namespace reto17
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void insertarTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsercion frm = new FrmInsercion();
            frm.ShowDialog();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            tblTareas.Rows.Clear();
            StreamReader sr = new StreamReader("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto17\\reto17\\Archivos CSV\\Tareas.csv");
            string tareas = sr.ReadToEnd();
            List<string> listaDeTareas = tareas.Split('\n').ToList();
            for (int i = 0; i < listaDeTareas.Count - 1; i++)
            {
                string[] datos = listaDeTareas[i].Split(';');
                tblTareas.Rows.Add(datos[1], datos[2], datos[3], datos[4]);
            }
            sr.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizacion frm = new FrmActualizacion();
            frm.ShowDialog();
        }

        private void eliminarTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminacion frm = new FrmEliminacion();
            frm.ShowDialog();
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImportacion frm = new FrmImportacion();
            frm.ShowDialog();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExportacion frm = new FrmExportacion();
            frm.ShowDialog();
        }
    }
}