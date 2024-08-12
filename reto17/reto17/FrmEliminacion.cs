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
    public partial class FrmEliminacion : Form
    {
        public FrmEliminacion()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            StreamReader sr = new StreamReader("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto17\\reto17\\Archivos CSV\\Tareas.csv");
            string tareas = sr.ReadToEnd();
            List<string> listaDeTareas = tareas.Split('\n').ToList();
            string tareasActaulizadas = "";
            for (int i = 0; i < listaDeTareas.Count - 1; i++)
            {
                string[] datos = listaDeTareas[i].Split(';');
                string tarea = listaDeTareas[i];
                if (!id.Equals(datos[0]))
                {
                    tareasActaulizadas += tarea + "\n";
                }
            }
            sr.Close();
            StreamWriter sw = new StreamWriter("E:\\Documentos\\Retos\\C#\\Ejemplos diarios\\reto17\\reto17\\Archivos CSV\\Tareas.csv", false, Encoding.UTF8);
            sw.Write(tareasActaulizadas);
            sw.Close();
            txtId.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
