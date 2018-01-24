using BookMarker.Domain.Livros;
using BookMarker.Domain.Livros.Repository;

namespace BookMarker.Infra.Data.Repositories
{
    public class RepositoryLivro : RepositoryBase<Livro>,IRepositoryLivro
    {
    }
}
