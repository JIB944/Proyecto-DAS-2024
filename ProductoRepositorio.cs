namespace TiendaMinorista.Datos
{
    public class ProductoRepositorio : RepositorioGenerico<Producto>
    {
        public ProductoRepositorio(TiendaContext contexto) : base(contexto) { }
    }
}
