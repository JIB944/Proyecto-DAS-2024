namespace TiendaMinorista.Datos
{
    public class ClienteRepositorio : RepositorioGenerico<Cliente>
    {
        public ClienteRepositorio(TiendaContext contexto) : base(contexto) { }
    }
}

