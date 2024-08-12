namespace reto17
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
            lblInsercion = new Label();
            txtId = new TextBox();
            lblId = new Label();
            dtpFechaTarea = new DateTimePicker();
            btnActualizar = new Button();
            btnVolver = new Button();
            lblFechaTarea = new Label();
            lblTipoTarea = new Label();
            cbTipoTarea = new ComboBox();
            txtDescripcionTarea = new TextBox();
            lblDescripcionTarea = new Label();
            txtNombreTarea = new TextBox();
            lblNombreTarea = new Label();
            btnCargar = new Button();
            SuspendLayout();
            // 
            // lblInsercion
            // 
            lblInsercion.AutoSize = true;
            lblInsercion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsercion.Location = new Point(12, 9);
            lblInsercion.Name = "lblInsercion";
            lblInsercion.Size = new Size(380, 32);
            lblInsercion.TabIndex = 1;
            lblInsercion.Text = "FORMULARIO DE ACTUALIZACIÓN";
            // 
            // txtId
            // 
            txtId.Location = new Point(133, 72);
            txtId.Name = "txtId";
            txtId.Size = new Size(256, 23);
            txtId.TabIndex = 13;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 72);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 24;
            lblId.Text = "ID";
            // 
            // dtpFechaTarea
            // 
            dtpFechaTarea.Enabled = false;
            dtpFechaTarea.Location = new Point(133, 259);
            dtpFechaTarea.Name = "dtpFechaTarea";
            dtpFechaTarea.Size = new Size(256, 23);
            dtpFechaTarea.TabIndex = 19;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(233, 326);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(314, 326);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 22;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblFechaTarea
            // 
            lblFechaTarea.AutoSize = true;
            lblFechaTarea.Location = new Point(12, 262);
            lblFechaTarea.Name = "lblFechaTarea";
            lblFechaTarea.Size = new Size(67, 15);
            lblFechaTarea.TabIndex = 23;
            lblFechaTarea.Text = "Fecha tarea";
            // 
            // lblTipoTarea
            // 
            lblTipoTarea.AutoSize = true;
            lblTipoTarea.Location = new Point(12, 230);
            lblTipoTarea.Name = "lblTipoTarea";
            lblTipoTarea.Size = new Size(59, 15);
            lblTipoTarea.TabIndex = 21;
            lblTipoTarea.Text = "Tipo tarea";
            // 
            // cbTipoTarea
            // 
            cbTipoTarea.Enabled = false;
            cbTipoTarea.FormattingEnabled = true;
            cbTipoTarea.Items.AddRange(new object[] { "Limpieza", "Recogida", "Otro" });
            cbTipoTarea.Location = new Point(133, 230);
            cbTipoTarea.Name = "cbTipoTarea";
            cbTipoTarea.Size = new Size(256, 23);
            cbTipoTarea.TabIndex = 18;
            // 
            // txtDescripcionTarea
            // 
            txtDescripcionTarea.Enabled = false;
            txtDescripcionTarea.Location = new Point(133, 130);
            txtDescripcionTarea.Multiline = true;
            txtDescripcionTarea.Name = "txtDescripcionTarea";
            txtDescripcionTarea.Size = new Size(256, 94);
            txtDescripcionTarea.TabIndex = 16;
            // 
            // lblDescripcionTarea
            // 
            lblDescripcionTarea.AutoSize = true;
            lblDescripcionTarea.Location = new Point(12, 130);
            lblDescripcionTarea.Name = "lblDescripcionTarea";
            lblDescripcionTarea.Size = new Size(98, 15);
            lblDescripcionTarea.TabIndex = 17;
            lblDescripcionTarea.Text = "Descripción tarea";
            // 
            // txtNombreTarea
            // 
            txtNombreTarea.Enabled = false;
            txtNombreTarea.Location = new Point(133, 101);
            txtNombreTarea.Name = "txtNombreTarea";
            txtNombreTarea.Size = new Size(256, 23);
            txtNombreTarea.TabIndex = 15;
            // 
            // lblNombreTarea
            // 
            lblNombreTarea.AutoSize = true;
            lblNombreTarea.Location = new Point(12, 101);
            lblNombreTarea.Name = "lblNombreTarea";
            lblNombreTarea.Size = new Size(80, 15);
            lblNombreTarea.TabIndex = 14;
            lblNombreTarea.Text = "Nombre tarea";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(152, 326);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 25;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // FrmActualizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 361);
            Controls.Add(btnCargar);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(dtpFechaTarea);
            Controls.Add(btnActualizar);
            Controls.Add(btnVolver);
            Controls.Add(lblFechaTarea);
            Controls.Add(lblTipoTarea);
            Controls.Add(cbTipoTarea);
            Controls.Add(txtDescripcionTarea);
            Controls.Add(lblDescripcionTarea);
            Controls.Add(txtNombreTarea);
            Controls.Add(lblNombreTarea);
            Controls.Add(lblInsercion);
            Name = "FrmActualizacion";
            Text = "FrmActualizacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInsercion;
        private TextBox txtId;
        private Label lblId;
        private DateTimePicker dtpFechaTarea;
        private Button btnActualizar;
        private Button btnVolver;
        private Label lblFechaTarea;
        private Label lblTipoTarea;
        private ComboBox cbTipoTarea;
        private TextBox txtDescripcionTarea;
        private Label lblDescripcionTarea;
        private TextBox txtNombreTarea;
        private Label lblNombreTarea;
        private Button btnCargar;
    }
}