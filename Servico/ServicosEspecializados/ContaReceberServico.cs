using Modelo;
using Persistencia.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.ServicosEspecializados
{
    public class ContaReceberServico : GenericService<ContaReceber>
    {
        private ContaReceberDAL contaReceberDAL = new ContaReceberDAL();
        
        public void ObterAtendimento(ContaReceber contaReceber)
        {
            contaReceberDAL.ObterAtendimento(contaReceber);
        }

        public void ObterCaixas(ContaReceber contaReceber)
        {
            contaReceberDAL.ObterCaixas(contaReceber);
        }

        public IList<ContaReceber> BuscarPorData(DateTime dateTime)
        {
            return contaReceberDAL.Buscar(c => c.DataVencimento.Date == dateTime.Date);
        }

        public void Remover(long? ID)
        {
            base.Remover(ID);
        }
    }
}
