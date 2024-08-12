namespace reto17
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
            lblInsercion = new Label();
            lblNombreTarea = new Label();
            txtNombreTarea = new TextBox();
            lblDescripcionTarea = new Label();
            txtDescripcionTarea = new TextBox();
            cbTipoTarea = new ComboBox();
            lblTipoTarea = new Label();
            lblFechaTarea = new Label();
            btnVolver = new Button();
            btnInsertar = new Button();
            dtpFechaTarea = new DateTimePicker();
            lblId = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // lblInsercion
            // 
            lblInsercion.AutoSize = true;
            lblInsercion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsercion.Location = new Point(29, 9);
            lblInsercion.Name = "lblInsercion";
            lblInsercion.Size = new Size(324, 32);
            lblInsercion.TabIndex = 0;
            lblInsercion.Text = "FORMULARIO DE INSERCIÓN";
            // 
            // lblNombreTarea
            // 
            lblNombreTarea.AutoSize = true;
            lblNombreTarea.Location = new Point(12, 104);
            lblNombreTarea.Name = "lblNombreTarea";
            lblNombreTarea.Size = new Size(80, 15);
            lblNombreTarea.TabIndex = 1;
            lblNombreTarea.Text = "Nombre tarea";
            // 
            // txtNombreTarea
            // 
            txtNombreTarea.Location = new Point(116, 101);
            txtNombreTarea.Name = "txtNombreTarea";
            txtNombreTarea.Size = new Size(256, 23);
            txtNombreTarea.TabIndex = 2;
            // 
            // lblDescripcionTarea
            // 
            lblDescripcionTarea.AutoSize = true;
            lblDescripcionTarea.Location = new Point(12, 133);
            lblDescripcionTarea.Name = "lblDescripcionTarea";
            lblDescripcionTarea.Size = new Size(98, 15);
            lblDescripcionTarea.TabIndex = 3;
            lblDescripcionTarea.Text = "Descripción tarea";
            // 
            // txtDescripcionTarea
            // 
            txtDescripcionTarea.Location = new Point(116, 130);
            txtDescripcionTarea.Multiline = true;
            txtDescripcionTarea.Name = "txtDescripcionTarea";
            txtDescripcionTarea.Size = new Size(256, 94);
            txtDescripcionTarea.TabIndex = 3;
            // 
            // cbTipoTarea
            // 
            cbTipoTarea.FormattingEnabled = true;
            cbTipoTarea.Items.AddRange(new object[] { "Limpieza", "Recogida", "Otro" });
            cbTipoTarea.Location = new Point(116, 230);
            cbTipoTarea.Name = "cbTipoTarea";
            cbTipoTarea.Size = new Size(256, 23);
            cbTipoTarea.TabIndex = 4;
            // 
            // lblTipoTarea
            // 
            lblTipoTarea.AutoSize = true;
            lblTipoTarea.Location = new Point(12, 233);
            lblTipoTarea.Name = "lblTipoTarea";
            lblTipoTarea.Size = new Size(59, 15);
            lblTipoTarea.TabIndex = 6;
            lblTipoTarea.Text = "Tipo tarea";
            // 
            // lblFechaTarea
            // 
            lblFechaTarea.AutoSize = true;
            lblFechaTarea.Location = new Point(12, 265);
            lblFechaTarea.Name = "lblFechaTarea";
            lblFechaTarea.Size = new Size(67, 15);
            lblFechaTarea.TabIndex = 7;
            lblFechaTarea.Text = "Fecha tarea";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(297, 326);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(216, 326);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // dtpFechaTarea
            // 
            dtpFechaTarea.Location = new Point(116, 259);
            dtpFechaTarea.Name = "dtpFechaTarea";
            dtpFechaTarea.Size = new Size(256, 23);
            dtpFechaTarea.TabIndex = 5;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 75);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 12;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(116, 72);
            txtId.Name = "txtId";
            txtId.Size = new Size(256, 23);
            txtId.TabIndex = 1;
            // 
            // FrmInsercion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(dtpFechaTarea);
            Controls.Add(btnInsertar);
            Controls.Add(btnVolver);
            Controls.Add(lblFechaTarea);
            Controls.Add(lblTipoTarea);
            Controls.Add(cbTipoTarea);
            Controls.Add(txtDescripcionTarea);
            Controls.Add(lblDescripcionTarea);
            Controls.Add(txtNombreTarea);
            Controls.Add(lblNombreTarea);
            Controls.Add(lblInsercion);
            Name = "FrmInsercion";
            Text = "Formulario de inserción";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInsercion;
        private Label lblNombreTarea;
        private TextBox txtNombreTarea;
        private Label lblDescripcionTarea;
        private TextBox txtDescripcionTarea;
        private ComboBox cbTipoTarea;
        private Label lblTipoTarea;
        private Label lblFechaTarea;
        private Button btnVolver;
        private Button btnInsertar;
        private DateTimePicker dtpFechaTarea;
        private Label lblId;
        private TextBox txtId;
    }
}