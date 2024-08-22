namespace reto20
{
    partial class FrmActualizacionLibro
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
            btnHallarSignatura = new Button();
            btnActualizarLibro = new Button();
            btnVolver = new Button();
            lblAutor = new Label();
            lblTitulo = new Label();
            txtAutor = new TextBox();
            txtTitulo = new TextBox();
            txtSignatura = new TextBox();
            lblSignatura = new Label();
            lblActualizacionLibro = new Label();
            btnCargarLibro = new Button();
            rbTitulo = new RadioButton();
            lblActualizar = new Label();
            rbAutor = new RadioButton();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // btnHallarSignatura
            // 
            btnHallarSignatura.Location = new Point(135, 307);
            btnHallarSignatura.Name = "btnHallarSignatura";
            btnHallarSignatura.Size = new Size(75, 43);
            btnHallarSignatura.TabIndex = 19;
            btnHallarSignatura.Text = "Hallar signatura";
            btnHallarSignatura.UseVisualStyleBackColor = true;
            btnHallarSignatura.Click += btnHallarSignatura_Click;
            // 
            // btnActualizarLibro
            // 
            btnActualizarLibro.Location = new Point(216, 307);
            btnActualizarLibro.Name = "btnActualizarLibro";
            btnActualizarLibro.Size = new Size(75, 43);
            btnActualizarLibro.TabIndex = 18;
            btnActualizarLibro.Text = "Actualizar libro";
            btnActualizarLibro.UseVisualStyleBackColor = true;
            btnActualizarLibro.Click += btnActualizarLibro_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(297, 307);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 43);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(12, 119);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 16;
            lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 90);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Título";
            // 
            // txtAutor
            // 
            txtAutor.Enabled = false;
            txtAutor.Location = new Point(75, 116);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(297, 23);
            txtAutor.TabIndex = 14;
            // 
            // txtTitulo
            // 
            txtTitulo.Enabled = false;
            txtTitulo.Location = new Point(75, 87);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(297, 23);
            txtTitulo.TabIndex = 13;
            // 
            // txtSignatura
            // 
            txtSignatura.Location = new Point(75, 58);
            txtSignatura.Name = "txtSignatura";
            txtSignatura.Size = new Size(297, 23);
            txtSignatura.TabIndex = 12;
            // 
            // lblSignatura
            // 
            lblSignatura.AutoSize = true;
            lblSignatura.Location = new Point(12, 61);
            lblSignatura.Name = "lblSignatura";
            lblSignatura.Size = new Size(57, 15);
            lblSignatura.TabIndex = 11;
            lblSignatura.Text = "Signatura";
            // 
            // lblActualizacionLibro
            // 
            lblActualizacionLibro.AutoSize = true;
            lblActualizacionLibro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblActualizacionLibro.Location = new Point(31, 9);
            lblActualizacionLibro.Name = "lblActualizacionLibro";
            lblActualizacionLibro.Size = new Size(324, 21);
            lblActualizacionLibro.TabIndex = 10;
            lblActualizacionLibro.Text = "FORMULARIO DE ACTUALIZACIÓN DE LIBRO";
            // 
            // btnCargarLibro
            // 
            btnCargarLibro.Location = new Point(54, 307);
            btnCargarLibro.Name = "btnCargarLibro";
            btnCargarLibro.Size = new Size(75, 43);
            btnCargarLibro.TabIndex = 24;
            btnCargarLibro.Text = "Cargar libro";
            btnCargarLibro.UseVisualStyleBackColor = true;
            btnCargarLibro.Click += btnCargarLibro_Click;
            // 
            // rbTitulo
            // 
            rbTitulo.AutoSize = true;
            rbTitulo.Location = new Point(12, 181);
            rbTitulo.Name = "rbTitulo";
            rbTitulo.Size = new Size(55, 19);
            rbTitulo.TabIndex = 20;
            rbTitulo.TabStop = true;
            rbTitulo.Text = "Título";
            rbTitulo.UseVisualStyleBackColor = true;
            // 
            // lblActualizar
            // 
            lblActualizar.AutoSize = true;
            lblActualizar.Location = new Point(11, 163);
            lblActualizar.Name = "lblActualizar";
            lblActualizar.Size = new Size(99, 15);
            lblActualizar.TabIndex = 21;
            lblActualizar.Text = "Actualizar campo";
            // 
            // rbAutor
            // 
            rbAutor.AutoSize = true;
            rbAutor.Location = new Point(73, 181);
            rbAutor.Name = "rbAutor";
            rbAutor.Size = new Size(55, 19);
            rbAutor.TabIndex = 22;
            rbAutor.TabStop = true;
            rbAutor.Text = "Autor";
            rbAutor.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(134, 179);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 23;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FrmActualizacionLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(btnCargarLibro);
            Controls.Add(btnActualizar);
            Controls.Add(rbAutor);
            Controls.Add(lblActualizar);
            Controls.Add(rbTitulo);
            Controls.Add(btnHallarSignatura);
            Controls.Add(btnActualizarLibro);
            Controls.Add(btnVolver);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(txtSignatura);
            Controls.Add(lblSignatura);
            Controls.Add(lblActualizacionLibro);
            Name = "FrmActualizacionLibro";
            Text = "Formulario de actualización de libro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHallarSignatura;
        private Button btnActualizarLibro;
        private Button btnVolver;
        private Label lblAutor;
        private Label lblTitulo;
        private TextBox txtAutor;
        private TextBox txtTitulo;
        private TextBox txtSignatura;
        private Label lblSignatura;
        private Label lblActualizacionLibro;
        private Button btnCargarLibro;
        private RadioButton rbTitulo;
        private Label lblActualizar;
        private RadioButton rbAutor;
        private Button btnActualizar;
    }
}