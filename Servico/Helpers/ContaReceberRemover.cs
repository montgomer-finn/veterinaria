using Modelo;
using Servico.ServicosEspecializados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Helpers
{
    public class ContaReceberRemover
    {
        private CaixaServico caixaServico = new CaixaServico();
        private ContaReceberServico contaReceberServico = new ContaReceberServico();

        public void Remover(ContaReceber contaReceber)
        {
            contaReceberServico.ObterCaixas(contaReceber);
            foreach(var caixa in contaReceber.Caixas)
            {
                caixaServico.Remover(caixa.CaixaID);
            }
            contaReceberServico.Remover(contaReceber.ContaReceberID);
        }
    }
}
