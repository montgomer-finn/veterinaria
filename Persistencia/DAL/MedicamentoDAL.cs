using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    public class MedicamentoDAL : GenericRepository<Medicamento>
    {
        public void ObterAtendimentos(Medicamento medicamento)
        {
            using (var context = new EFContext())
            {
                context.Attach<Medicamento>(medicamento);
                context.Entry(medicamento).Collection(a => a.AtendimentosMedicamento).Load();
                foreach (var atendimentoMedicamento in medicamento.AtendimentosMedicamento)
                {
                    context.Attach<AtendimentoMedicamento>(atendimentoMedicamento);
                    context.Entry(atendimentoMedicamento).Reference(a => a.Atendimento).Load();
                }
            }
        }
    }
}
