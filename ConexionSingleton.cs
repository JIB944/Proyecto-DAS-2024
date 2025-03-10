using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMinorista.Datos
{
    public class ConexionSingleton
    {
        private static ConexionSingleton _instancia;
        public TiendaContext Contexto { get; private set; }

        private ConexionSingleton()
        {
            var opciones = new DbContextOptionsBuilder<TiendaContext>()
                .UseSqlServer("Server=.;Database=TiendaDB;Trusted_Connection=True;")
                .Options;

            Contexto = new TiendaContext(opciones);
        }

        public static ConexionSingleton Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new ConexionSingleton();
                return _instancia;
            }
        }
    }
}
