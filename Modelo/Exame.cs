using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Exame
    {
        public Exame(string nome, string descricao, double preco)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
        }
        public Exame()
        {

        }
        public long? ExameID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public virtual List<AtendimentoExame> AtendimentosExame { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
