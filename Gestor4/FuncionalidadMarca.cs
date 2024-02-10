using AccesoBD;
using Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Gestor4
{
    public class FuncionalidadMarca
    {
        public List<Marca> ListaMarca()
        {
            List<Marca> lista = new List<Marca>();
            Conexion datos = new Conexion();

            try
            {

                datos.SetConsulta("Select Id , Descripcion from MARCAS");

                datos.EjecutarLecturas();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConex();
            }

        }
    }
}
