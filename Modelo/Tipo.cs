using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Tipo
    {
        public Tipo(string nome)
        {
            Nome = nome;
        }
        public long? TipoID { get; set; }
        public string Nome { get; set; }
        public virtual List<Animal> Animais { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }
}
