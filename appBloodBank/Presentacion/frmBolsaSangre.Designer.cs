namespace appBloodBank.Presentacion
{
    partial class frmBolsaSangre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.cmbModificacion = new System.Windows.Forms.ComboBox();
            this.cmbMetodoObtencion = new System.Windows.Forms.ComboBox();
            this.cmbTemperatura = new System.Windows.Forms.TextBox();
            this.cmbVolumen = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbClasificacion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.cmbFactor = new System.Windows.Forms.ComboBox();
            this.dgvBolsaSangre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolsaSangre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modificacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Metodo de obtencion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temperatura de almacenamiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Volumen contenido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de vencimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Clasificacion del donante";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Resultado de pruebas de analisis";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(298, 38);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(202, 20);
            this.txtNombreProducto.TabIndex = 11;
            // 
            // cmbModificacion
            // 
            this.cmbModificacion.FormattingEnabled = true;
            this.cmbModificacion.Location = new System.Drawing.Point(298, 74);
            this.cmbModificacion.Name = "cmbModificacion";
            this.cmbModificacion.Size = new System.Drawing.Size(121, 21);
            this.cmbModificacion.TabIndex = 12;
            // 
            // cmbMetodoObtencion
            // 
            this.cmbMetodoObtencion.FormattingEnabled = true;
            this.cmbMetodoObtencion.Items.AddRange(new object[] {
            "Sangre total",
            "Hemaferesis"});
            this.cmbMetodoObtencion.Location = new System.Drawing.Point(298, 114);
            this.cmbMetodoObtencion.Name = "cmbMetodoObtencion";
            this.cmbMetodoObtencion.Size = new System.Drawing.Size(121, 21);
            this.cmbMetodoObtencion.TabIndex = 13;
            // 
            // cmbTemperatura
            // 
            this.cmbTemperatura.Location = new System.Drawing.Point(298, 152);
            this.cmbTemperatura.Name = "cmbTemperatura";
            this.cmbTemperatura.Size = new System.Drawing.Size(121, 20);
            this.cmbTemperatura.TabIndex = 14;
            // 
            // cmbVolumen
            // 
            this.cmbVolumen.Location = new System.Drawing.Point(298, 187);
            this.cmbVolumen.Name = "cmbVolumen";
            this.cmbVolumen.Size = new System.Drawing.Size(121, 20);
            this.cmbVolumen.TabIndex = 15;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(298, 226);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 16;
            // 
            // cmbClasificacion
            // 
            this.cmbClasificacion.FormattingEnabled = true;
            this.cmbClasificacion.Items.AddRange(new object[] {
            "Voluntario",
            "Familiar",
            "Autologa"});
            this.cmbClasificacion.Location = new System.Drawing.Point(298, 272);
            this.cmbClasificacion.Name = "cmbClasificacion";
            this.cmbClasificacion.Size = new System.Drawing.Size(121, 21);
            this.cmbClasificacion.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Factor RHO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Grupo sanguineo";
            // 
            // cmbGrupoSanguineo
            // 
            this.cmbGrupoSanguineo.FormattingEnabled = true;
            this.cmbGrupoSanguineo.Items.AddRange(new object[] {
            "Positivo",
            "Negativo"});
            this.cmbGrupoSanguineo.Location = new System.Drawing.Point(298, 317);
            this.cmbGrupoSanguineo.Name = "cmbGrupoSanguineo";
            this.cmbGrupoSanguineo.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupoSanguineo.TabIndex = 19;
            // 
            // cmbFactor
            // 
            this.cmbFactor.FormattingEnabled = true;
            this.cmbFactor.Items.AddRange(new object[] {
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cmbFactor.Location = new System.Drawing.Point(298, 351);
            this.cmbFactor.Name = "cmbFactor";
            this.cmbFactor.Size = new System.Drawing.Size(121, 21);
            this.cmbFactor.TabIndex = 20;
            // 
            // dgvBolsaSangre
            // 
            this.dgvBolsaSangre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBolsaSangre.Location = new System.Drawing.Point(558, 38);
            this.dgvBolsaSangre.Name = "dgvBolsaSangre";
            this.dgvBolsaSangre.Size = new System.Drawing.Size(389, 335);
            this.dgvBolsaSangre.TabIndex = 21;
            // 
            // frmBolsaSangre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 505);
            this.Controls.Add(this.dgvBolsaSangre);
            this.Controls.Add(this.cmbFactor);
            this.Controls.Add(this.cmbGrupoSanguineo);
            this.Controls.Add(this.cmbClasificacion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbVolumen);
            this.Controls.Add(this.cmbTemperatura);
            this.Controls.Add(this.cmbMetodoObtencion);
            this.Controls.Add(this.cmbModificacion);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBolsaSangre";
            this.Text = "frmBolsaSangre";
            this.Load += new System.EventHandler(this.frmBolsaSangre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolsaSangre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.ComboBox cmbModificacion;
        private System.Windows.Forms.ComboBox cmbMetodoObtencion;
        private System.Windows.Forms.TextBox cmbTemperatura;
        private System.Windows.Forms.TextBox cmbVolumen;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbClasificacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGrupoSanguineo;
        private System.Windows.Forms.ComboBox cmbFactor;
        private System.Windows.Forms.DataGridView dgvBolsaSangre;
    }
}