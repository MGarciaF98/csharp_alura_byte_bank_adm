using AluraByteBankAdm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraByteBankAdm.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public Autenticavel(string nome, string cpf, double salario,  string login, string senha) : base(nome, cpf, salario)
        {
            Senha = senha;
            Login = login;
        }

        public string Login { get; set; }
        public string Senha { get; set; }

        public bool Autenticar(string senha, string login)
        {
            return this.Senha == senha && this.Login == login;
        }
    }
}
