namespace reto20
{
    partial class FrmInsercionLibro
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
            lblInsercionLibro = new Label();
            lblSignatura = new Label();
            txtSignatura = new TextBox();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            lblTitulo = new Label();
            lblAutor = new Label();
            btnVolver = new Button();
            btnInsertarLibro = new Button();
            btnHallarSignatura = new Button();
            SuspendLayout();
            // 
            // lblInsercionLibro
            // 
            lblInsercionLibro.AutoSize = true;
            lblInsercionLibro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsercionLibro.Location = new Point(12, 9);
            lblInsercionLibro.Name = "lblInsercionLibro";
            lblInsercionLibro.Size = new Size(356, 28);
            lblInsercionLibro.TabIndex = 0;
            lblInsercionLibro.Text = "FORMULARIO DE INSERCIÓN DE LIBRO";
            // 
            // lblSignatura
            // 
            lblSignatura.AutoSize = true;
            lblSignatura.Location = new Point(12, 60);
            lblSignatura.Name = "lblSignatura";
            lblSignatura.Size = new Size(57, 15);
            lblSignatura.TabIndex = 1;
            lblSignatura.Text = "Signatura";
            // 
            // txtSignatura
            // 
            txtSignatura.Enabled = false;
            txtSignatura.Location = new Point(75, 57);
            txtSignatura.Name = "txtSignatura";
            txtSignatura.Size = new Size(297, 23);
            txtSignatura.TabIndex = 2;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(75, 86);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(297, 23);
            txtTitulo.TabIndex = 3;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(75, 115);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(297, 23);
            txtAutor.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 89);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(12, 118);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 6;
            lblAutor.Text = "Autor";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(297, 306);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 43);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnInsertarLibro
            // 
            btnInsertarLibro.Location = new Point(216, 306);
            btnInsertarLibro.Name = "btnInsertarLibro";
            btnInsertarLibro.Size = new Size(75, 43);
            btnInsertarLibro.TabIndex = 8;
            btnInsertarLibro.Text = "Insertar libro";
            btnInsertarLibro.UseVisualStyleBackColor = true;
            btnInsertarLibro.Click += btnInsertarLibro_Click;
            // 
            // btnHallarSignatura
            // 
            btnHallarSignatura.Location = new Point(135, 306);
            btnHallarSignatura.Name = "btnHallarSignatura";
            btnHallarSignatura.Size = new Size(75, 43);
            btnHallarSignatura.TabIndex = 9;
            btnHallarSignatura.Text = "Hallar signatura";
            btnHallarSignatura.UseVisualStyleBackColor = true;
            btnHallarSignatura.Click += btnHallarSignatura_Click;
            // 
            // FrmInsercionLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(btnHallarSignatura);
            Controls.Add(btnInsertarLibro);
            Controls.Add(btnVolver);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(txtSignatura);
            Controls.Add(lblSignatura);
            Controls.Add(lblInsercionLibro);
            Name = "FrmInsercionLibro";
            Text = "Formulario de inserción de libro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInsercionLibro;
        private Label lblSignatura;
        private TextBox txtSignatura;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private Label lblTitulo;
        private Label lblAutor;
        private Button btnVolver;
        private Button btnInsertarLibro;
        private Button btnHallarSignatura;
    }
}