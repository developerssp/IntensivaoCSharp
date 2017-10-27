using SharedCode.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCode
{
    public class Professor : IProfessor
    {
        public Professor()
        {

        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public bool AprovarAluno(string Aluno)
        {
            var listaAlunos = Listas.ListaAlunos();

            foreach (var aluno in listaAlunos)
            {
                if (aluno.Nome == Aluno)
                {
                    if (aluno.Nota > 5.0M)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }



        public bool ReprovarAluno(string Aluno)
        {
            var listaAlunos = Listas.ListaAlunos();

            foreach (var aluno in listaAlunos)
            {
                if (aluno.Nome == Aluno)
                {
                    if (aluno.Nota <= 5.0M)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }


    }
}
