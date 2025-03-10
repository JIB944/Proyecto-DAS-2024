using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMinorista.Datos
{
    public class Categoria
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Relación uno a muchos: una categoría tiene varios productos
        public List<Producto> Productos { get; set; } = new List<Producto>();
    }

}
