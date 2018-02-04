namespace AplicationProduccion.Gastos
{
    partial class BuscarCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCompras));
            this.textBoxNfactura = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNfactura
            // 
            this.textBoxNfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNfactura.Location = new System.Drawing.Point(121, 72);
            this.textBoxNfactura.Multiline = true;
            this.textBoxNfactura.Name = "textBoxNfactura";
            this.textBoxNfactura.Size = new System.Drawing.Size(199, 25);
            this.textBoxNfactura.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "- Buscar Ordenes Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "No Factura :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(790, 251);
            this.dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha:";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFecha.Location = new System.Drawing.Point(121, 112);
            this.textBoxFecha.Multiline = true;
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(160, 25);
            this.textBoxFecha.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(342, 112);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 11;
            this.Calendario.MouseCaptureChanged += new System.EventHandler(this.Calendario_MouseCaptureChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(338, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Proveedor :";
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProveedor.Location = new System.Drawing.Point(444, 72);
            this.textBoxProveedor.Multiline = true;
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.Size = new System.Drawing.Size(307, 25);
            this.textBoxProveedor.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(807, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(807, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 251);
            this.panel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(104, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Valor Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor Total:";
            // 
            // BuscarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxNfactura);
            this.Name = "BuscarCompras";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNfactura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}