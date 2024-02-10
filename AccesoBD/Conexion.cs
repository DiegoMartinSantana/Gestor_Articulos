using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;

namespace AccesoBD
{
   public class Conexion
    {
        private SqlConnection conexion;
            private SqlCommand comando;
        private SqlDataReader lector;

            public SqlDataReader Lector
        { 
             get { return lector; }
        }

        public Conexion()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS ;database=CATALOGO_DB;integrated security=true");
            comando = new SqlCommand(); 
        }


        public void SetConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void EjecutarLecturas() 
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EjecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CerrarConex()
        {
           if ( lector != null)
            {
                lector.Close();
                conexion.Close();
            }
        }


        public void SetParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);

        }
    }
}
