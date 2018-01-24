using BookMarker.Domain.Livros;
using System;
using System.Collections.Generic;

namespace BookMarker.Domain.Autores
{
    public class Autor
    {
        public String   AutorId { get;  set; }
        public String Nome    { get; private set; }
        public ICollection<Livro> Livros { get; set; }
        public Autor()
        {
            AutorId = Guid.NewGuid().ToString();
        }     
    }
}