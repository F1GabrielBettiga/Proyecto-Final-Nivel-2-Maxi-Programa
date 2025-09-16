using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int id { get; set; }

        [DisplayName("Cód")]
        public string codigo { get; set; }

        [DisplayName ("Nombre")]
        public string nombre { get; set; }

        [DisplayName("Descripción")]
        public string descripcion { get; set; }

        [DisplayName("Marca")]
        public  Marca marca { get; set; }

        [DisplayName("Categoría")]
        public Categoria categoria { get; set; }
        public string imagenUrl { get; set; }

        [DisplayName("Precio")]
        public decimal precio { get; set; }
    }
}
