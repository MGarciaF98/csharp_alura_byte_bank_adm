using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraByteBankAdm.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string nome, string cpf) : base(nome, cpf, 3000)
        {
            Console.WriteLine("Criando um diretor");
        }

        public override double getBonificacao()
        {
            return Salario * 1.0 + base.getBonificacao();
        }

        public override void aumentarSalario()
        {
            Salario = Salario*1.2;
        }
    }
}
