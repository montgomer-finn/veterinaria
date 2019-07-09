using Modelo;
using Persistencia.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.ServicosEspecializados
{
    public class TipoServico : GenericService<Tipo>
    {
        private TipoDAL tipoDAL = new TipoDAL();
        public void ObterAnimais(Tipo tipo)
        {
            tipoDAL.ObterAnimais(tipo);
        }
        public IList<Tipo> BuscarPorNome(string nome)
        {
            return tipoDAL.Buscar(t => t.Nome.Contains(nome));
        }
    }
}
