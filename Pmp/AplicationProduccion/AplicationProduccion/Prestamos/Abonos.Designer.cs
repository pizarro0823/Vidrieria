namespace AplicationProduccion.Prestamos
{
    partial class Abonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abonos));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCanAbonar3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRegistro = new System.Windows.Forms.TextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar :";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(112, 63);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(467, 29);
            this.textBoxNombre.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 25);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "-- Abonos";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(585, 67);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Buscar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(563, 132);
            this.dataGridView1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad Abonar :";
            // 
            // textBoxCanAbonar3
            // 
            this.textBoxCanAbonar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCanAbonar3.ForeColor = System.Drawing.Color.Red;
            this.textBoxCanAbonar3.Location = new System.Drawing.Point(162, 161);
            this.textBoxCanAbonar3.Multiline = true;
            this.textBoxCanAbonar3.Name = "textBoxCanAbonar3";
            this.textBoxCanAbonar3.Size = new System.Drawing.Size(178, 44);
            this.textBoxCanAbonar3.TabIndex = 8;
            this.textBoxCanAbonar3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "No Recibo :";
            // 
            // textBoxRegistro
            // 
            this.textBoxRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistro.Location = new System.Drawing.Point(112, 100);
            this.textBoxRegistro.Multiline = true;
            this.textBoxRegistro.Name = "textBoxRegistro";
            this.textBoxRegistro.Size = new System.Drawing.Size(133, 29);
            this.textBoxRegistro.TabIndex = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(251, 105);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 11;
            this.metroButton2.Text = "Buscar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(352, 170);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 12;
            this.metroButton3.Text = "Ingresar";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(23, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 14;
            // 
            // Abonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 430);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.textBoxRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCanAbonar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Abonos";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Abonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCanAbonar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRegistro;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.Label label6;
    }
}