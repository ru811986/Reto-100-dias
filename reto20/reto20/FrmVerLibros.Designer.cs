namespace reto20
{
    partial class FrmVerLibros
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
            label1 = new Label();
            dgvLibros = new DataGridView();
            signatura = new DataGridViewTextBoxColumn();
            titulo = new DataGridViewTextBoxColumn();
            autor = new DataGridViewTextBoxColumn();
            btnRecargar = new Button();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(97, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 28);
            label1.TabIndex = 0;
            label1.Text = "LISTADO DE LIBROS";
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { signatura, titulo, autor });
            dgvLibros.Location = new Point(12, 52);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowTemplate.Height = 25;
            dgvLibros.Size = new Size(360, 251);
            dgvLibros.TabIndex = 1;
            // 
            // signatura
            // 
            signatura.HeaderText = "Signatura";
            signatura.Name = "signatura";
            signatura.ReadOnly = true;
            // 
            // titulo
            // 
            titulo.HeaderText = "Título";
            titulo.Name = "titulo";
            titulo.ReadOnly = true;
            // 
            // autor
            // 
            autor.HeaderText = "Autor";
            autor.Name = "autor";
            autor.ReadOnly = true;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(216, 326);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(75, 23);
            btnRecargar.TabIndex = 2;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(297, 326);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // FrmVerLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(btnExportar);
            Controls.Add(btnRecargar);
            Controls.Add(dgvLibros);
            Controls.Add(label1);
            Name = "FrmVerLibros";
            Text = "FrmVerLibros";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvLibros;
        private DataGridViewTextBoxColumn signatura;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn autor;
        private Button btnRecargar;
        private Button btnExportar;
    }
}