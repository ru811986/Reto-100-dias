namespace reto27
{
    partial class FrmTicketDePago
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
            txtTrabajador = new TextBox();
            txtSueldoBasico = new TextBox();
            txtHorasExtras = new TextBox();
            txtPagoHorasExtras = new TextBox();
            lblTrabajador = new Label();
            lblSueldoBasico = new Label();
            lblHorasExtras = new Label();
            lblPagoHorasExtras = new Label();
            gbTurno = new GroupBox();
            rbNocturno = new RadioButton();
            rbDiurno = new RadioButton();
            gbDescuentos = new GroupBox();
            txtAfp = new TextBox();
            txtFonavi = new TextBox();
            txtRenta = new TextBox();
            cbAFP = new CheckBox();
            cbFonavi = new CheckBox();
            cbRenta = new CheckBox();
            lblSueldoNeto = new Label();
            txtSueldoNeto = new TextBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnAceptar = new Button();
            gbTurno.SuspendLayout();
            gbDescuentos.SuspendLayout();
            SuspendLayout();
            // 
            // txtTrabajador
            // 
            txtTrabajador.Location = new Point(135, 12);
            txtTrabajador.Name = "txtTrabajador";
            txtTrabajador.Size = new Size(237, 23);
            txtTrabajador.TabIndex = 0;
            // 
            // txtSueldoBasico
            // 
            txtSueldoBasico.Location = new Point(135, 41);
            txtSueldoBasico.Name = "txtSueldoBasico";
            txtSueldoBasico.Size = new Size(237, 23);
            txtSueldoBasico.TabIndex = 1;
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Location = new Point(135, 70);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(237, 23);
            txtHorasExtras.TabIndex = 2;
            // 
            // txtPagoHorasExtras
            // 
            txtPagoHorasExtras.Location = new Point(135, 99);
            txtPagoHorasExtras.Name = "txtPagoHorasExtras";
            txtPagoHorasExtras.ReadOnly = true;
            txtPagoHorasExtras.Size = new Size(237, 23);
            txtPagoHorasExtras.TabIndex = 3;
            // 
            // lblTrabajador
            // 
            lblTrabajador.AutoSize = true;
            lblTrabajador.Location = new Point(12, 15);
            lblTrabajador.Name = "lblTrabajador";
            lblTrabajador.Size = new Size(62, 15);
            lblTrabajador.TabIndex = 4;
            lblTrabajador.Text = "Trabajador";
            // 
            // lblSueldoBasico
            // 
            lblSueldoBasico.AutoSize = true;
            lblSueldoBasico.Location = new Point(12, 44);
            lblSueldoBasico.Name = "lblSueldoBasico";
            lblSueldoBasico.Size = new Size(97, 15);
            lblSueldoBasico.TabIndex = 5;
            lblSueldoBasico.Text = "Sueldo básico S/.";
            // 
            // lblHorasExtras
            // 
            lblHorasExtras.AutoSize = true;
            lblHorasExtras.Location = new Point(12, 73);
            lblHorasExtras.Name = "lblHorasExtras";
            lblHorasExtras.Size = new Size(72, 15);
            lblHorasExtras.TabIndex = 6;
            lblHorasExtras.Text = "Horas extras";
            // 
            // lblPagoHorasExtras
            // 
            lblPagoHorasExtras.AutoSize = true;
            lblPagoHorasExtras.Location = new Point(12, 102);
            lblPagoHorasExtras.Name = "lblPagoHorasExtras";
            lblPagoHorasExtras.Size = new Size(117, 15);
            lblPagoHorasExtras.TabIndex = 7;
            lblPagoHorasExtras.Text = "Pago horas extras S/.";
            // 
            // gbTurno
            // 
            gbTurno.Controls.Add(rbNocturno);
            gbTurno.Controls.Add(rbDiurno);
            gbTurno.Location = new Point(12, 128);
            gbTurno.Name = "gbTurno";
            gbTurno.Size = new Size(221, 55);
            gbTurno.TabIndex = 8;
            gbTurno.TabStop = false;
            gbTurno.Text = "Turno";
            // 
            // rbNocturno
            // 
            rbNocturno.AutoSize = true;
            rbNocturno.Location = new Point(73, 22);
            rbNocturno.Name = "rbNocturno";
            rbNocturno.Size = new Size(76, 19);
            rbNocturno.TabIndex = 1;
            rbNocturno.TabStop = true;
            rbNocturno.Text = "Nocturno";
            rbNocturno.UseVisualStyleBackColor = true;
            // 
            // rbDiurno
            // 
            rbDiurno.AutoSize = true;
            rbDiurno.Location = new Point(6, 22);
            rbDiurno.Name = "rbDiurno";
            rbDiurno.Size = new Size(61, 19);
            rbDiurno.TabIndex = 0;
            rbDiurno.TabStop = true;
            rbDiurno.Text = "Diurno";
            rbDiurno.UseVisualStyleBackColor = true;
            // 
            // gbDescuentos
            // 
            gbDescuentos.Controls.Add(txtAfp);
            gbDescuentos.Controls.Add(txtFonavi);
            gbDescuentos.Controls.Add(txtRenta);
            gbDescuentos.Controls.Add(cbAFP);
            gbDescuentos.Controls.Add(cbFonavi);
            gbDescuentos.Controls.Add(cbRenta);
            gbDescuentos.Location = new Point(12, 189);
            gbDescuentos.Name = "gbDescuentos";
            gbDescuentos.Size = new Size(221, 102);
            gbDescuentos.TabIndex = 9;
            gbDescuentos.TabStop = false;
            gbDescuentos.Text = "Descuentos";
            // 
            // txtAfp
            // 
            txtAfp.Location = new Point(73, 70);
            txtAfp.Name = "txtAfp";
            txtAfp.ReadOnly = true;
            txtAfp.Size = new Size(142, 23);
            txtAfp.TabIndex = 10;
            // 
            // txtFonavi
            // 
            txtFonavi.Location = new Point(73, 45);
            txtFonavi.Name = "txtFonavi";
            txtFonavi.ReadOnly = true;
            txtFonavi.Size = new Size(142, 23);
            txtFonavi.TabIndex = 4;
            // 
            // txtRenta
            // 
            txtRenta.Location = new Point(73, 20);
            txtRenta.Name = "txtRenta";
            txtRenta.ReadOnly = true;
            txtRenta.Size = new Size(142, 23);
            txtRenta.TabIndex = 3;
            // 
            // cbAFP
            // 
            cbAFP.AutoSize = true;
            cbAFP.Location = new Point(6, 72);
            cbAFP.Name = "cbAFP";
            cbAFP.Size = new Size(47, 19);
            cbAFP.TabIndex = 2;
            cbAFP.Text = "AFP";
            cbAFP.UseVisualStyleBackColor = true;
            // 
            // cbFonavi
            // 
            cbFonavi.AutoSize = true;
            cbFonavi.Location = new Point(6, 47);
            cbFonavi.Name = "cbFonavi";
            cbFonavi.Size = new Size(61, 19);
            cbFonavi.TabIndex = 1;
            cbFonavi.Text = "Fonavi";
            cbFonavi.UseVisualStyleBackColor = true;
            // 
            // cbRenta
            // 
            cbRenta.AutoSize = true;
            cbRenta.Location = new Point(6, 22);
            cbRenta.Name = "cbRenta";
            cbRenta.Size = new Size(56, 19);
            cbRenta.TabIndex = 0;
            cbRenta.Text = "Renta";
            cbRenta.UseVisualStyleBackColor = true;
            // 
            // lblSueldoNeto
            // 
            lblSueldoNeto.AutoSize = true;
            lblSueldoNeto.Location = new Point(12, 294);
            lblSueldoNeto.Name = "lblSueldoNeto";
            lblSueldoNeto.Size = new Size(87, 15);
            lblSueldoNeto.TabIndex = 10;
            lblSueldoNeto.Text = "Sueldo neto S/.";
            // 
            // txtSueldoNeto
            // 
            txtSueldoNeto.Location = new Point(105, 291);
            txtSueldoNeto.Name = "txtSueldoNeto";
            txtSueldoNeto.ReadOnly = true;
            txtSueldoNeto.Size = new Size(128, 23);
            txtSueldoNeto.TabIndex = 11;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(297, 290);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(297, 261);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(297, 232);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmTicketDePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 326);
            Controls.Add(btnAceptar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(txtSueldoNeto);
            Controls.Add(lblSueldoNeto);
            Controls.Add(gbDescuentos);
            Controls.Add(gbTurno);
            Controls.Add(lblPagoHorasExtras);
            Controls.Add(lblHorasExtras);
            Controls.Add(lblSueldoBasico);
            Controls.Add(lblTrabajador);
            Controls.Add(txtPagoHorasExtras);
            Controls.Add(txtHorasExtras);
            Controls.Add(txtSueldoBasico);
            Controls.Add(txtTrabajador);
            Name = "FrmTicketDePago";
            Text = "Ticket de pago";
            gbTurno.ResumeLayout(false);
            gbTurno.PerformLayout();
            gbDescuentos.ResumeLayout(false);
            gbDescuentos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTrabajador;
        private TextBox txtSueldoBasico;
        private TextBox txtHorasExtras;
        private TextBox txtPagoHorasExtras;
        private Label lblTrabajador;
        private Label lblSueldoBasico;
        private Label lblHorasExtras;
        private Label lblPagoHorasExtras;
        private GroupBox gbTurno;
        private RadioButton rbNocturno;
        private RadioButton rbDiurno;
        private GroupBox gbDescuentos;
        private CheckBox cbAFP;
        private CheckBox cbFonavi;
        private CheckBox cbRenta;
        private TextBox txtAfp;
        private TextBox txtFonavi;
        private TextBox txtRenta;
        private Label lblSueldoNeto;
        private TextBox txtSueldoNeto;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnAceptar;
    }
}