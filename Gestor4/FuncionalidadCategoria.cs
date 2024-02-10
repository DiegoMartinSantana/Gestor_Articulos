using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoBD;
using Producto;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Data;

namespace Gestor4
{

	public class FuncionalidadCategoria
	{
		public List<Categoria> listarcat()
		{
			List<Categoria> lista = new List<Categoria>();
			Conexion datos = new Conexion();

			try
			{

				datos.SetConsulta("Select Id , Descripcion from CATEGORIAS");

				datos.EjecutarLecturas();
				while (datos.Lector.Read())
				{
					Categoria aux = new Categoria();
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
    

