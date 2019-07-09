using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Helpers
{
    public class MedicamentoRemover
    {
        MedicamentoServico medicamentoServico = new MedicamentoServico();
        GenericService<AtendimentoMedicamento> atendimentoMedicamentoServico = new GenericService<AtendimentoMedicamento>();
        private AtendimentoRemover atendimentoRemover = new AtendimentoRemover();

        public void Remover(Medicamento medicamento)
        {
            medicamentoServico.ObterAtendimentos(medicamento);

            foreach(var atendimentoMedicamento in medicamento.AtendimentosMedicamento)
            {
                atendimentoRemover.Remover(atendimentoMedicamento.Atendimento);
            }
            medicamentoServico.Remover(medicamento.MedicamentoID);
        }
    }
}
