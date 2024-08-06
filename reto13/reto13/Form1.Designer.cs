namespace reto13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnMostrarMensaje = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(278, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnMostrarMensaje
            // 
            btnMostrarMensaje.Location = new Point(12, 35);
            btnMostrarMensaje.Name = "btnMostrarMensaje";
            btnMostrarMensaje.Size = new Size(340, 23);
            btnMostrarMensaje.TabIndex = 2;
            btnMostrarMensaje.Text = "Mostrar mensaje";
            btnMostrarMensaje.UseVisualStyleBackColor = true;
            btnMostrarMensaje.Click += btnMostrarMensaje_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(12, 101);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 125);
            Controls.Add(lblMensaje);
            Controls.Add(btnMostrarMensaje);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Bienvenida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnMostrarMensaje;
        private Label lblMensaje;
    }
}