namespace reto14
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
            lblOperando1 = new Label();
            txtOperando1 = new TextBox();
            txtOperando2 = new TextBox();
            lblOperando2 = new Label();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnBorrar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblOperando1
            // 
            lblOperando1.AutoSize = true;
            lblOperando1.Location = new Point(12, 9);
            lblOperando1.Name = "lblOperando1";
            lblOperando1.Size = new Size(69, 15);
            lblOperando1.TabIndex = 0;
            lblOperando1.Text = "Operando 1";
            // 
            // txtOperando1
            // 
            txtOperando1.Location = new Point(87, 6);
            txtOperando1.Name = "txtOperando1";
            txtOperando1.Size = new Size(267, 23);
            txtOperando1.TabIndex = 1;
            // 
            // txtOperando2
            // 
            txtOperando2.Location = new Point(87, 35);
            txtOperando2.Name = "txtOperando2";
            txtOperando2.Size = new Size(267, 23);
            txtOperando2.TabIndex = 3;
            // 
            // lblOperando2
            // 
            lblOperando2.AutoSize = true;
            lblOperando2.Location = new Point(12, 38);
            lblOperando2.Name = "lblOperando2";
            lblOperando2.Size = new Size(69, 15);
            lblOperando2.TabIndex = 2;
            lblOperando2.Text = "Operando 2";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(12, 64);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 4;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(93, 64);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(75, 23);
            btnRestar.TabIndex = 5;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(198, 64);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 6;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(279, 64);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(12, 93);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(342, 23);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 119);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 160);
            Controls.Add(lblResultado);
            Controls.Add(btnBorrar);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtOperando2);
            Controls.Add(lblOperando2);
            Controls.Add(txtOperando1);
            Controls.Add(lblOperando1);
            Name = "Form1";
            Text = "Aplicación 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOperando1;
        private TextBox txtOperando1;
        private TextBox txtOperando2;
        private Label lblOperando2;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnBorrar;
        private Label lblResultado;
    }
}