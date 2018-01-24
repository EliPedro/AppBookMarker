using BookMarker.Core.Domain.Repository;
using System;
using System.Collections.Generic;

namespace BookMarker.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        public void Adicionar(T obj)
        {
            throw new NotImplementedException();
        }

        public void Alterar(T obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
