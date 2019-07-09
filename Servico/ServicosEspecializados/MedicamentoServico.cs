using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class MedicamentoServico : GenericService<Medicamento>
    {
        private MedicamentoDAL medicamentoDAL = new MedicamentoDAL();
        public void ObterAtendimentos(Medicamento medicamento)
        {
            medicamentoDAL.ObterAtendimentos(medicamento);
        }

        public IList<Medicamento> BuscarPorNome(string nome)
        {
            return medicamentoDAL.Buscar(a => a.Nome.Contains(nome));
        }
    }
}
