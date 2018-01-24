using BookMarker.Domain.Leitores.Validation;
using BookMarker.Domain.Leitores.ValueObject;
using BookMarker.Domain.Livros;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BookMarker.Domain.Leitores
{
    public class Leitor
    {
        public String               LeitorId { get; set; }
        public String             Nome     { get; set; }
        public Boolean            Ativo    { get; set; }
        public Email              Email    { get; set; }
        public Cpf                Cpf      { get; set; }
        public Endereco           Endereco { get; set; }
        public ICollection<Livro> Livros   { get; set; }


        public Leitor()
        {
            LeitorId = Guid.NewGuid().ToString();
        }
        
        public void Ativar()
        {
            Ativo = true;
        }

        public void Inativar()
        {
            Ativo = false;
        }
    }
}