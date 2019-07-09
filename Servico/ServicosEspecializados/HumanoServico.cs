using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.ServicosEspecializados
{
    public class HumanoServico<T>: GenericService<T> where T : Humano 
    {
        private HumanoDAL<T> humanoDAL = new HumanoDAL<T>();
        public void ObterAnimais(T humano)
        {
            humanoDAL.ObterAnimais(humano);
        }

        public IList<T> BuscarPorNome(string nome)
        {
            return humanoDAL.Buscar(a => a.Nome.Contains(nome));
        }

        public IList<T> BuscarPorCPF(string cpf)
        {
            return humanoDAL.Buscar(a => a.CPF.Contains(cpf));
        }
    }
}
