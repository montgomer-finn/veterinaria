using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Animal
    {
        public Animal(string nome, DateTime dataNascimento, long? humanoID, long? tipoID)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            HumanoID = humanoID;
            TipoID = tipoID;
        }
        public Animal()
        {

        }
        public long? AnimalID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public long? TipoID { get; set; }
        public virtual Tipo Tipo { get; set; }
        public long? HumanoID { get; set; }
        public virtual Humano Humano { get; set; }
        public virtual List<Atendimento> Atendimentos { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
