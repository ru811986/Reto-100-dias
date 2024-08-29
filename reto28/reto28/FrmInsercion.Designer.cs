namespace reto28
{
    partial class FrmInsercion
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtEdad = new TextBox();
            lblEdad = new Label();
            btnVolver = new Button();
            btnInsertar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "INSERCIÓN DE PERSONAS";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(282, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(90, 73);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(282, 23);
            txtEdad.TabIndex = 6;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(12, 76);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Edad";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(297, 326);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(216, 326);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // FrmInsercion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(btnInsertar);
            Controls.Add(btnVolver);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "FrmInsercion";
            Text = "Inserción de personas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtEdad;
        private Label lblEdad;
        private Button btnVolver;
        private Button btnInsertar;
    }
}