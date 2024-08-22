namespace reto20
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void insertarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsercionLibro frm = new FrmInsercionLibro();
            frm.ShowDialog();
        }

        private void actualizarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizacionLibro frm = new FrmActualizacionLibro();
            frm.ShowDialog();
        }

        private void eliminarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminacionLibro frm = new FrmEliminacionLibro();
            frm.ShowDialog();
        }

        private void verLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerLibros frm = new FrmVerLibros();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}