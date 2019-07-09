using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class ExameServico : GenericService<Exame>
    {
        private ExameDAL exameDAL = new ExameDAL();
        public void ObterAtendimentos(Exame exame)
        {
            exameDAL.ObterAtendimentos(exame);
        }

        public IList<Exame> BuscarPorNome(string nome)
        {
            return exameDAL.Buscar(a => a.Nome.Contains(nome));
        }
    }
}
