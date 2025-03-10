using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TiendaMinorista.Datos
{
    public class Proveedor : Persona
    {
        // Relación uno a muchos: un proveedor puede suministrar varios productos
        public List<Producto> Productos { get; set; } = new List<Producto>();
    }

}
