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
            dataGridView2.AllowUserToAddRows = false;


        }

        AplicationProduccion.Clases.Conexion cnx = new Clases.Conexion();

        #region TAG CONTROL VENTAS...............////////////////////////////////...............................


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
                SqlCommand cmd = new SqlCommand("insert into Ventas_Diarias values('" + textBoxVentas_Nombre.Text.Trim().ToUpper() + "', '" + textBoxVentas_Cedula.Text.Trim() + "', '" + textBoxVentas_Direccion.Text.Trim().ToUpper() + "', '" + textBoxVentas_Telefono.Text.Trim() + "', '" + textBoxVentas_Detalle.Text.Trim().ToUpper() + "', " + textBoxVentas_CodigoVendedor.Text.Trim() + ", '" + dateTime_ventas.Text.Trim() + "', " + textBoxVentas_Valor.Text.Replace(".", "").Trim() + ", " + textBoxVentas_Anticipo.Text.Replace(".", "").Trim() + ", " + textBoxVentas_Cantidad.Text.Trim() + ", '" + FormaPago + "', " + textBox_Ventas_Nfactura.Text.Trim() + ", '" + Estado_Factura + "','" + dateTime_ventas.Text.Trim() + "'," + textBox_Ventas_Nabono.Text.Trim() + ")", cnx);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);
                cnx.Close();



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
            textBoxVentas_Direccion.Text = dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
            textBoxVentas_Telefono.Text = dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
            textBoxVentas_Detalle.Text = dataGridView1.CurrentRow.Cells["detalle"].Value.ToString();
            textBoxVentas_Valor.Text = dataGridView1.CurrentRow.Cells["valorObra"].Value.ToString();
            textBoxVentas_Cantidad.Text = dataGridView1.CurrentRow.Cells["cantidad"].Value.ToString();
            textBox_Ventas_Nfactura.Text = dataGridView1.CurrentRow.Cells["NumeroFactura"].Value.ToString();
            textBox1_Borrar.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

        }

        public void EliminarCamposTexbox()
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
            textBox1_Borrar.Clear();
            label30.Text = "";
            label19.Text = "";
            label6.Text = "";
        }





        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxVentas_Nombre.Text))
                {

                }
                else
                {

                    dataGridView1.DataSource = cnx.conexionDBR("select NumeroFactura,NumeroAbono,nombreCliente,cedula,direccion,telefono,Detalle,Vendedor,fechaIngreso,valorObra,anticipoObra,cantidad,FormaPago,fechaAnticipo,id" +
                                                        " from Ventas_Diarias where nombreCliente like '%" + textBoxVentas_Nombre.Text + "%'");
                }
                if (string.IsNullOrEmpty(textBox_Ventas_Nfactura.Text))
                {

                }
                else
                {
                    dataGridView1.DataSource = cnx.conexionDBR("select NumeroFactura,NumeroAbono,nombreCliente,cedula,Direccion,Telefono,Detalle,Vendedor,fechaIngreso,valorObra,anticipoObra,Cantidad,FormaPago,fechaAnticipo,id" +
                                                     " from Ventas_Diarias where NumeroFactura = " + textBox_Ventas_Nfactura.Text + "");

                    ///Este datagrid View esta oculto detras del datagridview1
                    ///Solo se utiliza como ayuda para poder mostrar el valor de restante
                    dataGridView3.DataSource = cnx.conexionDBR("select  NumeroFactura,count(*) as Numero_de_facturas,valorObra,sum(anticipoObra) as abonos, (valorObra-sum(anticipoObra)) as Restante" +
                                                               " from Ventas_Diarias where NumeroFactura = " + textBox_Ventas_Nfactura.Text + " GROUP BY NumeroFactura, valorObra");

                    label6.Text = "" + dataGridView1.Rows.Cast<DataGridViewRow>().Max(x => Convert.ToInt32(x.Cells["valorObra"].Value)).ToString("0,0");
                    label19.Text = "" + dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["anticipoObra"].Value)).ToString("0,0");
                    label30.Text = "" + dataGridView3.Rows.Cast<DataGridViewRow>().Max(x => Convert.ToInt32(x.Cells["Restante"].Value)).ToString("0,0");
                    this.dataGridView1.Columns["valorObra"].Visible = false;

                }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("<<___No se Encontro Registro___>>", "//..ALERTA..//", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        public void BorrarDatos()
        {
            cnx.conexionDBR("delete from ventas_diarias where id = "+textBox1_Borrar.Text+"");
            EliminarCamposTexbox();
            MessageBox.Show("Campo Eliminado Correctamente...");
        }




        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EliminarCamposTexbox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Inicio.Alvidrios Inicio = new AplicationProduccion.Inicio.Alvidrios();
            Inicio.Show();
        }
        #region PROPIEDADES TEXTBOX VENTAS------------------------------------ 

        private void textBoxVentas_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxVentas_Cedula.Focus();
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Letras");
            }
        }
        private void textBoxVentas_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxVentas_Direccion.Focus();
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }

        private void textBoxVentas_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxVentas_Telefono.Focus();
            }
        }
        private void textBoxVentas_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxVentas_Detalle.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }
        private void textBoxVentas_Detalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxVentas_CodigoVendedor.Focus();
            }
        }
        private void textBoxVentas_CodigoVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxVentas_Valor.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }
        private void textBoxVentas_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxVentas_Anticipo.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }
        private void textBoxVentas_Anticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox_Ventas_Nfactura.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }
        private void textBox_Ventas_Nfactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox_Ventas_Nabono.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }
        private void textBox_Ventas_Nabono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxVentas_Cantidad.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }
        private void textBoxVentas_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }
        #endregion

        #endregion

        #region TAG CONTROL DE LOS CONTRATOS METODOS  ....................................////////////////////////////.....................

        public void ingresarContratos(string formaPago, string estado)
        {

            if (String.IsNullOrEmpty(textBoxContratos_nombre.Text) | String.IsNullOrEmpty(textBoxContratos_Cedula.Text) | String.IsNullOrEmpty(textBoxContratos_Direcciones.Text) | String.IsNullOrEmpty(textBoxContratos_Telefonos.Text) | String.IsNullOrEmpty(textBoxContratos_Detalle.Text) | String.IsNullOrEmpty(textBoxContratos_CodigoVendedor.Text) | String.IsNullOrEmpty(dateTimePickerContratos.Text) | String.IsNullOrEmpty(textBoxContratos_Valor.Text) | String.IsNullOrEmpty(textBoxContratos_anticipo.Text) | String.IsNullOrEmpty(textBoxContratos_Cantidad.Text) | String.IsNullOrEmpty(checkBoxContratos_Efectivo.Text) | String.IsNullOrEmpty(checkBoxContratos_Tarjeta.Text))
            {
                MessageBox.Show("Error Faltan Campos Por llenar");
            }
            else
            {


                DataTable dt = new DataTable();
                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                cnx.Open();
                SqlCommand cmd = new SqlCommand("insert into contratos values('" + textBoxContratos_nombre.Text + "', '" + textBoxContratos_Cedula.Text + "', '" + textBoxContratos_Direcciones.Text + "', '" + textBoxContratos_Telefonos.Text + "', '" + textBoxContratos_Detalle.Text + "', " + textBoxContratos_CodigoVendedor.Text + ", '" + dateTimePickerContratos.Text + "', " + textBoxContratos_Valor.Text.Replace(".", "") + ", " + textBoxContratos_anticipo.Text.Replace(".", "") + ", " + textBoxContratos_Cantidad.Text + ", '" + formaPago + "', " + textBoxContratos_NFactura.Text + ", '" + estado + "','" + dateTimePickerContratos.Text + "'," + textBoxContratos_Nabono.Text + "," + textBoxContratos_Consecutivos.Text + ")", cnx);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);
                cnx.Close();


                MessageBox.Show("<<<<Campos Ingresados Correctamente>>>>");

            }

        }

        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            if (checkBoxContratos_Efectivo.Checked == true)
            {
                ingresarContratos("Efectivo", null);
            }
            else if (checkBoxContratos_Tarjeta.Checked == true)
            {
                ingresarContratos("Tarjeta", null);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxContratos_nombre.Text))
            {

            }
            else
            {

                dataGridView2.DataSource = cnx.conexionDBR("select Numero_factura,N_Cosecutivo_Contrato,Numero_anticipo,nombreCliente,cedula,Direccion,Telefono,Detalle,Codigo_Vendedor,fecha_factura,Valor,Anticipo,Cantidad,Modo_de_pago,Estado,fecha_anticipo" +
                                                    " from contratos where nombreCliente like '%" + textBoxContratos_nombre.Text + "%'");
            }
            if (string.IsNullOrEmpty(textBoxContratos_NFactura.Text))
            {

            }
            else
            {
                dataGridView2.DataSource = cnx.conexionDBR("select Numero_factura,N_Cosecutivo_Contrato,Numero_anticipo,nombreCliente,cedula,Direccion,Telefono,Detalle,Codigo_Vendedor,fecha_factura,Valor,Anticipo,Cantidad,Modo_de_pago,Estado,fecha_anticipo" +
                                                 " from contratos where Numero_factura = " + textBoxContratos_NFactura.Text + "");

                ///Este datagrid View esta oculto detras del datagridview1
                ///Solo se utiliza como ayuda para poder mostrar el valor de restante
                dataGridView4.DataSource = cnx.conexionDBR("select  Numero_factura,count(*) as Numero_de_facturas,Valor,sum(Anticipo) as abonos, (valor-sum(Anticipo)) as Restante" +
                                                           " from contratos where Numero_factura = " + textBoxContratos_NFactura.Text + " GROUP BY Numero_factura, Valor");

                label56.Text = "" + dataGridView2.Rows.Cast<DataGridViewRow>().Max(x => Convert.ToInt32(x.Cells["Valor"].Value)).ToString("0,0");
                label57.Text = "" + dataGridView2.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["Anticipo"].Value)).ToString("0,0");
                label58.Text = "" + dataGridView4.Rows.Cast<DataGridViewRow>().Max(x => Convert.ToInt32(x.Cells["Restante"].Value)).ToString("0,0");
                this.dataGridView2.Columns["Valor"].Visible = false;


            }


        }




        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxContratos_nombre.Text = dataGridView2.CurrentRow.Cells["nombreCliente"].Value.ToString();
            textBoxContratos_Cedula.Text = dataGridView2.CurrentRow.Cells["cedula"].Value.ToString();
            textBoxContratos_Direcciones.Text = dataGridView2.CurrentRow.Cells["Direccion"].Value.ToString();
            textBoxContratos_Telefonos.Text = dataGridView2.CurrentRow.Cells["Telefono"].Value.ToString();
            textBoxContratos_Detalle.Text = dataGridView2.CurrentRow.Cells["Detalle"].Value.ToString();
            textBoxContratos_Valor.Text = dataGridView2.CurrentRow.Cells["valorObra"].Value.ToString();
            textBoxContratos_Cantidad.Text = dataGridView2.CurrentRow.Cells["Cantidad"].Value.ToString();
            textBoxContratos_NFactura.Text = dataGridView2.CurrentRow.Cells["NumeroFactura"].Value.ToString();
            textBoxContratos_Consecutivos.Text = dataGridView2.CurrentRow.Cells["N_Cosecutivo_Contrato"].Value.ToString();

        }


        private void button6_Click(object sender, EventArgs e)
        {

            textBoxContratos_nombre.Clear();
            textBoxContratos_Cedula.Clear();
            textBoxContratos_Direcciones.Clear();
            textBoxContratos_Telefonos.Clear();
            textBoxContratos_Detalle.Clear();
            textBoxContratos_CodigoVendedor.Clear();
            textBoxContratos_Valor.Clear();
            textBoxContratos_anticipo.Clear();
            textBoxContratos_Cantidad.Clear();
            textBoxContratos_NFactura.Clear();
            textBoxContratos_Consecutivos.Clear();
            textBoxContratos_Nabono.Clear();
        }

        #region Propiedades de texbox Contratos-------------
        private void textBoxContratos_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxContratos_Cedula.Focus();
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Letras");
            }
        }
        private void textBoxContratos_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxContratos_Direcciones.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }

        private void textBoxContratos_Direcciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxContratos_Telefonos.Focus();
            }
        }

        private void textBoxContratos_Telefonos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxContratos_Detalle.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }
        private void textBoxContratos_Detalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxContratos_CodigoVendedor.Focus();
            }

        }
        private void textBoxContratos_CodigoVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxContratos_Valor.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }


        }
        private void textBoxContratos_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxContratos_anticipo.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }

        private void textBoxContratos_anticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxContratos_NFactura.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }

        private void textBoxContratos_NFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxContratos_Nabono.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }

        private void textBoxContratos_Nabono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxContratos_Consecutivos.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }

        }

        private void textBoxContratos_Consecutivos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxContratos_Cantidad.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }

        private void textBoxContratos_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonRegistar.Focus();
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros");
            }
        }
        #endregion

        #endregion

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void tabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void textBox_Ventas_Nabono_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BorrarDatos();
        }
    }
}