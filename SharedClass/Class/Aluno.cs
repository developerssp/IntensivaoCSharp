

using System;

namespace Intensivao
{
    public class Aluno : Pessoa
    {
        public Aluno(DateTime dataNasc) : base(dataNasc)
        {
            Nota = new Nota();
        }
        public Nota Nota { get; set; }

        public int QtddFaltas { get; set; }

        public void Cadastrar(Aluno aluno)
        {
            int i = 0;
            //this.Nome = nome;
            //this.Idade = idade;
            //this.Telefone = telefone;

        }

        public void Atualizar(Aluno aluno)
        {
            //Nome = aluno.Nome;
            //Idade = aluno.Idade;
            //Telefone = aluno.Telefone;

        }

    }
}