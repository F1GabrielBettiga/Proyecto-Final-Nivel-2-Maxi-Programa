using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Articulos
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int idMarca { get; set; }
        public int idcategoria { get; set; }
        public string imagenUrl { get; set; }
        public decimal precio { get; set; }
    }
}
