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
    public partial class FrmActualizacion : Form
    {
        public FrmActualizacion()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            StreamReader sr = new StreamReader("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto17\\reto17\\Archivos CSV\\Tareas.csv");
            string tareas = sr.ReadToEnd();
            List<string> listaDeTareas = tareas.Split('\n').ToList();
            for (int i = 0; i < listaDeTareas.Count - 1; i++)
            {
                string tarea = listaDeTareas[i];
                string[] datos = tarea.Split(';');
                if (id.Equals(datos[0]))
                {
                    txtId.Enabled = false;
                    txtNombreTarea.Enabled = true;
                    txtNombreTarea.Text = datos[1];
                    txtDescripcionTarea.Enabled = true;
                    txtDescripcionTarea.Text = datos[2];
                    cbTipoTarea.Enabled = true;
                    cbTipoTarea.Text = datos[3];
                    dtpFechaTarea.Enabled = true;
                    dtpFechaTarea.Text = datos[4];
                }
            }
            sr.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombreTarea.Text;
            string descripcion = txtDescripcionTarea.Text;
            string tipo = cbTipoTarea.Text;
            string fecha = dtpFechaTarea.Text;
            string tareaActualizada = $"{id};{nombre};{descripcion};{tipo};{fecha}\n";
            StreamReader sr = new StreamReader("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto17\\reto17\\Archivos CSV\\Tareas.csv");
            string tareas = sr.ReadToEnd();
            List<string> listaDeTareas = tareas.Split('\n').ToList();
            string tareasActualizadas = "";
            for (int i = 0; i < listaDeTareas.Count - 1; i++)
            {
                string tarea = listaDeTareas[i];
                string[] datos = tarea.Split(';');
                if (id.Equals(datos[0]))
                {
                    tareasActualizadas += tareaActualizada;
                } else
                {
                    tareasActualizadas += tarea + "\n";
                }
            }
            sr.Close();
            StreamWriter sw = new StreamWriter("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto17\\reto17\\Archivos CSV\\Tareas.csv", false, Encoding.UTF8);
            sw.Write(tareasActualizadas);
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
