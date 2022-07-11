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
        public string Cpf { get; set; }
        public double Salario { get; set; }
        private FuncionarioTipo _tipo { get; set; }
        public double getBonificacao()
        {
            switch (_tipo)
            {
                case FuncionarioTipo.funcionario:
                    return Salario * 0.1;
                case FuncionarioTipo.diretor:
                    return Salario * 1.0;
                case FuncionarioTipo.designer:
                    return Salario * 0.1;
                default:
                    return Salario * 0.1;
            }
        }

        public Funcionario(string nome, string cpf, double salario, FuncionarioTipo tipo)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            _tipo = tipo;
        }

    }
}
