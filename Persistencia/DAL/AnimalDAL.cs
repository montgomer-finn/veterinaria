using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    public class AnimalDAL : GenericRepository<Animal>
    {
        public void ObterHumano(Animal animal)
        {
            using (var context = new EFContext())
            {
                context.Attach<Animal>(animal);
                context.Entry(animal).Reference(a => a.Humano).Load();
            }
        }

        public void ObterTipo(Animal animal)
        {
            using (var context = new EFContext())
            {
                context.Attach<Animal>(animal);
                context.Entry(animal).Reference(a => a.Tipo).Load();
            }
        }

        public void ObterAtendimentos(Animal animal)
        {
            using (var context = new EFContext())
            {
                context.Attach<Animal>(animal);
                animal.Atendimentos = null;
                context.Entry(animal).Collection(a => a.Atendimentos).Load();
            }
        }
    }
}
