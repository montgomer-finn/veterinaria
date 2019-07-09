using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.DAL
{
    public class TipoDAL : GenericRepository<Tipo>
    {
        public void ObterAnimais(Tipo tipo)
        {
            using (var context = new EFContext())
            {
                context.Attach<Tipo>(tipo);
                context.Entry(tipo).Collection(t => t.Animais).Load();
            }
        }
    }
}
