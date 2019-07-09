using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.DAL
{
    public class CaixaDAL : GenericRepository<Caixa>
    {
        public void ObterAtendimento(Caixa caixa)
        {
            using (var context = new EFContext())
            {
                context.Attach<Caixa>(caixa);
                context.Entry(caixa).Reference(c => c.Atendimento).Load();
            }
        }

        public void ObterContaReceber(Caixa caixa)
        {
            using (var context = new EFContext())
            {
                context.Attach<Caixa>(caixa);
                context.Entry(caixa).Reference(c => c.ContaReceber).Load();
            }
        }
    }
}
