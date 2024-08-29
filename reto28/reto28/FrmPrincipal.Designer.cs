namespace reto28
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
            cRUDPersonaToolStripMenuItem = new ToolStripMenuItem();
            insertarPersonaToolStripMenuItem = new ToolStripMenuItem();
            actualizarPersonaToolStripMenuItem = new ToolStripMenuItem();
            eliminarPersonaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            dgvPersonas = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            btnRecargar = new Button();
            btnExportar = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cRUDPersonaToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(369, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cRUDPersonaToolStripMenuItem
            // 
            cRUDPersonaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertarPersonaToolStripMenuItem, actualizarPersonaToolStripMenuItem, eliminarPersonaToolStripMenuItem });
            cRUDPersonaToolStripMenuItem.Name = "cRUDPersonaToolStripMenuItem";
            cRUDPersonaToolStripMenuItem.Size = new Size(95, 20);
            cRUDPersonaToolStripMenuItem.Text = "CRUD persona";
            // 
            // insertarPersonaToolStripMenuItem
            // 
            insertarPersonaToolStripMenuItem.Name = "insertarPersonaToolStripMenuItem";
            insertarPersonaToolStripMenuItem.Size = new Size(180, 22);
            insertarPersonaToolStripMenuItem.Text = "Insertar persona";
            insertarPersonaToolStripMenuItem.Click += insertarPersonaToolStripMenuItem_Click;
            // 
            // actualizarPersonaToolStripMenuItem
            // 
            actualizarPersonaToolStripMenuItem.Name = "actualizarPersonaToolStripMenuItem";
            actualizarPersonaToolStripMenuItem.Size = new Size(180, 22);
            actualizarPersonaToolStripMenuItem.Text = "Actualizar persona";
            actualizarPersonaToolStripMenuItem.Click += actualizarPersonaToolStripMenuItem_Click;
            // 
            // eliminarPersonaToolStripMenuItem
            // 
            eliminarPersonaToolStripMenuItem.Name = "eliminarPersonaToolStripMenuItem";
            eliminarPersonaToolStripMenuItem.Size = new Size(180, 22);
            eliminarPersonaToolStripMenuItem.Text = "Eliminar persona";
            eliminarPersonaToolStripMenuItem.Click += eliminarPersonaToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // dgvPersonas
            // 
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.AllowUserToDeleteRows = false;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Columns.AddRange(new DataGridViewColumn[] { codigo, nombre, edad });
            dgvPersonas.Location = new Point(12, 27);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.ReadOnly = true;
            dgvPersonas.RowTemplate.Height = 25;
            dgvPersonas.Size = new Size(345, 471);
            dgvPersonas.TabIndex = 1;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // edad
            // 
            edad.HeaderText = "Edad";
            edad.Name = "edad";
            edad.ReadOnly = true;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(201, 526);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(75, 23);
            btnRecargar.TabIndex = 2;
            btnRecargar.Text = "RECARGAR";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(282, 526);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "EXPORTAR";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 561);
            Controls.Add(btnExportar);
            Controls.Add(btnRecargar);
            Controls.Add(dgvPersonas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "CRUD persona";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cRUDPersonaToolStripMenuItem;
        private ToolStripMenuItem insertarPersonaToolStripMenuItem;
        private ToolStripMenuItem actualizarPersonaToolStripMenuItem;
        private ToolStripMenuItem eliminarPersonaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private DataGridView dgvPersonas;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn edad;
        private Button btnRecargar;
        private Button btnExportar;
    }
}