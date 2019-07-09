using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Medicamento
    {
        public Medicamento(string nome, double dosagem, string descricao)
        {
            Nome = nome;
            Dosagem = dosagem;
            Descricao = descricao;
        }
        public Medicamento()
        {

        }
        public long? MedicamentoID { get; set; }
        public string Nome { get; set; }
        public double Dosagem { get; set; }
        public string Descricao { get; set; }
        public virtual List<AtendimentoMedicamento> AtendimentosMedicamento { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
