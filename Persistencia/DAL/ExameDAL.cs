using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    public class ExameDAL : GenericRepository<Exame>
    {
        public void ObterAtendimentos(Exame exame)
        {
            using (var context = new EFContext())
            {
                context.Attach<Exame>(exame);
                context.Entry(exame).Collection(a => a.AtendimentosExame).Load();
                foreach (var atendimentoExame in exame.AtendimentosExame)
                {
                    context.Attach<AtendimentoExame>(atendimentoExame);
                    context.Entry(atendimentoExame).Reference(a => a.Atendimento).Load();
                }
            }
        }
    }
}
