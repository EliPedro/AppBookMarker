using System;
using System.Collections.Generic;

namespace BookMarker.Core.Domain.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        void Adicionar(T obj);
        void Remover(T obj);
        void Alterar(T obj);
        T ObterPorId(Guid id);
        IEnumerable<T> ObterTodos();
        void Dispose();

    }
}
