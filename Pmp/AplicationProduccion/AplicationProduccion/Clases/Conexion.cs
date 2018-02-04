using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicationProduccion.Clases
{
    class Conexion
    {
        public DataTable conexionDBR(string sentenciaR)
        {
            
                DataTable dt = new DataTable();
                SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                cnx.Open();
                SqlCommand cmd = new SqlCommand(sentenciaR, cnx);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);
                cnx.Close();
           
            

            return dt;

        }

        public void conexionDB(string sentencia)
        {
            DataTable dt = new DataTable();
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            cnx.Open();
            SqlCommand cmd = new SqlCommand(sentencia, cnx);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            cnx.Close();


        }


     

    }
}
