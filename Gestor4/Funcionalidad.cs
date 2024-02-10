using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Producto;
using AccesoBD;
using System.Xml.Linq;
using System.Data.SqlTypes;
using System.Net.Configuration;
using System.Windows.Forms;
using System.Collections;

namespace Gestor4
{
    public class Funcionalidad
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS ;database=CATALOGO_DB;integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select  A.Id Idar, A.Codigo, Nombre, A.Descripcion ArtDesc, IdMarca  ,IdCategoria , ImagenURL ,Precio, C.Descripcion Catdesc , M.Descripcion Marcadesc From ARTICULOS A , CATEGORIAS C , MARCAS M Where A.IdMarca = M.Id and C.Id = IdCategoria";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["IdAr"];
                    aux.Codigoarticulo = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["ArtDesc"];
                    aux.Imagen = (string)lector["ImagenURL"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Catdesc"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marcadesc"];
                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Eliminar(int id)
        {
            Conexion datos = new Conexion();
            try
            {
                datos.SetConsulta("Delete from ARTICULOS where Id = @Id");
                datos.SetParametro("Id", id);
                datos.EjecutarAccion();
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

        public void Agregar(Articulo nuevo)
        {
            Conexion datos = new Conexion();

            try
            {
                datos.SetConsulta("Insert into ARTICULOS (  Nombre ,Descripcion, Precio, IdMarca , IdCategoria , ImagenURL )  values ( @nombre , @descripcion , @precio ,@idMarca , @idCategoria , @imagenURl )");
                datos.SetParametro("@nombre", nuevo.Nombre);
                datos.SetParametro("@descripcion", nuevo.Descripcion);
                datos.SetParametro("@precio", nuevo.Precio);
                datos.SetParametro("@idMarca", nuevo.Marca.Id);
                datos.SetParametro("@idCategoria", nuevo.Categoria.Id);
                datos.SetParametro("@imagenURL", nuevo.Imagen);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                datos.CerrarConex();
            }
        }
        public void Modificar(Articulo modificable)
        {
            Conexion conex = new Conexion();
            try
            {
                conex.SetConsulta("Update ARTICULOS set Nombre = @nombre , Descripcion  = @descripcion  , IdMarca = @idmarca , IdCategoria = @idcategoria , ImagenUrl = @imagenUrl , Precio = @precio  WHERE Id = @Id ");
                conex.SetParametro("@nombre", modificable.Nombre);
                conex.SetParametro("@descripcion", modificable.Descripcion);
                conex.SetParametro("@idmarca", modificable.Marca.Id);
                conex.SetParametro("idcategoria", modificable.Categoria.Id);
                conex.SetParametro("@imagenUrl", modificable.Imagen);
                conex.SetParametro("@precio", modificable.Precio);
                conex.SetParametro("@id", modificable.Id);
                conex.EjecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conex.CerrarConex();
            }

        }
        public List <Articulo> BusquedaAvanzada(string campo, string criterio , string Contenido)
        {
            Conexion conex = new Conexion();
            List<Articulo> filtro = new List<Articulo>();
            try
            {
                string consulta = "Select  A.Id Idar, A.Codigo, Nombre, A.Descripcion ArtDesc, IdMarca  ,IdCategoria , ImagenURL ,Precio, C.Descripcion Catdesc , M.Descripcion Marcadesc From ARTICULOS A , CATEGORIAS C , MARCAS M Where A.IdMarca = M.Id and C.Id = IdCategoria and ";
                if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Inícia con ":
                            consulta += "Nombre like '" + Contenido + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Nombre  like '%" + Contenido + "'";
                            break;
                        default:
                            consulta += "Nombre like '%" + Contenido + "%'";
                            break;

                    }
                }
                else if (campo == "Descripcion")
                {
                    switch (criterio)
                    {
                        case "Inícia con ":
                            consulta += "A.Descripcion like '" + Contenido + "%' ";
                            break;
                        case "Termina con":
                            consulta += "A.Descripcion  like '%" + Contenido + "'";
                            break;
                        default:
                            consulta += "A.Descripcion like '%" + Contenido + "%'";
                            break;

                    }
                }
                else if (campo == "Categoria")
                {
                    switch (criterio)
                    {
                        case "Inícia con ":
                            consulta += "C.Descripcion like '" + Contenido + "%' ";
                            break;
                        case "Termina con":
                            consulta += "C.Descripcion  like '%" + Contenido + "'";
                            break;
                        default:
                            consulta += "C.Descripcion like '%" + Contenido + "%'";
                            break;
                    }
                }

                else if (campo == "Precio")
                {
                    switch (criterio)
                    {

                        case "Menor a":
                            consulta += "Precio < " + Contenido;
                            break;
                        case "Mayor a":
                            consulta += "Precio > " + Contenido;
                            break;
                        default:
                            consulta += "Precio = " + Contenido;
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Inícia con ":
                            consulta += "M.Descripcion like '" + Contenido + "%' ";
                            break;
                        case "Termina con":
                            consulta += "M.Descripcion  like '%" + Contenido + "'";
                            break;
                        default:
                            consulta += "M.Descripcion like '%" + Contenido + "%'";
                            break;
                    }
                }

                    conex.SetConsulta(consulta);
                    conex.EjecutarLecturas();
                    while (conex.Lector.Read())
                    {
                        Articulo aux = new Articulo();
                        aux.Id = (int)conex.Lector["IdAr"];
                        aux.Codigoarticulo = conex.Lector.GetInt32(0);
                        aux.Nombre = (string)conex.Lector["Nombre"];
                        aux.Descripcion = (string)conex.Lector["ArtDesc"];
                        aux.Imagen = (string)conex.Lector["ImagenURL"];
                        aux.Precio = (decimal)conex.Lector["Precio"];
                        aux.Categoria = new Categoria();
                        aux.Categoria.Id = (int)conex.Lector["IdCategoria"];
                        aux.Categoria.Descripcion = (string)conex.Lector["Catdesc"];
                        aux.Marca = new Marca();
                        aux.Marca.Id = (int)conex.Lector["IdMarca"];
                        aux.Marca.Descripcion = (string)conex.Lector["Marcadesc"];

                        filtro.Add(aux);
                    }
                    return filtro;
                }
            
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conex.CerrarConex();
            }
        }
    }
}

