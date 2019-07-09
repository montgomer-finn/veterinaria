using System;
using System.Collections.Generic;

namespace Modelo
{
    public abstract class Humano
    {
        public Humano(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
        public Humano()
        {

        }
        public long? HumanoID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public virtual List<Animal> Animais { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
