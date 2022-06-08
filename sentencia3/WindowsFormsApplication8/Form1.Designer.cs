namespace WindowsFormsApplication8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cargar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.almacenar = new System.Windows.Forms.Button();
            this.buttonTextura = new System.Windows.Forms.Button();
            this.mostrar1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.actualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mostrar2 = new System.Windows.Forms.ListBox();
            this.mostrar3 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cargar
            // 
            this.cargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(164)))), ((int)(((byte)(64)))));
            this.cargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(26)))));
            this.cargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargar.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.cargar.ForeColor = System.Drawing.Color.Black;
            this.cargar.Location = new System.Drawing.Point(717, 70);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(181, 54);
            this.cargar.TabIndex = 0;
            this.cargar.Text = "Cargar Imagen";
            this.cargar.UseVisualStyleBackColor = false;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(52, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(77, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(52, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(77, 27);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(52, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(77, 27);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "G:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "B:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(188, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(651, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 450);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // almacenar
            // 
            this.almacenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.almacenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.almacenar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.almacenar.FlatAppearance.BorderSize = 2;
            this.almacenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.almacenar.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.almacenar.Location = new System.Drawing.Point(13, 19);
            this.almacenar.Name = "almacenar";
            this.almacenar.Size = new System.Drawing.Size(122, 71);
            this.almacenar.TabIndex = 14;
            this.almacenar.Text = "Cambio 10x10";
            this.almacenar.UseVisualStyleBackColor = false;
            this.almacenar.Click += new System.EventHandler(this.almacenar_Click);
            // 
            // buttonTextura
            // 
            this.buttonTextura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.buttonTextura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTextura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.buttonTextura.FlatAppearance.BorderSize = 2;
            this.buttonTextura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTextura.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTextura.Location = new System.Drawing.Point(13, 110);
            this.buttonTextura.Name = "buttonTextura";
            this.buttonTextura.Size = new System.Drawing.Size(122, 54);
            this.buttonTextura.TabIndex = 15;
            this.buttonTextura.Text = "Texturas";
            this.buttonTextura.UseVisualStyleBackColor = false;
            this.buttonTextura.Click += new System.EventHandler(this.buttonTextura_Click);
            // 
            // mostrar1
            // 
            this.mostrar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mostrar1.Font = new System.Drawing.Font("Quicksand Medium", 8.25F, System.Drawing.FontStyle.Bold);
            this.mostrar1.FormattingEnabled = true;
            this.mostrar1.ItemHeight = 16;
            this.mostrar1.Location = new System.Drawing.Point(294, 736);
            this.mostrar1.Name = "mostrar1";
            this.mostrar1.Size = new System.Drawing.Size(182, 98);
            this.mostrar1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label4.Location = new System.Drawing.Point(398, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 65);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sentencia 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label5.Location = new System.Drawing.Point(312, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 46);
            this.label5.TabIndex = 18;
            this.label5.Text = "Seleccione una Imagen:";
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Tomato;
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(77)))), ((int)(((byte)(1)))));
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.salir.ForeColor = System.Drawing.SystemColors.Control;
            this.salir.Location = new System.Drawing.Point(921, 70);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(137, 54);
            this.salir.TabIndex = 19;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(14, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 169);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.actualizar);
            this.panel2.Controls.Add(this.almacenar);
            this.panel2.Controls.Add(this.buttonTextura);
            this.panel2.Location = new System.Drawing.Point(15, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 264);
            this.panel2.TabIndex = 21;
            // 
            // actualizar
            // 
            this.actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(148)))), ((int)(((byte)(115)))));
            this.actualizar.FlatAppearance.BorderSize = 2;
            this.actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(148)))), ((int)(((byte)(115)))));
            this.actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizar.Font = new System.Drawing.Font("Quicksand Medium", 13.25F, System.Drawing.FontStyle.Bold);
            this.actualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.actualizar.Location = new System.Drawing.Point(13, 192);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(122, 51);
            this.actualizar.TabIndex = 22;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = false;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label6.Location = new System.Drawing.Point(276, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 48);
            this.label6.TabIndex = 22;
            this.label6.Text = "Imagen Cargada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label7.Location = new System.Drawing.Point(802, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 48);
            this.label7.TabIndex = 23;
            this.label7.Text = "Resultado";
            // 
            // mostrar2
            // 
            this.mostrar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mostrar2.Font = new System.Drawing.Font("Quicksand Medium", 8.25F, System.Drawing.FontStyle.Bold);
            this.mostrar2.FormattingEnabled = true;
            this.mostrar2.ItemHeight = 16;
            this.mostrar2.Location = new System.Drawing.Point(519, 736);
            this.mostrar2.Name = "mostrar2";
            this.mostrar2.Size = new System.Drawing.Size(182, 98);
            this.mostrar2.TabIndex = 24;
            // 
            // mostrar3
            // 
            this.mostrar3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mostrar3.Font = new System.Drawing.Font("Quicksand Medium", 8.25F, System.Drawing.FontStyle.Bold);
            this.mostrar3.FormattingEnabled = true;
            this.mostrar3.ItemHeight = 16;
            this.mostrar3.Location = new System.Drawing.Point(741, 736);
            this.mostrar3.Name = "mostrar3";
            this.mostrar3.Size = new System.Drawing.Size(182, 98);
            this.mostrar3.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(327, 699);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Textura #1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(548, 699);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 28);
            this.label9.TabIndex = 27;
            this.label9.Text = "Textura #2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Quicksand Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(739, 699);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 28);
            this.label10.TabIndex = 28;
            this.label10.Text = "Textura #3 o Más";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1113, 858);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mostrar3);
            this.Controls.Add(this.mostrar2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mostrar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cargar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentencia 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button almacenar;
        private System.Windows.Forms.Button buttonTextura;
        private System.Windows.Forms.ListBox mostrar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox mostrar2;
        private System.Windows.Forms.ListBox mostrar3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

