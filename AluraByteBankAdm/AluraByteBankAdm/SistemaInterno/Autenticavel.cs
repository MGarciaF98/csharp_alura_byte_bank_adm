using AluraByteBankAdm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraByteBankAdm.SistemaInterno
{
    public interface Autenticavel
    {
        public bool Autenticar(string senha, string login);
    }
}
