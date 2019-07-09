using Modelo;
using Servico.ServicosEspecializados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Helpers
{
    public class TipoRemover
    {
        private TipoServico tipoServico = new TipoServico();
        private AnimalRemover animalRemover = new AnimalRemover();

        public void Remover(Tipo tipo)
        {
            tipoServico.ObterAnimais(tipo);
            foreach (var animal in tipo.Animais)
            {
                animalRemover.Remover(animal);
            }
            tipoServico.Remover(tipo.TipoID);
        }
    }
}
