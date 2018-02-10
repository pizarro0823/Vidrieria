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

namespace AplicationProduccion.Inicio
{
    public partial class Alvidrios : MetroFramework.Forms.MetroForm
    {
        public Alvidrios()
        {
            InitializeComponent();
            testeo();


        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Gastos.Ocompra Ventana_Ingresos = new Gastos.Ocompra();
            Ventana_Ingresos.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Ingresos.Facturador fc = new Ingresos.Facturador();
            fc.Show();

        }

        private void Alvidrios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Prestamos.ConsultaPrestamos prestamos = new Prestamos.ConsultaPrestamos();
            prestamos.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Consultas.Consultar consul = new Consultas.Consultar();
            consul.Show();
        }


        public void testeo()
        {
            try
            {
                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                cnx.Open();
                this.label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#04B404");
                label2.Text = "Exelente";
                cnx.Close();

            }
            catch (Exception)
            {
                this.label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                label2.Text = "Mala";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Ingresos.DetalleIngreso dingreso = new Ingresos.DetalleIngreso();
            dingreso.Show();
        }
    }
}
