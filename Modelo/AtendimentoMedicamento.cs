using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class AtendimentoMedicamento
    {
        public AtendimentoMedicamento(long? atendimentoID, long? medicamentoID)
        {
            AtendimentoID = atendimentoID;
            MedicamentoID = medicamentoID;
        }
        public AtendimentoMedicamento()
        {

        }
        public long? AtendimentoMedicamentoID { get; set; }
        public long? AtendimentoID { get; set; }
        public virtual Atendimento Atendimento { get; set; }
        public long? MedicamentoID { get; set; }
        public virtual Medicamento Medicamento { get; set; }
    }
}
