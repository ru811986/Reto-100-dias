namespace reto13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtNombre.Text))
            {
                lblMensaje.Text = $"Bienvenid@";
            } else
            {
                lblMensaje.Text = $"Bienvenid@ { txtNombre.Text}";
            }
        }
    }
}