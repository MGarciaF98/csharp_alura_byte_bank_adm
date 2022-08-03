using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraByteBankAdm.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }


        public Funcionario(string nome, string cpf, double salario)
        {
            Console.WriteLine("Criando um funcionário");
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionario++;
        }


        /// <summary>
        /// Métodos virtuais permitem que a classe pai forneça corpo padrão para o método
        /// Métodos abstratos não permitem. Obriga as classes herdadas a implementar o método.
        /// </summary>
        /// <returns></returns>
        public virtual double getBonificacao()
        {
            return Salario*0.1;
        }

         public abstract void aumentarSalario();

        public static int TotalFuncionario { get; private set; }

       

    }
}
