namespace reto14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double suma = double.Parse(txtOperando1.Text) + double.Parse(txtOperando2.Text);
            lblResultado.Text = $"La suma de {txtOperando1.Text} y de {txtOperando2.Text} es de {suma}";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            double resta = double.Parse(txtOperando1.Text) - double.Parse(txtOperando2.Text);
            lblResultado.Text = $"La resta de {txtOperando1.Text} y de {txtOperando2.Text} es de {resta}";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double multiplicacion = double.Parse(txtOperando1.Text) * double.Parse(txtOperando2.Text);
            lblResultado.Text = $"La multiplicación de {txtOperando1.Text} y de {txtOperando2.Text} es de {multiplicacion}";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double division = double.Parse(txtOperando1.Text) / double.Parse(txtOperando2.Text);
            lblResultado.Text = $"La división de {txtOperando1.Text} y de {txtOperando2.Text} es de {division}";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtOperando1.Text = "";
            txtOperando2.Text = "";
            lblResultado.Text = "";
        }
    }
}