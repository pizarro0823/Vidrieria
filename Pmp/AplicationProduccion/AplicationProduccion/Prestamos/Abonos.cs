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
    public partial class Abonos : MetroFramework.Forms.MetroForm
    {
        public Abonos()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        AplicationProduccion.Clases.Conexion cnx = new Clases.Conexion();



        public void consultar()
        {
            dataGridView1.DataSource = cnx.conexionDBR("select prestamos.consecutivo,prestamos.nombre_completo,prestamos.fecha_prestamo,prestamos.valor_prestamo as prestamo from prestamos where nombre_completo like '%" + textBoxNombre.Text + "%' ");
            dataGridView1.Columns["nombre_completo"].Width = 180;
        }



        private void metroButton1_Click(object sender, EventArgs e)
        {
               consultar();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Inicio.Alvidrios incio = new Inicio.Alvidrios();
            incio.Show();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cnx.conexionDBR("select prestamos.consecutivo, prestamos.nombre_completo, prestamos.fecha_prestamo, abono_prestamos.abono,prestamos.valor_prestamo,prestamos.fecha_prestamo " +
                                                       "from prestamos inner join abono_prestamos on abono_prestamos.consecutivo = prestamos.consecutivo" +
                                                       " where abono_prestamos.consecutivo = "+textBoxRegistro.Text+"");

            label6.Text = "Total Abonos : " + dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["abono"].Value)).ToString();
            this.dataGridView1.Columns["valor_prestamo"].Visible = false;
            dataGridView1.Columns["nombre_completo"].Width = 180;
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            cnx.conexionDB("insert into abono_prestamos values ("+textBoxRegistro.Text+","+textBoxCanAbonar3.Text+",GETDATE())");
            MessageBox.Show("Campos Ingresados Correctamente");
            textBoxCanAbonar3.Clear();
        }

        private void Abonos_Load(object sender, EventArgs e)
        {

        }
    }
}
