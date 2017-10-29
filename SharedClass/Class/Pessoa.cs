using System;

namespace Intensivao
{
    public class Pessoa
    {
        public Pessoa(DateTime dataNasc)
        {
            DataNascimento = dataNasc;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

        public int CalculaIdade()
        {
 

            return DateTime.Now.Year - DataNascimento.Year;
        }
    }
}
