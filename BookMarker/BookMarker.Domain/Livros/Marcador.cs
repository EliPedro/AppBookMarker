using BookMarker.Domain.Livros;
using System;

namespace BookMarker.Domain.Marcadores
{
    public class Marcador
    {
        public String MarcadorId { get; set; }
        public Int32 Pagina    { get; set; }
        public Livro Livro     { get; set; }

        public Marcador()
        {
            MarcadorId = Guid.NewGuid().ToString();
        }

        public bool EhValidoNumeroPagina()
        {
            if (Pagina <= 0) return false;
            if (Pagina > Livro.NumeroPaginas) return false;

            return true;
        }
    }
}