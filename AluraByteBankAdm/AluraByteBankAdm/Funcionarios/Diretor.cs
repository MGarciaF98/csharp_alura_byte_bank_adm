using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraByteBankAdm.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double getBonificacao()
        {
            return Salario * 1.0 + base.getBonificacao();
        }
        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {

        }
    }
}
