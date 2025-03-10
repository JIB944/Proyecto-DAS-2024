using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TiendaMinorista.Datos
{
    public interface IRepositorioGenerico<T> where T : class
    {
        void Agregar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(int id);
        T ObtenerPorId(int id);
        IEnumerable<T> ObtenerTodos();
        IEnumerable<T> Buscar(Expression<Func<T, bool>> filtro);
    }
}

