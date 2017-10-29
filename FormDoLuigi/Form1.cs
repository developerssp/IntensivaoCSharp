using Intensivao;
using System;
using System.Windows.Forms;

namespace FormDoLuigi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClicar_Click(object sender, EventArgs e)
        {

            string nomeProfessor = txtNome.Text;
            string dataNascimentoProfessor = txtDataNascimento.Text;

            DateTime dtNascimentoProfessor = DateTime.Parse(dataNascimentoProfessor);

            Professor p = new Professor(dtNascimentoProfessor);

            int IdadeProfessor = p.CalculaIdade();

            MessageBox.Show(string.Format("A idade do professor é: {0}",IdadeProfessor.ToString()),
                "Resultado da Idade",MessageBoxButtons.OK,MessageBoxIcon.Information);

            //OBRIGADO a todas

        }
    }
}
