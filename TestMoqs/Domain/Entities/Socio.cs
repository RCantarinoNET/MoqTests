using System;

namespace TestMoqs.Domain.Entities
{
    public class Socio
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Limite { get; set; }
        public int Idade { get; set; }
    }
}