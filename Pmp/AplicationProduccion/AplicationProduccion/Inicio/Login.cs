using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicationProduccion.Inicio
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }






        public void ingreso()
        {
            string usuario = "local01";
            string contraseña = "alvidriosBuga";

            if (textBoxUsuarios.Text == usuario & textBoxContraseña.Text == contraseña)
            {
                MessageBox.Show("Bienvenido al PmP");
                this.Hide();
                AplicationProduccion.Ingresos.DetalleIngreso dingreso = new Ingresos.DetalleIngreso();
                dingreso.Show();
            }
            else
            {
                MessageBox.Show("Error validacion de Credencial");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso();
        }
    }
}
