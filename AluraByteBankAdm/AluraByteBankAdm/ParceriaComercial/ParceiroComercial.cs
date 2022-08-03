using AluraByteBankAdm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraByteBankAdm.ParceriaComercial
{
    public class ParceiroComercial : IAutenticavel
    {
        public ParceiroComercial( string login, string senha)
        {
            Senha = senha;
            Login = login;
        }

        public string Senha { get; set; }
        public string Login { get; set; }


        public bool Autenticar(string login, string senha)
        {
            return this.Senha == senha && this.Login == login;
        }
    }
}
