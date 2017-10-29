using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClasseObjeto.Class
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }

        public void Cadastrar(Aluno aluno)
        {
            //this.Nome = nome;
            //this.Idade = idade;
            //this.Telefone = telefone;

        }

        public void Atualizar(Aluno aluno)
        {
            Nome = aluno.Nome;
            Idade = aluno.Idade;
            Telefone = aluno.Telefone;

        }

    }
}