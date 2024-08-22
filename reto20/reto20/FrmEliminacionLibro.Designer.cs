namespace reto20
{
    partial class FrmEliminacionLibro
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
            btnEliminarLibro = new Button();
            btnVolver = new Button();
            lblInsercionLibro = new Label();
            lblAutor = new Label();
            lblTitulo = new Label();
            txtAutor = new TextBox();
            txtTitulo = new TextBox();
            SuspendLayout();
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Location = new Point(216, 307);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(75, 43);
            btnEliminarLibro.TabIndex = 13;
            btnEliminarLibro.Text = "Eliminar libro";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(297, 307);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 43);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblInsercionLibro
            // 
            lblInsercionLibro.AutoSize = true;
            lblInsercionLibro.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsercionLibro.Location = new Point(12, 10);
            lblInsercionLibro.Name = "lblInsercionLibro";
            lblInsercionLibro.Size = new Size(361, 25);
            lblInsercionLibro.TabIndex = 9;
            lblInsercionLibro.Text = "FORMULARIO DE ELIMINACIÓN DE LIBRO";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(12, 83);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 17;
            lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 54);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Título";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(75, 80);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(297, 23);
            txtAutor.TabIndex = 15;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(75, 51);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(297, 23);
            txtTitulo.TabIndex = 14;
            // 
            // FrmEliminacionLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(btnEliminarLibro);
            Controls.Add(btnVolver);
            Controls.Add(lblInsercionLibro);
            Name = "FrmEliminacionLibro";
            Text = "Formulario de eliminación de libro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarLibro;
        private Button btnVolver;
        private Label lblInsercionLibro;
        private Label lblAutor;
        private Label lblTitulo;
        private TextBox txtAutor;
        private TextBox txtTitulo;
    }
}