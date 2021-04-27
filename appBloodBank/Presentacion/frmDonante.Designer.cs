namespace appBloodBank.Presentacion
{
    partial class frmDonante
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
            this.dgvDonante = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtPresion = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbRh = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Conectar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonante)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonante
            // 
            this.dgvDonante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonante.Location = new System.Drawing.Point(505, 19);
            this.dgvDonante.Name = "dgvDonante";
            this.dgvDonante.Size = new System.Drawing.Size(403, 285);
            this.dgvDonante.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero de documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Genero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Peso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Edad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Rh";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Temperatura";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Presion Arterial";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(201, 11);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(201, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(232, 20);
            this.txtApellido.TabIndex = 16;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(201, 81);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(150, 20);
            this.txtDocumento.TabIndex = 17;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(201, 153);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(150, 20);
            this.txtEdad.TabIndex = 19;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(201, 185);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(150, 20);
            this.txtPeso.TabIndex = 20;
            // 
            // txtPresion
            // 
            this.txtPresion.Location = new System.Drawing.Point(201, 292);
            this.txtPresion.Name = "txtPresion";
            this.txtPresion.Size = new System.Drawing.Size(167, 20);
            this.txtPresion.TabIndex = 23;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(201, 335);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(167, 20);
            this.txtTemperatura.TabIndex = 24;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(201, 375);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(167, 20);
            this.txtTelefono.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(201, 424);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 20);
            this.txtEmail.TabIndex = 26;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(201, 116);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 27;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(201, 219);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 28;
            // 
            // cmbRh
            // 
            this.cmbRh.FormattingEnabled = true;
            this.cmbRh.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-"});
            this.cmbRh.Location = new System.Drawing.Point(201, 258);
            this.cmbRh.Name = "cmbRh";
            this.cmbRh.Size = new System.Drawing.Size(121, 21);
            this.cmbRh.TabIndex = 29;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(517, 373);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // Conectar
            // 
            this.Conectar.Location = new System.Drawing.Point(625, 373);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(75, 23);
            this.Conectar.TabIndex = 31;
            this.Conectar.Text = "conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            // 
            // frmDonante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 478);
            this.Controls.Add(this.Conectar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbRh);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.txtPresion);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDonante);
            this.Name = "frmDonante";
            this.Text = "frmDonante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtPresion;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbRh;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button Conectar;
    }
}