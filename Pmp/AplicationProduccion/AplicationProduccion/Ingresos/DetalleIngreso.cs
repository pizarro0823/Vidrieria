using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicationProduccion.Ingresos
{
    public partial class DetalleIngreso : MetroFramework.Forms.MetroForm
    {
        public DetalleIngreso()
        {
            InitializeComponent();
        }

        AplicationProduccion.Clases.Conexion cnx = new Clases.Conexion();
        AplicationProduccion.Clases.ExportarExcel ExportarExcel = new Clases.ExportarExcel();


        public void consultasLabels()
        {
            label9.Text = "" + dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["valor"].Value)).ToString("0,0");
            label8.Text = "" + dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["abonos"].Value)).ToString("0,0");
            label10.Text = "" + dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["Restante"].Value)).ToString("0,0");
        }


        public void consulta()
        {
            if (checkBoxDetallado.Checked == true)
            {
                if (String.IsNullOrEmpty(textBoxNombre.Text) | (String.IsNullOrEmpty(textBoxNFactura.Text)))
                {
                    dataGridView1.DataSource = cnx.conexionDBR("select nombreCliente,cedula,Direccion,Telefono,Detalle,Codigo_Vendedor,Fecha_Factura,Numero_factura,Fecha_Anticipo,Numero_anticipo,Valor,Anticipo,Modo_de_pago from Ventas_Diarias");
                }
                else if (textBoxNombre.Text.Contains(Text))
                {
                    dataGridView1.DataSource = cnx.conexionDBR("select nombreCliente,cedula,Direccion,Telefono,Detalle,Codigo_Vendedor,Fecha_Factura,Numero_factura,Fecha_Anticipo,Numero_anticipo,Valor,Anticipo,Modo_de_pago" +
                                                               " from Ventas_Diarias where nombreCliente like '%"+textBoxNombre.Text+"%'");
                }else if (textBoxNFactura.Text.Contains(Text))
                {
                    dataGridView1.DataSource = cnx.conexionDBR("select nombreCliente,cedula,Direccion,Telefono,Detalle,Codigo_Vendedor,Fecha_Factura,Numero_factura,Fecha_Anticipo,Numero_anticipo,Valor,Anticipo,Modo_de_pago" +
                                                             " from Ventas_Diarias where Numero_factura="+textBoxNFactura.Text+"");
                }
            }
            else if (checkBoxFiltrado_Pendientes.Checked == true)
            {
                if (String.IsNullOrEmpty(textBoxNombre.Text))
                {
                    dataGridView1.DataSource = cnx.conexionDBR("select Numero_factura,nombreCliente,count(*) as Numero_de_facturas,Valor,sum(Anticipo) as abonos, (valor-sum(Anticipo)) as Restante from Ventas_Diarias  GROUP BY Numero_factura, Valor,nombreCliente HAVING (valor-sum(Anticipo)) > 0");
                    consultasLabels();
                }
                else
                {
                    dataGridView1.DataSource = cnx.conexionDBR("select Numero_factura,nombreCliente,count(*) as Numero_de_facturas,Valor,sum(Anticipo) as abonos, (valor-sum(Anticipo)) as Restante from Ventas_Diarias where nombreCliente like '%" + textBoxNombre.Text + "%' GROUP BY Numero_factura, Valor,nombreCliente");
                    consultasLabels();
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (checkBoxFiltrado_Pendientes.Checked == true)
            {
                dataGridView1.ClearSelection();

                try
                {
                    if ((int)this.dataGridView1.Rows[e.RowIndex].Cells["Restante"].Value > 0)
                    {
                        foreach (DataGridViewCell celda in this.dataGridView1.Rows[e.RowIndex].Cells)
                        {
                            celda.Style.BackColor = Color.OrangeRed;
                        }
                    }
                    if ((int)this.dataGridView1.Rows[e.RowIndex].Cells["Restante"].Value < 0)
                    {
                        foreach (DataGridViewCell celda in this.dataGridView1.Rows[e.RowIndex].Cells)
                        {
                            celda.Style.BackColor = Color.Yellow;
                        }
                    }
                }
                catch (System.NullReferenceException)
                {

                }
                catch (System.ArgumentException)
                {

                }
            }


        }



        private void checkBoxFiltrado_Especial_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFiltrado_Pendientes.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBoxDetallado.Checked = false;

            }
        }

        private void checkBoxDetallado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDetallado.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBoxFiltrado_Pendientes.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportarExcel.exportarExcel("");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Inicio.Alvidrios inicio = new Inicio.Alvidrios();
            inicio.Show();
        }
    }
}
