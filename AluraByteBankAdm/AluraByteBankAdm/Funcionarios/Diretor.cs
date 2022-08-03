using AluraByteBankAdm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraByteBankAdm.Funcionarios
{
    public class Diretor : FuncionarioAutenticado
    {


        public Diretor(string nome, string cpf, double salario, string login, string senha) : base(nome, cpf, salario, login,senha)
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
