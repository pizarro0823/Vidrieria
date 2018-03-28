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
        }

        AplicationProduccion.Clases.Conexion cnx = new Clases.Conexion();



        public void ConsultarInventario()
        {
            //try
            //{


                if (textBoxMedida.Text.Contains("6") | textBoxMedida.Text.Contains("6.00"))
                {

                    dataGridView1.DataSource = cnx.conexionDBR("SELECT Nombre_Interno,Valor as P_iGSo,(Valor*20/100) as V_G,sum((Valor*20/100)+Valor) as valor_Tira_Vidriero,sum((Valor*30/100)+Valor) as valor_Tira_Publico " +
                                                                            " from Precios_Alumnio where Nombre_Interno like '%" + textBoxIngresarBusqueda.Text + "%' " +
                                                                            "GROUP BY Nombre_Interno, Valor");
                }
                else
                {
                    dataGridView1.DataSource = cnx.conexionDBR("select Nombre_Interno,Valor as P_iGSo, (Valor*20/100) as V_G, sum((Valor*20/100)+Valor) as valor_Tira_Vidriero,sum((Valor*30/100)+Valor) as valor_Tira_Publico,sum((Valor*20/100)+Valor)/5 * " + textBoxMedida.Text + " as Valor_Metros_Vidriero" +
                                                                        " from Precios_Alumnio where Nombre_Interno like '%" + textBoxIngresarBusqueda.Text + "%' " +
                                                                        "GROUP BY Nombre_Interno, Valor");

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Inicio.Alvidrios inicio = new Inicio.Alvidrios();
            inicio.Show();
        }


    }
}
