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
        public string Nome { get ; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public bool AprovarAluno()
        {
            throw new NotImplementedException();
        }

        public bool ReprovarAluno()
        {
            throw new NotImplementedException();
        }
    }
}
