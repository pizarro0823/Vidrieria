namespace AplicationProduccion.Gastos
{
    partial class Ocompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ocompra));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxFConsecutiva = new System.Windows.Forms.CheckBox();
            this.checkBoxOrdenNueva = new System.Windows.Forms.CheckBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxRaiz = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNoFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAlmacen = new System.Windows.Forms.TextBox();
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxClasificacion = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "-- Compras";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(10, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 10);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(10, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 433);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 28);
            this.button2.TabIndex = 22;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.checkBoxFConsecutiva);
            this.groupBox1.Controls.Add(this.checkBoxOrdenNueva);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(13, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(996, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(83, 132);
            this.panel3.TabIndex = 4;
            // 
            // checkBoxFConsecutiva
            // 
            this.checkBoxFConsecutiva.AutoSize = true;
            this.checkBoxFConsecutiva.Location = new System.Drawing.Point(13, 65);
            this.checkBoxFConsecutiva.Name = "checkBoxFConsecutiva";
            this.checkBoxFConsecutiva.Size = new System.Drawing.Size(129, 17);
            this.checkBoxFConsecutiva.TabIndex = 1;
            this.checkBoxFConsecutiva.Text = "Facturas Consecutiva";
            this.checkBoxFConsecutiva.UseVisualStyleBackColor = true;
            this.checkBoxFConsecutiva.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxOrdenNueva
            // 
            this.checkBoxOrdenNueva.AutoSize = true;
            this.checkBoxOrdenNueva.Location = new System.Drawing.Point(13, 30);
            this.checkBoxOrdenNueva.Name = "checkBoxOrdenNueva";
            this.checkBoxOrdenNueva.Size = new System.Drawing.Size(90, 17);
            this.checkBoxOrdenNueva.TabIndex = 0;
            this.checkBoxOrdenNueva.Text = "Orden Nueva";
            this.checkBoxOrdenNueva.UseVisualStyleBackColor = true;
            this.checkBoxOrdenNueva.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor.ForeColor = System.Drawing.Color.Red;
            this.textBoxValor.Location = new System.Drawing.Point(715, 134);
            this.textBoxValor.Multiline = true;
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(203, 65);
            this.textBoxValor.TabIndex = 15;
            this.textBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            this.textBoxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(648, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor :";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.ForeColor = System.Drawing.Color.Red;
            this.textBoxCantidad.Location = new System.Drawing.Point(961, 134);
            this.textBoxCantidad.Multiline = true;
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(60, 65);
            this.textBoxCantidad.TabIndex = 17;
            this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(924, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "C :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(327, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Raiz :";
            // 
            // comboBoxRaiz
            // 
            this.comboBoxRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRaiz.FormattingEnabled = true;
            this.comboBoxRaiz.Location = new System.Drawing.Point(384, 171);
            this.comboBoxRaiz.Name = "comboBoxRaiz";
            this.comboBoxRaiz.Size = new System.Drawing.Size(239, 28);
            this.comboBoxRaiz.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(274, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "No Factura :";
            // 
            // textBoxNoFactura
            // 
            this.textBoxNoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoFactura.Location = new System.Drawing.Point(384, 94);
            this.textBoxNoFactura.Multiline = true;
            this.textBoxNoFactura.Name = "textBoxNoFactura";
            this.textBoxNoFactura.Size = new System.Drawing.Size(183, 25);
            this.textBoxNoFactura.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(610, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Almacen :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(341, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nit :";
            // 
            // textBoxAlmacen
            // 
            this.textBoxAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlmacen.Location = new System.Drawing.Point(715, 94);
            this.textBoxAlmacen.Multiline = true;
            this.textBoxAlmacen.Name = "textBoxAlmacen";
            this.textBoxAlmacen.Size = new System.Drawing.Size(306, 25);
            this.textBoxAlmacen.TabIndex = 14;
            // 
            // textBoxNit
            // 
            this.textBoxNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNit.Location = new System.Drawing.Point(384, 134);
            this.textBoxNit.Multiline = true;
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(183, 25);
            this.textBoxNit.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(302, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Detalle :";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(384, 263);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(637, 59);
            this.textBoxDescripcion.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(266, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 161);
            this.dataGridView1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(262, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Clasificacion :";
            // 
            // comboBoxClasificacion
            // 
            this.comboBoxClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClasificacion.FormattingEnabled = true;
            this.comboBoxClasificacion.Location = new System.Drawing.Point(384, 214);
            this.comboBoxClasificacion.Name = "comboBoxClasificacion";
            this.comboBoxClasificacion.Size = new System.Drawing.Size(239, 28);
            this.comboBoxClasificacion.TabIndex = 25;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(715, 214);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(306, 28);
            this.comboBoxEstado.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(635, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Estado :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyy-MM-dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(821, 281);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 28;
            // 
            // Ocompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 526);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.comboBoxClasificacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxRaiz);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNit);
            this.Controls.Add(this.textBoxAlmacen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNoFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ocompra";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ocompra_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxFConsecutiva;
        private System.Windows.Forms.CheckBox checkBoxOrdenNueva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNoFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAlmacen;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxRaiz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxClasificacion;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}