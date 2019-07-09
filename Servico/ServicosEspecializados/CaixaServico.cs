using Modelo;
using Persistencia.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.ServicosEspecializados
{
    public class CaixaServico : GenericService<Caixa>
    {
        private CaixaDAL caixaDAL = new CaixaDAL();
        public void ObterAtendimento(Caixa caixa)
        {
            caixaDAL.ObterAtendimento(caixa);
        }

        public void ObterContaReceber(Caixa caixa)
        {
            caixaDAL.ObterContaReceber(caixa);
        }

        public IList<Caixa> BuscarPorAtendimentoID(long? caixaID)
        {
            return caixaDAL.Buscar(a => a.CaixaID == caixaID);
        }

        public IList<Caixa> BuscarPorData(DateTime dateTime)
        {
            return caixaDAL.Buscar(c => c.Data.Date == dateTime.Date);
        }

        public void Remover(long? caixaID)
        {
            base.Remover(caixaID);
        }
    }
}
