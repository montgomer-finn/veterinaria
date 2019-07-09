using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Helpers
{
    public class VeterinarioRemover : HumanoRemover<Veterinario>
    {
        private VeterinarioServico veterinarioServico = new VeterinarioServico();
        private AtendimentoRemover atendimentoRemover = new AtendimentoRemover();
        public new void Remover(Veterinario veterinario)
        {
            veterinarioServico.ObterAtendimentos(veterinario); 
            foreach (var atendimento in veterinario.Atendimentos)
            {
                atendimentoRemover.Remover(atendimento);
            }
            veterinarioServico.ObterAtendimentos(veterinario);
            base.Remover(veterinario);
        }
    }
}
