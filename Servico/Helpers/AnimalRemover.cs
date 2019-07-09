using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Helpers
{
    public class AnimalRemover
    {
        private AnimalServico animalServico = new AnimalServico();
        private AtendimentoRemover atendimentoRemover = new AtendimentoRemover();
        public void Remover(Animal animal)
        {
            animalServico.ObterAtendimentos(animal);
            foreach (var atendimento in animal.Atendimentos)
            {
                atendimentoRemover.Remover(atendimento);
            }

            animalServico.Remover(animal.AnimalID);
        }
    }
}
