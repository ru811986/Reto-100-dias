namespace reto20
{
    partial class FrmExportarLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblExportarLibros = new Label();
            lblNombreRuta = new Label();
            txtNombreRuta = new TextBox();
            btnVolver = new Button();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // lblExportarLibros
            // 
            lblExportarLibros.AutoSize = true;
            lblExportarLibros.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblExportarLibros.Location = new Point(105, 9);
            lblExportarLibros.Name = "lblExportarLibros";
            lblExportarLibros.Size = new Size(173, 28);
            lblExportarLibros.TabIndex = 0;
            lblExportarLibros.Text = "EXPORTAR LIBROS";
            // 
            // lblNombreRuta
            // 
            lblNombreRuta.AutoSize = true;
            lblNombreRuta.Location = new Point(12, 60);
            lblNombreRuta.Name = "lblNombreRuta";
            lblNombreRuta.Size = new Size(75, 15);
            lblNombreRuta.TabIndex = 1;
            lblNombreRuta.Text = "Nombre ruta";
            // 
            // txtNombreRuta
            // 
            txtNombreRuta.Location = new Point(93, 57);
            txtNombreRuta.Name = "txtNombreRuta";
            txtNombreRuta.Size = new Size(279, 23);
            txtNombreRuta.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(297, 326);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(216, 326);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 4;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // FrmExportar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(btnExportar);
            Controls.Add(btnVolver);
            Controls.Add(txtNombreRuta);
            Controls.Add(lblNombreRuta);
            Controls.Add(lblExportarLibros);
            Name = "FrmExportar";
            Text = "Formulario para exportar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExportarLibros;
        private Label lblNombreRuta;
        private TextBox txtNombreRuta;
        private Button btnVolver;
        private Button btnExportar;
    }
}