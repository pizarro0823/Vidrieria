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


        public void consulta()
        {
            if (checkBoxDetallado.Checked == true)
            {
                dataGridView1.DataSource = cnx.conexionDBR("select nombreCliente,cedula,Direccion,Telefono,Detalle,Codigo_Vendedor,Fecha_Factura,Numero_factura,Fecha_Anticipo,Numero_anticipo,Valor,Anticipo,Modo_de_pago from Ventas_Diarias");
            }
            else if (checkBoxFiltrado_Especial.Checked == true )
            {
                dataGridView1.DataSource = cnx.conexionDBR("select  Numero_factura,nombreCliente,count(*) as Numero_de_facturas,Valor,sum(Anticipo) as abonos, (valor-sum(Anticipo)) as Restante from Ventas_Diarias GROUP BY Numero_factura, Valor, nombreCliente");
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

 
    }
}
