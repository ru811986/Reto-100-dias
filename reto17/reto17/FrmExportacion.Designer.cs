namespace reto17.Archivos_CSV
{
    partial class FrmExportacion
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
            lblExportacion = new Label();
            lblRutaFichero = new Label();
            txtRutaFichero = new TextBox();
            btnVolver = new Button();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // lblExportacion
            // 
            lblExportacion.AutoSize = true;
            lblExportacion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblExportacion.Location = new Point(12, 9);
            lblExportacion.Name = "lblExportacion";
            lblExportacion.Size = new Size(357, 32);
            lblExportacion.TabIndex = 1;
            lblExportacion.Text = "FORMULARIO DE EXPORTACIÓN";
            // 
            // lblRutaFichero
            // 
            lblRutaFichero.AutoSize = true;
            lblRutaFichero.Location = new Point(12, 69);
            lblRutaFichero.Name = "lblRutaFichero";
            lblRutaFichero.Size = new Size(71, 15);
            lblRutaFichero.TabIndex = 2;
            lblRutaFichero.Text = "Ruta fichero";
            // 
            // txtRutaFichero
            // 
            txtRutaFichero.Location = new Point(89, 66);
            txtRutaFichero.Name = "txtRutaFichero";
            txtRutaFichero.Size = new Size(283, 23);
            txtRutaFichero.TabIndex = 3;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(297, 326);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(216, 326);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 5;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnImportar_Click;
            // 
            // FrmExportacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(btnExportar);
            Controls.Add(btnVolver);
            Controls.Add(txtRutaFichero);
            Controls.Add(lblRutaFichero);
            Controls.Add(lblExportacion);
            Name = "FrmExportacion";
            Text = "Formulario de exportación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExportacion;
        private Label lblRutaFichero;
        private TextBox txtRutaFichero;
        private Button btnVolver;
        private Button btnExportar;
    }
}