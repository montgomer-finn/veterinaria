using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    public class AtendimentoDAL : GenericRepository<Atendimento>
    {
        public void ObterExames(Atendimento atendimento)
        {
            using (var context = new EFContext())
            {
                context.Attach<Atendimento>(atendimento);
                context.Entry(atendimento).Collection(a => a.AtendimentoExames).Load();
                foreach(var atendimentoExame in atendimento.AtendimentoExames)
                {
                    context.Attach<AtendimentoExame>(atendimentoExame);
                    context.Entry(atendimentoExame).Reference(a => a.Exame).Load();
                }
            }
        }

        public void ObterMedicamentos(Atendimento atendimento)
        {
            using (var context = new EFContext())
            {
                context.Attach<Atendimento>(atendimento);
                context.Entry(atendimento).Collection(a => a.AtendimentoMedicamentos).Load();
                foreach (var atendimentoMedicamento in atendimento.AtendimentoMedicamentos)
                {
                    context.Attach<AtendimentoMedicamento>(atendimentoMedicamento);
                    context.Entry(atendimentoMedicamento).Reference(a => a.Medicamento).Load();
                }
            }
        }

        public void ObterVeterinario(Atendimento atendimento)
        {
            using (var context = new EFContext())
            {
                context.Attach<Atendimento>(atendimento);
                context.Entry(atendimento).Reference(a => a.Veterinario).Load();
            }
        }

        public void ObterAnimal(Atendimento atendimento)
        {
            using (var context = new EFContext())
            {
                context.Attach<Atendimento>(atendimento);
                context.Entry(atendimento).Reference(a => a.Animal).Load();
            }
        }

        public void ObterCaixas(Atendimento atendimento)
        {
            using (var context = new EFContext())
            {
                context.Attach<Atendimento>(atendimento);
                context.Entry(atendimento).Collection(a => a.Caixas).Load();
            }
        }

        public void ObterContasReceber(Atendimento atendimento)
        {
            using (var context = new EFContext())
            {
                context.Attach<Atendimento>(atendimento);
                context.Entry(atendimento).Collection(a => a.ContasReceber).Load();
            }
        }

    }
}
