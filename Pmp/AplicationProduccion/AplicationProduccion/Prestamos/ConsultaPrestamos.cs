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
    public partial class ConsultaPrestamos : MetroFramework.Forms.MetroForm
    {
        public ConsultaPrestamos()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Prestamos.Prestamos Represtamo = new Prestamos();
            Represtamo.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Prestamos.Abonos ab = new Abonos();
            ab.Show();
        }
    }
}
