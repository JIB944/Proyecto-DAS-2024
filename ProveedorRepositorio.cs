namespace TiendaMinorista.Datos
{
    public class ProveedorRepositorio : RepositorioGenerico<Proveedor>
    {
        public ProveedorRepositorio(TiendaContext contexto) : base(contexto) { }
    }
}
