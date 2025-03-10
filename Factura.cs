using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMinorista.Datos
{
    public class Factura
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        // Relación uno a muchos: una factura tiene varios detalles
        public List<DetalleFactura> DetallesFactura { get; set; } = new List<DetalleFactura>();
    }

}
