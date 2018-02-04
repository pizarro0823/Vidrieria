namespace AplicationProduccion.Prestamos
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonCalendario = new System.Windows.Forms.Button();
            this.LAbelFecha = new System.Windows.Forms.Label();
            this.textBoxPrestamo = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar-Prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Completo:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(152, 97);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(429, 34);
            this.textBoxNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(153, 143);
            this.textBoxFecha.Multiline = true;
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(249, 34);
            this.textBoxFecha.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(620, 97);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.MouseCaptureChanged += new System.EventHandler(this.monthCalendar1_MouseCaptureChanged);
            // 
            // buttonCalendario
            // 
            this.buttonCalendario.Location = new System.Drawing.Point(408, 148);
            this.buttonCalendario.Name = "buttonCalendario";
            this.buttonCalendario.Size = new System.Drawing.Size(36, 23);
            this.buttonCalendario.TabIndex = 7;
            this.buttonCalendario.Text = "...";
            this.buttonCalendario.UseVisualStyleBackColor = true;
            this.buttonCalendario.Click += new System.EventHandler(this.buttonCalendario_Click);
            // 
            // LAbelFecha
            // 
            this.LAbelFecha.AutoSize = true;
            this.LAbelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAbelFecha.Location = new System.Drawing.Point(9, 206);
            this.LAbelFecha.Name = "LAbelFecha";
            this.LAbelFecha.Size = new System.Drawing.Size(143, 24);
            this.LAbelFecha.TabIndex = 8;
            this.LAbelFecha.Text = "Valor Prestamo:";
            // 
            // textBoxPrestamo
            // 
            this.textBoxPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrestamo.ForeColor = System.Drawing.Color.Red;
            this.textBoxPrestamo.Location = new System.Drawing.Point(153, 196);
            this.textBoxPrestamo.Multiline = true;
            this.textBoxPrestamo.Name = "textBoxPrestamo";
            this.textBoxPrestamo.Size = new System.Drawing.Size(249, 49);
            this.textBoxPrestamo.TabIndex = 9;
            this.textBoxPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(620, 328);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(86, 35);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Ingresar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(726, 328);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(86, 35);
            this.metroButton2.TabIndex = 11;
            this.metroButton2.Text = "Abono";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 89);
            this.dataGridView1.TabIndex = 12;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 386);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.textBoxPrestamo);
            this.Controls.Add(this.LAbelFecha);
            this.Controls.Add(this.buttonCalendario);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Prestamos";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonCalendario;
        private System.Windows.Forms.Label LAbelFecha;
        private System.Windows.Forms.TextBox textBoxPrestamo;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}