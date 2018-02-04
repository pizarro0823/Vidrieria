using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicationProduccion.Prestamos
{
    public partial class Prestamos : MetroFramework.Forms.MetroForm
    {
        public Prestamos()
        {
            InitializeComponent();
            monthCalendar1.Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;

        }

        AplicationProduccion.Clases.Conexion cnx = new Clases.Conexion();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Inicio.Alvidrios inicio = new Inicio.Alvidrios();
            inicio.Show();
        }

        private void buttonCalendario_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
            }
            else
            {
                monthCalendar1.Visible = false;
            }


        }

        public void ingresarPrestamo()
        {
            cnx.conexionDB("insert into prestamos values ('" + textBoxNombre.Text+"','"+textBoxFecha.Text+"',GetDate(),"+textBoxPrestamo.Text+")");
            MessageBox.Show("Campos ingresados Correctamente");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ingresarPrestamo();
            dataGridView1.DataSource=cnx.conexionDBR("select consecutivo,nombre_completo,fecha_prestamo,valor_prestamo from prestamos where nombre_completo like '%"+textBoxNombre.Text+"%'");
            textBoxNombre.Clear();
            textBoxFecha.Clear();
            textBoxPrestamo.Clear();
            monthCalendar1.Visible = false;
            dataGridView1.Visible = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_MouseCaptureChanged(object sender, EventArgs e)
        {
            textBoxFecha.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBoxFecha.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Prestamos.Abonos ab = new Abonos();
            ab.Show();
        }
    }
}
