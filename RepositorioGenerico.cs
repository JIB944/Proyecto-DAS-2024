using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TiendaMinorista.Datos
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        private readonly TiendaContext _contexto;
        private readonly DbSet<T> _dbSet;

        public RepositorioGenerico(TiendaContext contexto)
        {
            _contexto = contexto;
            _dbSet = contexto.Set<T>();
        }

        public void Agregar(T entidad)
        {
            _dbSet.Add(entidad);
            _contexto.SaveChanges();
        }

        public void Actualizar(T entidad)
        {
            _dbSet.Update(entidad);
            _contexto.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var entidad = ObtenerPorId(id);
            if (entidad != null)
            {
                _dbSet.Remove(entidad);
                _contexto.SaveChanges();
            }
        }

        public T ObtenerPorId(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> ObtenerTodos()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<T> Buscar(Expression<Func<T, bool>> filtro)
        {
            return _dbSet.Where(filtro).ToList();
        }
    }
}
