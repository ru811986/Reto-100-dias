namespace reto17
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tareasToolStripMenuItem = new ToolStripMenuItem();
            insertarTareaToolStripMenuItem = new ToolStripMenuItem();
            actualizarTareaToolStripMenuItem = new ToolStripMenuItem();
            eliminarTareaToolStripMenuItem = new ToolStripMenuItem();
            archivoCSVToolStripMenuItem = new ToolStripMenuItem();
            importarToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            lblTareas = new Label();
            tblTareas = new DataGridView();
            nombreTarea = new DataGridViewTextBoxColumn();
            descripcionTarea = new DataGridViewTextBoxColumn();
            tipoTarea = new DataGridViewTextBoxColumn();
            fechaTarea = new DataGridViewTextBoxColumn();
            btnRecargar = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblTareas).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tareasToolStripMenuItem, archivoCSVToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tareasToolStripMenuItem
            // 
            tareasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertarTareaToolStripMenuItem, actualizarTareaToolStripMenuItem, eliminarTareaToolStripMenuItem });
            tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            tareasToolStripMenuItem.Size = new Size(51, 20);
            tareasToolStripMenuItem.Text = "Tareas";
            // 
            // insertarTareaToolStripMenuItem
            // 
            insertarTareaToolStripMenuItem.Name = "insertarTareaToolStripMenuItem";
            insertarTareaToolStripMenuItem.Size = new Size(180, 22);
            insertarTareaToolStripMenuItem.Text = "Insertar tarea";
            insertarTareaToolStripMenuItem.Click += insertarTareaToolStripMenuItem_Click;
            // 
            // actualizarTareaToolStripMenuItem
            // 
            actualizarTareaToolStripMenuItem.Name = "actualizarTareaToolStripMenuItem";
            actualizarTareaToolStripMenuItem.Size = new Size(180, 22);
            actualizarTareaToolStripMenuItem.Text = "Actualizar tarea";
            actualizarTareaToolStripMenuItem.Click += actualizarTareaToolStripMenuItem_Click;
            // 
            // eliminarTareaToolStripMenuItem
            // 
            eliminarTareaToolStripMenuItem.Name = "eliminarTareaToolStripMenuItem";
            eliminarTareaToolStripMenuItem.Size = new Size(180, 22);
            eliminarTareaToolStripMenuItem.Text = "Eliminar tarea";
            eliminarTareaToolStripMenuItem.Click += eliminarTareaToolStripMenuItem_Click;
            // 
            // archivoCSVToolStripMenuItem
            // 
            archivoCSVToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importarToolStripMenuItem, exportarToolStripMenuItem });
            archivoCSVToolStripMenuItem.Name = "archivoCSVToolStripMenuItem";
            archivoCSVToolStripMenuItem.Size = new Size(84, 20);
            archivoCSVToolStripMenuItem.Text = "Archivo CSV";
            // 
            // importarToolStripMenuItem
            // 
            importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            importarToolStripMenuItem.Size = new Size(180, 22);
            importarToolStripMenuItem.Text = "Importar";
            importarToolStripMenuItem.Click += importarToolStripMenuItem_Click;
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.Size = new Size(180, 22);
            exportarToolStripMenuItem.Text = "Exportar";
            exportarToolStripMenuItem.Click += exportarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // lblTareas
            // 
            lblTareas.AutoSize = true;
            lblTareas.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTareas.Location = new Point(300, 24);
            lblTareas.Name = "lblTareas";
            lblTareas.Size = new Size(191, 65);
            lblTareas.TabIndex = 1;
            lblTareas.Text = "TAREAS";
            // 
            // tblTareas
            // 
            tblTareas.AllowUserToAddRows = false;
            tblTareas.AllowUserToDeleteRows = false;
            tblTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblTareas.Columns.AddRange(new DataGridViewColumn[] { nombreTarea, descripcionTarea, tipoTarea, fechaTarea });
            tblTareas.Location = new Point(12, 92);
            tblTareas.Name = "tblTareas";
            tblTareas.ReadOnly = true;
            tblTareas.RowTemplate.Height = 25;
            tblTareas.Size = new Size(776, 346);
            tblTareas.TabIndex = 2;
            // 
            // nombreTarea
            // 
            nombreTarea.HeaderText = "Nombre tarea";
            nombreTarea.Name = "nombreTarea";
            nombreTarea.ReadOnly = true;
            nombreTarea.Width = 150;
            // 
            // descripcionTarea
            // 
            descripcionTarea.HeaderText = "Descripción tarea";
            descripcionTarea.Name = "descripcionTarea";
            descripcionTarea.ReadOnly = true;
            descripcionTarea.Width = 350;
            // 
            // tipoTarea
            // 
            tipoTarea.HeaderText = "Tipo tarea";
            tipoTarea.Name = "tipoTarea";
            tipoTarea.ReadOnly = true;
            // 
            // fechaTarea
            // 
            fechaTarea.HeaderText = "Fecha tarea";
            fechaTarea.Name = "fechaTarea";
            fechaTarea.ReadOnly = true;
            fechaTarea.Width = 130;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(713, 464);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(75, 23);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(btnRecargar);
            Controls.Add(tblTareas);
            Controls.Add(lblTareas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Aplicación 4";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblTareas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tareasToolStripMenuItem;
        private ToolStripMenuItem insertarTareaToolStripMenuItem;
        private ToolStripMenuItem actualizarTareaToolStripMenuItem;
        private ToolStripMenuItem eliminarTareaToolStripMenuItem;
        private ToolStripMenuItem archivoCSVToolStripMenuItem;
        private ToolStripMenuItem importarToolStripMenuItem;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label lblTareas;
        private DataGridView tblTareas;
        private DataGridViewTextBoxColumn nombreTarea;
        private DataGridViewTextBoxColumn descripcionTarea;
        private DataGridViewTextBoxColumn tipoTarea;
        private DataGridViewTextBoxColumn fechaTarea;
        private Button btnRecargar;
    }
}