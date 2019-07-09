using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class AnimalServico : GenericService<Animal>
    {
        private AnimalDAL animalDAL = new AnimalDAL();
        public void ObterHumano(Animal animal)
        {
            animalDAL.ObterHumano(animal);
        }

        public void ObterTipo(Animal animal)
        {
            animalDAL.ObterTipo(animal);
        }

        public IList<Animal> BuscarPorNome(String nome)
        {
            return animalDAL.Buscar(a => a.Nome.Contains(nome));
        }

        public IList<Animal> BuscarPorHumanoID(long? humanoID)
        {
            return animalDAL.Buscar(a => a.HumanoID == humanoID);
        }

        public void ObterAtendimentos(Animal animal)
        {
            animalDAL.ObterAtendimentos(animal);
        }
    }       
}
