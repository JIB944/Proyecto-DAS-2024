using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMinorista.Datos
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        public void AjustarStock(int cantidad)
        {
            Stock += cantidad;
        }

        public void AplicarDescuento(decimal porcentaje)
        {
            Precio -= Precio * porcentaje / 100;
        }
    }

}
