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
        public void Remover(Medicamento medicamento)
        {
            medicamentoServico.ObterAtendimentos(medicamento);

            foreach (var atendimentoMedicamento in medicamento.AtendimentosMedicamento)
            {
                atendimentoMedicamentoServico.Remover(atendimentoMedicamento.AtendimentoMedicamentoID);
            }

            medicamentoServico.Remover(medicamento.MedicamentoID);
        }
    }
}
