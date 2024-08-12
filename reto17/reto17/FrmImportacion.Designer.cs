namespace reto17
{
    partial class FrmImportacion
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
            btnImportar = new Button();
            btnVolver = new Button();
            txtRutaFichero = new TextBox();
            lblRutaFichero = new Label();
            lblImportacion = new Label();
            SuspendLayout();
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(216, 327);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(75, 23);
            btnImportar.TabIndex = 10;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(297, 327);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtRutaFichero
            // 
            txtRutaFichero.Location = new Point(89, 67);
            txtRutaFichero.Name = "txtRutaFichero";
            txtRutaFichero.Size = new Size(283, 23);
            txtRutaFichero.TabIndex = 8;
            // 
            // lblRutaFichero
            // 
            lblRutaFichero.AutoSize = true;
            lblRutaFichero.Location = new Point(12, 70);
            lblRutaFichero.Name = "lblRutaFichero";
            lblRutaFichero.Size = new Size(71, 15);
            lblRutaFichero.TabIndex = 7;
            lblRutaFichero.Text = "Ruta fichero";
            // 
            // lblImportacion
            // 
            lblImportacion.AutoSize = true;
            lblImportacion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblImportacion.Location = new Point(12, 10);
            lblImportacion.Name = "lblImportacion";
            lblImportacion.Size = new Size(359, 32);
            lblImportacion.TabIndex = 6;
            lblImportacion.Text = "FORMULARIO DE IMPORTACIÓN";
            // 
            // FrmImportacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(btnImportar);
            Controls.Add(btnVolver);
            Controls.Add(txtRutaFichero);
            Controls.Add(lblRutaFichero);
            Controls.Add(lblImportacion);
            Name = "FrmImportacion";
            Text = "FrmImportacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImportar;
        private Button btnVolver;
        private TextBox txtRutaFichero;
        private Label lblRutaFichero;
        private Label lblImportacion;
    }
}