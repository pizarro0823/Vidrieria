using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicationProduccion.Ingresos
{
    public partial class Facturador : MetroFramework.Forms.MetroForm
    {
        public Facturador()
        {
            InitializeComponent();

            dataGridView1.AllowUserToAddRows = false;


        }

        AplicationProduccion.Clases.Conexion cnx = new Clases.Conexion();




        public void IngresoDatos_MetroTab_Ventas(string FormaPago, string Estado_Factura)
        {


            if (String.IsNullOrEmpty(textBoxVentas_Nombre.Text) | String.IsNullOrEmpty(textBoxVentas_Cedula.Text) | String.IsNullOrEmpty(textBoxVentas_Direccion.Text) | String.IsNullOrEmpty(textBoxVentas_Telefono.Text) | String.IsNullOrEmpty(textBoxVentas_Detalle.Text) | String.IsNullOrEmpty(textBoxVentas_CodigoVendedor.Text) | String.IsNullOrEmpty(dateTime_ventas.Text) | String.IsNullOrEmpty(textBoxVentas_Valor.Text) | String.IsNullOrEmpty(textBoxVentas_Anticipo.Text) | String.IsNullOrEmpty(textBoxVentas_Cantidad.Text) | String.IsNullOrEmpty(checkBoxVentas_Efectivo.Text) | String.IsNullOrEmpty(checkBoxVentas_Tarjeta.Text))
            {
                MessageBox.Show("Error Faltan Campos Por llenar");
            }
            else
            {


                DataTable dt = new DataTable();
                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                cnx.Open();
                SqlCommand cmd = new SqlCommand("insert into Ventas_Diarias values('" + textBoxVentas_Nombre.Text + "', '" + textBoxVentas_Cedula.Text + "', '" + textBoxVentas_Direccion.Text + "', '" + textBoxVentas_Telefono.Text + "', '" + textBoxVentas_Detalle.Text + "', " + textBoxVentas_CodigoVendedor.Text + ", '" + dateTime_ventas.Text + "', " + textBoxVentas_Valor.Text.Replace(".", "") + ", " + textBoxVentas_Anticipo.Text.Replace(".", "") + ", " + textBoxVentas_Cantidad.Text + ", '" + FormaPago + "', " + textBox_Ventas_Nfactura.Text + ", '" + Estado_Factura + "','" + dateTime_ventas.Text + "'," + textBox_Ventas_Nabono.Text + ")", cnx);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);
                cnx.Close();

                foreach (DataRow f in dt.Rows)
                {
                    if (Convert.ToInt32(f["valor"]) < Convert.ToInt32(f["anticipo"]))
                    {
                        Estado_Factura = "Por pagar";
                    }
                    else if (Convert.ToInt32(f["valor"]) == Convert.ToInt32(f["anticipo"]))
                    {
                        Estado_Factura = "Cancelado";
                    }


                }

                MessageBox.Show("<<<<Campos Ingresados Correctamente>>>>");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBoxVentas_Efectivo.Checked == true)
            {
                IngresoDatos_MetroTab_Ventas("Efectivo", null);
            }
            else if (checkBoxVentas_Tarjeta.Checked == true)
            {
                IngresoDatos_MetroTab_Ventas("Tarjeta", null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxVentas_Nombre.Text = dataGridView1.CurrentRow.Cells["nombreCliente"].Value.ToString();
            textBoxVentas_Cedula.Text = dataGridView1.CurrentRow.Cells["cedula"].Value.ToString();
            textBoxVentas_Direccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
            textBoxVentas_Telefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            textBoxVentas_Detalle.Text = dataGridView1.CurrentRow.Cells["Detalle"].Value.ToString();
            textBoxVentas_Valor.Text = dataGridView1.CurrentRow.Cells["Valor"].Value.ToString();
            textBoxVentas_Cantidad.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
            textBox_Ventas_Nfactura.Text = dataGridView1.CurrentRow.Cells["Numero_factura"].Value.ToString();
            textBoxVentas_Cantidad.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();

        }





        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxVentas_Nombre.Text))
            {

            }
            else
            {

                dataGridView1.DataSource = cnx.conexionDBR("select Numero_factura,Numero_anticipo,nombreCliente,cedula,Direccion,Telefono,Detalle,Codigo_Vendedor,fecha_factura,Valor,Anticipo,Cantidad,Modo_de_pago,Estado,fecha_anticipo" +
                                                    " from Ventas_Diarias where nombreCliente like '%" + textBoxVentas_Nombre.Text + "%'");
            }
            if (string.IsNullOrEmpty(textBox_Ventas_Nfactura.Text))
            {

            }
            else
            {
                dataGridView1.DataSource = cnx.conexionDBR("select Numero_factura,Numero_anticipo,nombreCliente,cedula,Direccion,Telefono,Detalle,Codigo_Vendedor,fecha_factura,Valor,Anticipo,Cantidad,Modo_de_pago,Estado,fecha_anticipo" +
                                                 " from Ventas_Diarias where Numero_factura = " + textBox_Ventas_Nfactura.Text + "");

                ///Este datagrid View esta oculto detras del datagridview1
                ///Solo se utiliza como ayuda para poder mostrar el valor de restante
                dataGridView3.DataSource = cnx.conexionDBR("select  Numero_factura,count(*) as Numero_de_facturas,Valor,sum(Anticipo) as abonos, (valor-sum(Anticipo)) as Restante" +
                                                           " from Ventas_Diarias where Numero_factura = " + textBox_Ventas_Nfactura.Text + " GROUP BY Numero_factura, Valor");

                label6.Text = "" + dataGridView1.Rows.Cast<DataGridViewRow>().Max(x => Convert.ToInt32(x.Cells["Valor"].Value)).ToString("0,0");
                label19.Text = "" + dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["Anticipo"].Value)).ToString("0,0");
                label30.Text = "" + dataGridView3.Rows.Cast<DataGridViewRow>().Max(x => Convert.ToInt32(x.Cells["Restante"].Value)).ToString("0,0");

            }







            this.dataGridView1.Columns["Valor"].Visible = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxVentas_Anticipo.Clear();
            textBoxVentas_Cantidad.Clear();
            textBoxVentas_Cedula.Clear();
            textBoxVentas_CodigoVendedor.Clear();
            textBoxVentas_Detalle.Clear();
            textBoxVentas_Direccion.Clear();
            textBoxVentas_Nombre.Clear();
            textBoxVentas_Telefono.Clear();
            textBoxVentas_Valor.Clear();
            textBox_Ventas_Nabono.Clear();
            textBox_Ventas_Nfactura.Clear();
        }
    }
}