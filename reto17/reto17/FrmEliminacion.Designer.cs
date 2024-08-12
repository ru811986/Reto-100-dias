namespace reto17
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
            txtId = new TextBox();
            lblId = new Label();
            btnEliminar = new Button();
            btnVolver = new Button();
            lblInsercion = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(116, 73);
            txtId.Name = "txtId";
            txtId.Size = new Size(256, 23);
            txtId.TabIndex = 14;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 76);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 17;
            lblId.Text = "ID";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(216, 327);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(297, 327);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblInsercion
            // 
            lblInsercion.AutoSize = true;
            lblInsercion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsercion.Location = new Point(12, 9);
            lblInsercion.Name = "lblInsercion";
            lblInsercion.Size = new Size(351, 32);
            lblInsercion.TabIndex = 13;
            lblInsercion.Text = "FORMULARIO DE ELIMINACIÓN";
            // 
            // FrmEliminacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Controls.Add(lblInsercion);
            Name = "FrmEliminacion";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private Button btnEliminar;
        private Button btnVolver;
        private Label lblInsercion;
    }
}