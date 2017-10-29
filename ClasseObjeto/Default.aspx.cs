using ClasseObjeto.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClasseObjeto
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void ExemploClasse() {
            Aluno aluno = new Aluno();
            aluno.Nome = "Marta";
            aluno.Idade = 23;
            aluno.Telefone = "2345-6778";

            Nota nota = new Nota();

            nota.Valor = 6.5;


            Disciplina disciplina = new Disciplina();

            disciplina.Nome = "Matematica";

            aluno.Cadastrar(aluno);




             

        }

    }
}