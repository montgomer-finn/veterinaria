using Modelo;
using Servico.ServicosEspecializados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Helpers
{
    public class AtendimentoRemover
    {
        AtendimentoServico atendimentoServico = new AtendimentoServico();
        GenericService<AtendimentoExame> atendimentoExameServico = new GenericService<AtendimentoExame>();
        GenericService<AtendimentoMedicamento> atendimentoMedicamentoServico = new GenericService<AtendimentoMedicamento>();
        ContaReceberRemover contaReceberRemover = new ContaReceberRemover();
        CaixaServico caixaServico = new CaixaServico();

        public void Remover(Atendimento atendimento)
        {
            atendimentoServico.ObterExames(atendimento);
            atendimentoServico.ObterMedicamentos(atendimento);
            atendimentoServico.ObterContasReceber(atendimento);
            atendimentoServico.ObterCaixas(atendimento);

            foreach(var atendimentoExame in atendimento.AtendimentoExames)
            {
                atendimentoExameServico.Remover(atendimentoExame.AtendimentoExameID);
            }

            foreach(var atendimentoMedicamento in atendimento.AtendimentoMedicamentos)
            {
                atendimentoMedicamentoServico.Remover(atendimentoMedicamento.AtendimentoMedicamentoID);
            }

            foreach (var contaReceber in atendimento.ContasReceber)
            {
                contaReceberRemover.Remover(contaReceber);
            }
            
            foreach (var caixa in atendimento.Caixas)
            {
                caixaServico.Remover(caixa.CaixaID);
            }
            
            atendimentoServico.Remover(atendimento.AtendimentoID);
        }
    }
}
