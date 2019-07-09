using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.DAL
{
    public class VeterinarioDAL : HumanoDAL<Veterinario>
    {
        public void ObterAtendimentos(Veterinario veterinario)
        {
            using (var context = new EFContext())
            {
                context.Attach<Veterinario>(veterinario);
                context.Entry(veterinario).Collection(a => a.Atendimentos).Load();
            }
        }
    }
}
