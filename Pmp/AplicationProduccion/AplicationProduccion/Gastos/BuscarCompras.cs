using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicationProduccion.Gastos
{
    public partial class BuscarCompras : MetroFramework.Forms.MetroForm
    {
        public BuscarCompras()
        {
            InitializeComponent();
            Calendario.Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        AplicationProduccion.Clases.Conexion cnx = new Clases.Conexion();



        public void consulta()
        {

            dataGridView1.DataSource = cnx.conexionDBR("Select  N_Factura_vendedor,Nombre_Almacen,Nit_Empresa,Descripcion_Mercancia,cantidad_ingreso,valor_unitario,valor_unitario*cantidad_ingreso as valorTotal,fecha_ingreso  from compras " +
                             " where N_Factura_vendedor like '%" + textBoxNfactura.Text + "%' or Nombre_Almacen like '%" + textBoxProveedor.Text + "%' and fecha_ingreso = '" + textBoxFecha.Text + "'");

            label6.Text = "" + dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["valorTotal"].Value)).ToString();
            this.dataGridView1.Columns["valorTotal"].Visible = false;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Inicio.Alvidrios inicio = new Inicio.Alvidrios();
            inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Calendario.Visible == true)
            {
                Calendario.Visible = false;
            }
            else
            {
                Calendario.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consulta();
        }



        private void Calendario_MouseCaptureChanged(object sender, EventArgs e)
        {
            textBoxFecha.Text = Calendario.SelectionEnd.ToShortDateString();
            textBoxFecha.Text = Calendario.SelectionRange.Start.ToString("yyyy-MM-dd");
        }
    }
}
