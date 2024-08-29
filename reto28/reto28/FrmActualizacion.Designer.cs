namespace reto28
{
    partial class FrmActualizacion
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
            btnActualizar = new Button();
            btnVolver = new Button();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblActualizacion = new Label();
            btnCargar = new Button();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(202, 327);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(89, 23);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(297, 327);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(90, 104);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(282, 23);
            txtEdad.TabIndex = 13;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(12, 107);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 12;
            lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(90, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(282, 23);
            txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 78);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // lblActualizacion
            // 
            lblActualizacion.AutoSize = true;
            lblActualizacion.Location = new Point(100, 9);
            lblActualizacion.Name = "lblActualizacion";
            lblActualizacion.Size = new Size(176, 15);
            lblActualizacion.TabIndex = 9;
            lblActualizacion.Text = "ACTUALIZACIÓN DE PERSONAS";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(121, 327);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 16;
            btnCargar.Text = "CARGAR";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(90, 46);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(282, 23);
            txtCodigo.TabIndex = 18;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 49);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 17;
            lblCodigo.Text = "Código";
            // 
            // FrmActualizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnCargar);
            Controls.Add(btnActualizar);
            Controls.Add(btnVolver);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblActualizacion);
            Name = "FrmActualizacion";
            Text = "Actualización de personas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private Button btnVolver;
        private TextBox txtEdad;
        private Label lblEdad;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblActualizacion;
        private Button btnCargar;
        private TextBox txtCodigo;
        private Label lblCodigo;
    }
}