namespace appBloodBank
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.Restaurar);
            this.panel1.Controls.Add(this.Maximizar);
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.pbxMinimizar);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnAdministrador);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 109);
            this.panel1.TabIndex = 0;
            // 
            // Maximizar
            // 
            this.Maximizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(918, 3);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 25);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 8;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.pictureBox2_Click_2);
            // 
            // Cerrar
            // 
            this.Cerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(954, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(39, 25);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 7;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pbxMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinimizar.Image")));
            this.pbxMinimizar.Location = new System.Drawing.Point(880, 3);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(32, 25);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMinimizar.TabIndex = 6;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(394, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 10);
            this.panel4.TabIndex = 3;
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Location = new System.Drawing.Point(640, 56);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(100, 31);
            this.btnAdministrador.TabIndex = 5;
            this.btnAdministrador.Text = "Ubicacion";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(761, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Preguntas frecuentes";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Proceso de donacion";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("SuperFrench", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.Location = new System.Drawing.Point(394, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Inicio";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(884, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Contactanos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 457);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(16, 509);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 57);
            this.panel3.TabIndex = 2;
            // 
            // Restaurar
            // 
            this.Restaurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(918, 3);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(35, 25);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 9;
            this.Restaurar.TabStop = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 566);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Restaurar;
    }
}

