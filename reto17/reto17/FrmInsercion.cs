using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reto17
{
    public partial class FrmInsercion : Form
    {
        public FrmInsercion()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if ("".Equals(txtId.Text) || "".Equals(txtNombreTarea.Text) || "".Equals(txtDescripcionTarea.Text) || "".Equals(cbTipoTarea.Text) || "".Equals(dtpFechaTarea.Text))
            {
                MessageBox.Show("No se puede dejar ningún campo sin rellenar");
                return;
            }
            string id = txtId.Text;
            string nombre = txtNombreTarea.Text;
            string descripcion = txtDescripcionTarea.Text;
            string tipo = cbTipoTarea.Text;
            string fecha = dtpFechaTarea.Text;
            string tarea = $"{id};{nombre};{descripcion};{tipo};{fecha}\n";
            StreamWriter sw = new StreamWriter("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto17\\reto17\\Archivos CSV\\Tareas.csv", true, Encoding.UTF8);
            sw.Write(tarea);
            sw.Close();
            txtId.Text = "";
            txtNombreTarea.Text = "";
            txtDescripcionTarea.Text = "";
            cbTipoTarea.Text = "";
            dtpFechaTarea.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
