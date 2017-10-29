using System;
using System.Collections.Generic;

namespace Intensivao
{
    class Program
    {
        static void Main(string[] args)
        {            
            Professor p = new Professor(DateTime.Parse("30/09/1988"));            
            p.Disciplina = new Disciplina("Intensivao de CSharp");
            p.Nome = "Thamirys";
            p.Salario = 1000000;
            p.Telefone = "98767-1168";

            Console.WriteLine("A professora " + p.Nome);
            Console.WriteLine("Tem " + p.CalculaIdade() + " anos.\r\n");

            Aluno a = new Aluno(DateTime.Parse("09/05/1985"));            
            a.Nome = "Juliana";            
            a.Nota.Valor = 10;

            Console.WriteLine("A aluna " + a.Nome);
            Console.WriteLine("Tem " + a.CalculaIdade() + " anos.");

            int idadeProfessor = p.CalculaIdade();
            int idadeAluno = a.CalculaIdade();

            if (idadeProfessor > idadeAluno)
            {
                Console.WriteLine("A idade do Professor é maior que a do Aluno");
            }
            else
            {
                Console.WriteLine("A idade do Aluno é maior");
            }



            IList<string> lstNomes = new List<string>();

            lstNomes.Add("Marta");
            lstNomes.Add("Carla");
            lstNomes.Add("Maria");

            foreach (var item in lstNomes)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();





        }
    }
}
