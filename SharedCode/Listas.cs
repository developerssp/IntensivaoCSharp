using SharedCode.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCode
{
    public static class Listas
    {
        public static List<Professor> ListaProfessores()
        {
            return new List<Professor>()
            {
                new Professor(){Nome = "Luigi Tavolaro",Idade = 34, Sexo = "M"},
                new Professor(){Nome = "Alessandra Soares",Idade = 18, Sexo = "F"},
                new Professor(){Nome = "Thamirys Gameiro",Idade = 18, Sexo = "F"}
            };
        }
        public static List<Aluno> ListaAlunos()
        {
            return new List<Aluno>()
            {
                new Aluno(){Nome = "Mario das Dores",Idade = 20, Sexo = "M",Nota=9.2M},
                new Aluno(){Nome = "Raquel Dudalina",Idade = 21, Sexo = "F",Nota=3.4M},
                new Aluno(){Nome = "Rafael Quintanha",Idade = 19, Sexo = "M",Nota=5.7M}
            };
        }
    }
}
