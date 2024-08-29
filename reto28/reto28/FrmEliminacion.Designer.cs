namespace reto28
{
    partial class FrmEliminacion
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
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnEliminar = new Button();
            btnVolver = new Button();
            lblEliminacion = new Label();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(90, 47);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(282, 23);
            txtCodigo.TabIndex = 23;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 50);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 22;
            lblCodigo.Text = "Código";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(202, 328);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(89, 23);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(297, 328);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 20;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblEliminacion
            // 
            lblEliminacion.AutoSize = true;
            lblEliminacion.Location = new Point(100, 10);
            lblEliminacion.Name = "lblEliminacion";
            lblEliminacion.Size = new Size(160, 15);
            lblEliminacion.TabIndex = 19;
            lblEliminacion.Text = "ELIMINACIÓN DE PERSONAS";
            // 
            // FrmEliminacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Controls.Add(lblEliminacion);
            Name = "FrmEliminacion";
            Text = "Eliminación de personas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label lblCodigo;
        private Button btnEliminar;
        private Button btnVolver;
        private Label lblEliminacion;
    }
}