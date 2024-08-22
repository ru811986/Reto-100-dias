namespace reto20
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
            librosToolStripMenuItem = new ToolStripMenuItem();
            insertarLibroToolStripMenuItem = new ToolStripMenuItem();
            actualizarLibroToolStripMenuItem = new ToolStripMenuItem();
            eliminarLibroToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            verLibrosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { librosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertarLibroToolStripMenuItem, actualizarLibroToolStripMenuItem, eliminarLibroToolStripMenuItem, toolStripMenuItem1, verLibrosToolStripMenuItem });
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(51, 20);
            librosToolStripMenuItem.Text = "Libros";
            // 
            // insertarLibroToolStripMenuItem
            // 
            insertarLibroToolStripMenuItem.Name = "insertarLibroToolStripMenuItem";
            insertarLibroToolStripMenuItem.Size = new Size(180, 22);
            insertarLibroToolStripMenuItem.Text = "Insertar libro";
            insertarLibroToolStripMenuItem.Click += insertarLibroToolStripMenuItem_Click;
            // 
            // actualizarLibroToolStripMenuItem
            // 
            actualizarLibroToolStripMenuItem.Name = "actualizarLibroToolStripMenuItem";
            actualizarLibroToolStripMenuItem.Size = new Size(180, 22);
            actualizarLibroToolStripMenuItem.Text = "Actualizar libro";
            actualizarLibroToolStripMenuItem.Click += actualizarLibroToolStripMenuItem_Click;
            // 
            // eliminarLibroToolStripMenuItem
            // 
            eliminarLibroToolStripMenuItem.Name = "eliminarLibroToolStripMenuItem";
            eliminarLibroToolStripMenuItem.Size = new Size(180, 22);
            eliminarLibroToolStripMenuItem.Text = "Eliminar libro";
            eliminarLibroToolStripMenuItem.Click += eliminarLibroToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // verLibrosToolStripMenuItem
            // 
            verLibrosToolStripMenuItem.Name = "verLibrosToolStripMenuItem";
            verLibrosToolStripMenuItem.Size = new Size(180, 22);
            verLibrosToolStripMenuItem.Text = "Ver libros";
            verLibrosToolStripMenuItem.Click += verLibrosToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Aplicación 5";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem insertarLibroToolStripMenuItem;
        private ToolStripMenuItem actualizarLibroToolStripMenuItem;
        private ToolStripMenuItem eliminarLibroToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem verLibrosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}