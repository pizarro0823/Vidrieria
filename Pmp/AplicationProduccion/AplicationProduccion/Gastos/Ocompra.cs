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
    public partial class Ocompra : MetroFramework.Forms.MetroForm
    {
        public Ocompra()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            llenarCombobox();
            comboBoxClasificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRaiz.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        AplicationProduccion.Clases.Conexion cnx = new Clases.Conexion();



        public void IngresosCompras()
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxAlmacen.Text) | String.IsNullOrEmpty(textBoxNit.Text) | String.IsNullOrEmpty(comboBoxRaiz.Text) | String.IsNullOrEmpty(textBoxDescripcion.Text) | String.IsNullOrEmpty(textBoxValor.Text) | String.IsNullOrEmpty(textBoxCantidad.Text)| String.IsNullOrEmpty(comboBoxClasificacion.Text)| String.IsNullOrEmpty(comboBoxEstado.Text))
                {
                    MessageBox.Show("Faltan Campos por Seleccionar", "//..ALERTA..//", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                }
                else
                {
                    cnx.conexionDB("insert into compras values ('" + textBoxNoFactura.Text.ToUpper().Trim() + "','" + textBoxAlmacen.Text.ToUpper().Trim() + "','" + textBoxNit.Text.ToUpper() + "','" + textBoxDescripcion.Text.ToUpper().Trim() + "'," + textBoxCantidad.Text.Trim() + "," + textBoxValor.Text.Trim().Replace(".", "") + ",'"+dateTimePicker.Text+"','" + comboBoxRaiz.Text.Trim() + "','"+comboBoxClasificacion.Text.Trim()+"','"+comboBoxEstado.Text.Trim()+"')");
                    MessageBox.Show("Campos Ingresados Correctamente");
                    dataGridView1.DataSource = cnx.conexionDBR("select  Nombre_Almacen, Nit_Empresa, Descripcion_Mercancia, cantidad_ingreso, REPLACE(CONVERT(VARCHAR, CONVERT(Money, valor_unitario), 1), '.00', '') as Valor, fecha_ingreso,Raiz,clasificacion,estado from compras where fecha_ingreso ='"+dateTimePicker.Text+"' ");

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresosCompras();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOrdenNueva.Checked == true)
            {
                checkBoxFConsecutiva.Checked = false;

                textBoxNoFactura.Clear();
                textBoxAlmacen.Clear();
                textBoxNit.Clear();
                textBoxDescripcion.Clear();
                textBoxCantidad.Clear();
                textBoxCantidad.Clear();
                textBoxValor.Clear();
                comboBoxClasificacion.SelectedIndex = -1;
                comboBoxEstado.SelectedIndex = -1;
                comboBoxRaiz.SelectedIndex = -1;
                

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFConsecutiva.Checked == true)
            {
                checkBoxOrdenNueva.Checked = false;
                textBoxDescripcion.Clear();
                textBoxCantidad.Clear();
                textBoxValor.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AplicationProduccion.Inicio.Alvidrios inicio = new Inicio.Alvidrios();
            inicio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cnx.conexionDBR("select Nombre_Almacen,Nit_Empresa,cantidad_ingreso,Raiz,clasificacion,Estado from compras where Nombre_Almacen like '%"+textBoxAlmacen.Text+"%'");
        }

        public void llenarCombobox()
        {
            ///////////////////Raiz//////////////////////

            comboBoxRaiz.Items.Add("Motocicletas");
            comboBoxRaiz.Items.Add("Compra De Material");
            comboBoxRaiz.Items.Add("Reparacion de Maquinaria");
            comboBoxRaiz.Items.Add("Cafeteria");
            comboBoxRaiz.Items.Add("Otros...");
            comboBoxRaiz.Items.Add("Implementos Aseo");
            comboBoxRaiz.Items.Add("Almuerzos");
            comboBoxRaiz.Items.Add("Papeleria");

            ////////////////////clasificacion//////////////////////

            comboBoxClasificacion.Items.Add("Regimen Comun");
            comboBoxClasificacion.Items.Add("Regimen Simplificado");
            comboBoxClasificacion.Items.Add("Sin Especificar");

            /////////////////////Estado//////////////////////////////

            comboBoxEstado.Items.Add("POR PAGAR");
            comboBoxEstado.Items.Add("CANCELADO");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ocompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAlmacen.Text = dataGridView1.CurrentRow.Cells["Nombre_Almacen"].Value.ToString();
            textBoxNit.Text = dataGridView1.CurrentRow.Cells["Nit_Empresa"].Value.ToString();
            comboBoxClasificacion.Text = dataGridView1.CurrentRow.Cells["clasificacion"].Value.ToString();
            comboBoxRaiz.Text= dataGridView1.CurrentRow.Cells["Raiz"].Value.ToString();
            comboBoxEstado.Text= dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
            textBoxCantidad.Text = dataGridView1.CurrentRow.Cells["cantidad_ingreso"].Value.ToString();
        }
    }
}
