using Modelo;
using Persistencia;
using Persistencia.DAL;
using Servico.ServicosEspecializados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class VeterinarioServico : HumanoServico<Veterinario>
    {
        private VeterinarioDAL veterinarioDAL = new VeterinarioDAL();

        public void ObterAtendimentos(Veterinario veterinario)
        {
            veterinarioDAL.ObterAtendimentos(veterinario);
        }
    }
}
