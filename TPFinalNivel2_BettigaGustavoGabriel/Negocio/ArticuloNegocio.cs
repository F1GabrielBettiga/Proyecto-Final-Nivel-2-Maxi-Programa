using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.IO;

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

		public void agregarArticulo(Articulo artNuevo)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
				datos.setearParametro("@Codigo", artNuevo.codigo);
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


		public void eliminarArticulo(Articulo art)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("Delete from ARTICULOS where Id = @Id");
				datos.setearParametro("@Id", art.id);
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

		public void modificarArticulo(Articulo art)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("Update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id");
				datos.setearParametro("@Codigo", art.codigo);
				datos.setearParametro("@Nombre", art.nombre);
				datos.setearParametro("@Descripcion", art.descripcion);
				datos.setearParametro("@IdMarca", art.marca.id);
				datos.setearParametro("@IdCategoria", art.categoria.id);
				datos.setearParametro("@ImagenUrl", art.imagenUrl);
				datos.setearParametro("@Precio", art.precio);
				datos.setearParametro("@Id", art.id);
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

		public List<Articulo> filtrarArticulos(string campo, string criterio, string filtro)
		{
			List<Articulo> lista = new List<Articulo>();
			AccesoDatos datos = new AccesoDatos();

			string consulta = "SELECT A.Id,A.Codigo,A.Nombre,A.Descripcion,A.ImagenUrl,A.Precio,M.Descripcion AS Marca,C.Descripcion AS Categoria,C.Id AS IdCategoria,M.Id AS IdMarca FROM ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdCategoria = C.Id AND A.IdMarca = M.Id AND ";
           
			try
			{
				switch (campo)
				{
					case "Nombre":
						switch (criterio)
						{
							case "Comienza con":
								consulta += "A.Nombre LIKE '" + filtro + "%' ";
								break;
							case "Termina con":
								consulta += "A.Nombre LIKE '%" + filtro + "' ";
								break;
							case "Contiene":
								consulta += "A.Nombre LIKE '%" + filtro + "%' ";
								break;
						}
						break;
                    case "Cód Articulo":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "A.Codigo LIKE '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "A.Codigo LIKE '%" + filtro + "' ";
                                break;
                            case "Contiene":
                                consulta += "A.Codigo LIKE '%" + filtro + "%' ";
                                break;
                        }
                        break;
                    case "Descripción":
						switch (criterio)
						{
							case "Comienza con":
								consulta += "A.Descripcion LIKE '" + filtro + "%' ";
								break;
							case "Termina con":
								consulta += "A.Descripcion LIKE '%" + filtro + "' ";
								break;
							case "Contiene":
								consulta += "A.Descripcion LIKE '%" + filtro + "%' ";
								break;
						}
						break;
                    case "Marca":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "M.Descripcion LIKE '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "M.Descripcion LIKE '%" + filtro + "' ";
                                break;
                            case "Contiene":
                                consulta += "M.Descripcion LIKE '%" + filtro + "%' ";
                                break;
                        }
                        break;
                    case "Categoría":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "C.Descripcion LIKE '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "C.Descripcion LIKE '%" + filtro + "' ";
                                break;
                            case "Contiene":
                                consulta += "C.Descripcion LIKE '%" + filtro + "%' ";
                                break;
                        }
                        break;
                    case "Precio":
						switch (criterio)
						{
							case "Mayor a":
								consulta += "A.Precio > " + filtro + " ";
								break;
							case "Menor a":
								consulta += "A.Precio < " + filtro + " ";
								break;
							case "Igual a":
								consulta += "A.Precio = " + filtro + " ";
								break;
						}
						break;
					}
				datos.setearConsulta(consulta);
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
			
		}

    }
}
