using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCode.Interface
{
    public interface IProfessor
    {
        string Nome { get; set; }
        int Idade { get; set; }
        string Sexo { get; set; }

        bool AprovarAluno();

        bool ReprovarAluno();

    }
}
