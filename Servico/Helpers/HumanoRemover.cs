using Modelo;
using Servico.ServicosEspecializados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Helpers
{
    public abstract class HumanoRemover<T> where T : Humano
    {
        private HumanoServico<T> humanoServico = new HumanoServico<T>();
        private AnimalServico animalServico = new AnimalServico();
        private AnimalRemover animalRemover = new AnimalRemover();

        public void Remover(T humano)
        {
            humanoServico.ObterAnimais(humano);
            foreach (var animal in humano.Animais)
            {
                animalRemover.Remover(animal);
            }
            humanoServico.Remover(humano.HumanoID);
        }
    }
}
