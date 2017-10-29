
using System;

namespace Intensivao
{
    public class Professor : Pessoa
    {
        public Professor(DateTime dataNasc) : base(dataNasc)
        {
        }

        public decimal Salario { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
