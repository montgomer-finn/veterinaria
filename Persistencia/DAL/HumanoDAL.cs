using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    public class HumanoDAL<T>: GenericRepository<T> where T : Humano 
    {
        public void ObterAnimais(T humano)
        {
            using (var context = new EFContext())
            {
                context.Attach<T>(humano);
                context.Entry(humano).Collection(a => a.Animais).Load();
            }
        }
    }
}
