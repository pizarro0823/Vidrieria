using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace AplicationProduccion.Consultas
{
    public partial class Consultar : MetroFramework.Forms.MetroForm
    {
        public Consultar()
        {
            InitializeComponent();
            groupBox1.Visible = false;
           
        }

        AplicationProduccion.Clases.Conexion cnx = new Clases.Conexion();



        public void ConsultarInventario()
        {
            //try
            //{


                if (textBoxMedida.Text.Contains("6") | textBoxMedida.Text.Contains("6.00"))
                {

                    dataGridView1.DataSource = cnx.conexionDBR("SELECT nombreArticulo,(precio_ingreso*20/100) as V_G,sum((precio_ingreso*20/100)+precio_ingreso) as valor_Tira_Vidriero,sum((precio_ingreso*30/100)+precio_ingreso) as valor_Tira_Publico " +
                                                                            "from precios_vidrieria where nombreArticulo like '%" + textBoxIngresarBusqueda.Text + "%' " +
                                                                            " GROUP BY nombreArticulo, precio_ingreso");
                }
                else
                {
                    dataGridView1.DataSource = cnx.conexionDBR("select nombreArticulo, precio_ingreso,(precio_ingreso*20/100) as V_G, sum((precio_ingreso*20/100)+precio_ingreso) as valor_Tira_Vidriero,sum((precio_ingreso*30/100)+precio_ingreso) as valor_Tira_Publico,sum((precio_ingreso*20/100)+precio_ingreso)/5 * " + textBoxMedida.Text + " as Valor_Metros_Vidriero,sum((precio_ingreso*30/100)+precio_ingreso)/5 * " + textBoxMedida.Text + " as Valor_Metros_Publico " +
                                                                        "from precios_vidrieria where nombreArticulo like '%" + textBoxIngresarBusqueda.Text + "%' " +
                                                                        " GROUP BY nombreArticulo, precio_ingreso");

                this.dataGridView1.Columns["precio_ingreso"].Visible = false;
                this.dataGridView1.Columns["valor_Tira_Vidriero"].Visible = false;
                this.dataGridView1.Columns["valor_Tira_Publico"].Visible = false;

            }



          
            dataGridView1.RowHeadersWidth = 100;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AllowUserToAddRows = false;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error Validacion De Datos...");
            //}
        }

        private void metroButtonBuscar_Click(object sender, EventArgs e)
        {
            ConsultarInventario();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                groupBox1.Visible = true;
            }
            else           {
                groupBox1.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Inicio.Alvidrios inicio = new Inicio.Alvidrios();
            inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
