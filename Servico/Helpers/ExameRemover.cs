using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Helpers
{
    public class ExameRemover
    {
        private ExameServico exameServico = new ExameServico();
        private AtendimentoRemover atendimentoRemover = new AtendimentoRemover();

        public void Remover(Exame exame)
        {
            exameServico.ObterAtendimentos(exame);
            
           foreach(var atendimento in exame.AtendimentosExame)
            {
                atendimentoRemover.Remover(atendimento.Atendimento);
            }

            exameServico.Remover(exame.ExameID);
        }
    }
}
