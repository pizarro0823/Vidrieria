namespace AplicationProduccion.Consultas
{
    partial class Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxIngresarBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metro = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMedida = new System.Windows.Forms.TextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIngresarBusqueda
            // 
            this.textBoxIngresarBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIngresarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIngresarBusqueda.Location = new System.Drawing.Point(11, 35);
            this.textBoxIngresarBusqueda.Multiline = true;
            this.textBoxIngresarBusqueda.Name = "textBoxIngresarBusqueda";
            this.textBoxIngresarBusqueda.Size = new System.Drawing.Size(230, 45);
            this.textBoxIngresarBusqueda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(16, 44);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(78, 15);
            this.metroRadioButton1.TabIndex = 4;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "Referencia";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(135, 44);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(64, 15);
            this.metroRadioButton2.TabIndex = 5;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "Sistema";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.metroRadioButton2);
            this.groupBox1.Controls.Add(this.metroRadioButton1);
            this.groupBox1.Location = new System.Drawing.Point(13, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
            // 
            // metro
            // 
            this.metro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metro.Location = new System.Drawing.Point(112, 205);
            this.metro.Name = "metro";
            this.metro.Size = new System.Drawing.Size(28, 37);
            this.metro.TabIndex = 7;
            this.metro.Text = "?";
            this.metro.UseSelectable = true;
            this.metro.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Medida:";
            // 
            // textBoxMedida
            // 
            this.textBoxMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMedida.Location = new System.Drawing.Point(83, 96);
            this.textBoxMedida.Multiline = true;
            this.textBoxMedida.Name = "textBoxMedida";
            this.textBoxMedida.Size = new System.Drawing.Size(158, 51);
            this.textBoxMedida.TabIndex = 10;
            this.textBoxMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(11, 166);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(230, 33);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Buscar:";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButtonBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxIngresarBusqueda);
            this.panel1.Controls.Add(this.metro);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBoxMedida);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(5, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 366);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 49);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(531, 366);
            this.dataGridView1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "- Consulta Inv";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultar";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxIngresarBusqueda;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMedida;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}