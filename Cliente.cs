using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMinorista.Datos
{
    public class Cliente : Persona
    {
        // Relación uno a muchos: un cliente puede tener varias facturas
        public List<Factura> Facturas { get; set; } = new List<Factura>();
    }

}
