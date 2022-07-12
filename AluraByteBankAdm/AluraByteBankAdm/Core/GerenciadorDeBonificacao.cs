using AluraByteBankAdm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraByteBankAdm.Core
{
    internal class GerenciadorDeBonificacao
    {
        private double totalBonificacao { get; set; }

        public void registrar(Funcionario funcionario) {
            this.totalBonificacao += funcionario.getBonificacao();
        }

        public double getBonificacao()
        {
            return totalBonificacao;
        }
    }
}
