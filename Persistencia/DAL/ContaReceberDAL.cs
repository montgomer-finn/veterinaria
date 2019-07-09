using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.DAL
{
    public class ContaReceberDAL : GenericRepository<ContaReceber>
    {
        public void ObterAtendimento(ContaReceber contaReceber)
        {
            using (var context = new EFContext())
            {
                context.Attach<ContaReceber>(contaReceber);
                context.Entry(contaReceber).Reference(c => c.Atendimento).Load();
            }
        }

        public void ObterCaixas(ContaReceber contaReceber)
        {
            using (var context = new EFContext())
            {
                context.Attach<ContaReceber>(contaReceber);
                context.Entry(contaReceber).Collection(c => c.Caixas).Load();
            }
        }
    }
}
