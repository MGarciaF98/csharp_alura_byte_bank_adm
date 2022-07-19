using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraByteBankAdm.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public virtual double getBonificacao()
        {
            return Salario*0.1;
        }

        public static int TotalFuncionario { get; private set; }


        public Funcionario(string nome, string cpf, double salario)
        {
            Console.WriteLine("Criando um funcionário");
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionario++;
        }

        public virtual void aumentarSalario()
        {
            Salario= Salario*1.1;
        }

    }
}
