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
				datos.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl, A.Precio From ARTICULOS A, CATEGORIAS C, MARCAS M Where A.IdCategoria = C.Id and A.IdMarca = M.Id");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{	
					Articulo aux = new Articulo();

					aux.id = (int)datos.Lector["Id"];
					aux.codigo = (string)datos.Lector["Codigo"];
					aux.nombre = (string)datos.Lector["Nombre"];
					aux.descripcion = (string)datos.Lector["Descripcion"];

					aux.marca = new Marca();
					aux.marca.descripcion = (string)datos.Lector["Marca"];

					aux.categoria = new Categoria();
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

	}
}
