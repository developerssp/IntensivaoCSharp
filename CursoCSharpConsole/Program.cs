using SharedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor prof = new Professor();

           bool alunoAprovado =  prof.AprovarAluno("Raquel Dudalina");

            if (alunoAprovado)
            {
                Console.WriteLine("Aluno Aprovado");
            }


        }
    }
}
