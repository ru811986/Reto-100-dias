namespace reto15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!"".Equals(txtNombre.Text) && !"".Equals(txtTelefono.Text) && !"".Equals(txtEmail.Text))
            {
                lblMensaje.Text = "";
                string nuevoContacto = txtNombre.Text + ";" + txtTelefono.Text + ";" + txtEmail.Text;
                bool insertado = false;
                if (lbAgenda.Items.Count > 0)
                {
                    for (int i = 0; i < lbAgenda.Items.Count && !insertado; i++)
                    {
                        if (lbAgenda.Items[i].Equals(nuevoContacto))
                        {
                            insertado = true;
                        }
                    }
                    if (!insertado)
                    {
                        lbAgenda.Items.Add(nuevoContacto);
                    }
                }
                else
                {
                    lbAgenda.Items.Add(nuevoContacto);
                }
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtEmail.Text = "";
            }
            else
            {
                string mensaje = "";
                if ("".Equals(txtNombre.Text))
                {
                    mensaje += "No ha introducido el nombre.\n";
                }
                if ("".Equals(txtTelefono.Text))
                {
                    mensaje += "No ha introducido el teléfono.\n";
                }
                if ("".Equals(txtEmail.Text))
                {
                    mensaje += "No ha introducido el email.\n";
                }
                lblMensaje.Text = mensaje;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indiceAModificar = 0;
            if ("".Equals(txtNombre.Text) && "".Equals(txtTelefono.Text) && "".Equals(txtEmail.Text))
            {
                indiceAModificar = lbAgenda.SelectedIndex;
                string contactoSeleccionado = (string)lbAgenda.SelectedItem;
                string[] datos = contactoSeleccionado.Split(';');
                txtNombre.Text = datos[0];
                txtTelefono.Text = datos[1];
                txtEmail.Text = datos[2];
            } else
            {
                string contactoModificado = txtNombre.Text + ";" + txtTelefono.Text + ";" + txtEmail.Text;
                lbAgenda.Items.RemoveAt(indiceAModificar + 1);
                lbAgenda.Items.Insert(indiceAModificar + 1, contactoModificado);
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtEmail.Text = "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lbAgenda.Items.RemoveAt(lbAgenda.SelectedIndex);
        }
    }
}