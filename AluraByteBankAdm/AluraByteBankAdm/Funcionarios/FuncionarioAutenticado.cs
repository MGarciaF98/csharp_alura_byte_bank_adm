using AluraByteBankAdm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraByteBankAdm.Funcionarios
{
    public abstract class FuncionarioAutenticado : Funcionario, Autenticavel
    {

        public string Senha { get; set; }
        public string Login { get; set; }


        protected FuncionarioAutenticado(string nome, string cpf, double salario, string login ,string senha) : base(nome, cpf, salario)
        {
            Senha = senha;
            Login = login;
        }

        public bool Autenticar(string login, string senha)
        {
            
            return this.Senha == senha && this.Login == login;
        }
    }
}
