using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Veterinario : Humano
    {
        public Veterinario(string nome, string cpf): base(nome, cpf)
        {

        }
        public Veterinario()
        {

        }
        public virtual List<Atendimento> Atendimentos { get; set; }
    }
}
