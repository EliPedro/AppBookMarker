using BookMarker.Domain.Autores;
using BookMarker.Domain.Leitores;
using System;
using System.Collections.Generic;

namespace BookMarker.Domain.Livros
{
    public class Livro
    {
        public String   LivroId               { get; set; }
        public String Nome                  { get; set; }
        public String Descricao             { get; set; }
        public Int32  NumeroPaginas         { get; set; }
        public ICollection<Autor> Autores   { get; set; }
        public ICollection<Leitor> Leitores { get; set; }
        
        public Livro()
        {
            LivroId = Guid.NewGuid().ToString();
        }
    }
}