using AluraByteBankAdm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraByteBankAdm.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Diretor funcionario, String senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            }
            Console.WriteLine("Senha incorreta");
            return false;
        }
        public bool Logar(GerenteDeContas funcionario, String senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            }
            Console.WriteLine("Senha incorreta");
            return false;
        }
    }
}
