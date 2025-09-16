using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {

		public List<Articulo> listarTodosLosArticulos()
		{ 
			List<Articulo> lista = new List<Articulo>();
			AccesoDatos datos = new AccesoDatos();

			try 
			{
				datos.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl, A.Precio,C.Id IdCategoria, M.Id IdMarca From ARTICULOS A, CATEGORIAS C, MARCAS M  Where A.IdCategoria = C.Id and A.IdMarca = M.Id");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{	
					Articulo aux = new Articulo();

					aux.id = (int)datos.Lector["Id"];
					aux.codigo = (string)datos.Lector["Codigo"];
					aux.nombre = (string)datos.Lector["Nombre"];
					aux.descripcion = (string)datos.Lector["Descripcion"];

					aux.marca = new Marca();
					aux.marca.id = (int)datos.Lector["IdMarca"];
                    aux.marca.descripcion = (string)datos.Lector["Marca"];

					aux.categoria = new Categoria();
					aux.categoria.id = (int)datos.Lector["IdCategoria"];
                    aux.categoria.descripcion = (string)datos.Lector["Categoria"];

					if (!(datos.Lector["ImagenUrl"] is DBNull))
					{
						aux.imagenUrl = (string)datos.Lector["ImagenUrl"];
					}

                    aux.precio = (decimal)datos.Lector["Precio"];

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
				datos.Lector.Close();
            }





        }

		public void agregarArticulo (Articulo artNuevo)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
				datos.setearParametro ("@Codigo", artNuevo.codigo);
				datos.setearParametro("@Nombre", artNuevo.nombre);
				datos.setearParametro("@Descripcion", artNuevo.descripcion);
				datos.setearParametro("@IdMarca", artNuevo.marca.id);
				datos.setearParametro("@IdCategoria", artNuevo.categoria.id);
				datos.setearParametro("@ImagenUrl", artNuevo.imagenUrl);
				datos.setearParametro("@Precio", artNuevo.precio);
				datos.ejecutarAccion();

            }
			catch (Exception ex)
			{
				throw ex;
			}
            finally
			{
				datos.cerrarConexion();
			}





        }
	}
}
