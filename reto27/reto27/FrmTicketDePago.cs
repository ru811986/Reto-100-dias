namespace reto27
{
    public partial class FrmTicketDePago : Form
    {
        public FrmTicketDePago()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double sueldoBasico;
            int horasExtras;
            double pagoHoraExtra;
            double renta, fonavi, afp;
            double ingresos, egresos;
            double sueldoNeto;
            sueldoBasico = double.Parse(txtSueldoBasico.Text);
            horasExtras = int.Parse(txtHorasExtras.Text);
            if (rbDiurno.Checked)
            {
                pagoHoraExtra = 10;
            }
            else if (rbNocturno.Checked)
            {
                pagoHoraExtra = 15;
            }
            else
            {
                pagoHoraExtra = 0;
            }
            if (cbRenta.Checked)
            {
                renta = sueldoBasico * 0.1;
            }
            else
            {
                renta = 0;
            }
            if (cbFonavi.Checked)
            {
                fonavi = sueldoBasico * 0.07;
            }
            else
            {
                fonavi = 0;
            }
            if (cbAFP.Checked)
            {
                afp = sueldoBasico * 0.03;
            }
            else
            {
                afp = 0;
            }
            ingresos = sueldoBasico + horasExtras * pagoHoraExtra;
            egresos = renta + fonavi + afp;
            sueldoNeto = ingresos - egresos;
            txtPagoHorasExtras.Text = pagoHoraExtra.ToString();
            txtRenta.Text = renta.ToString();
            txtFonavi.Text = fonavi.ToString();
            txtAfp.Text = afp.ToString();
            txtSueldoNeto.Text = sueldoNeto.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTrabajador.Text = "";
            txtSueldoBasico.Text = "";
            txtHorasExtras.Text = "";
            txtPagoHorasExtras.Text = "";
            txtRenta.Text = "";
            txtFonavi.Text = "";
            txtAfp.Text = "";
            txtSueldoNeto.Text = "";
            rbDiurno.Checked = false;
            rbNocturno.Checked = false;
            cbRenta.Checked = false;
            cbFonavi.Checked = false;
            cbAFP.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}