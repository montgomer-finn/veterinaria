using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class ContaReceber
    {
        public ContaReceber()
        {

        }

        public ContaReceber(long? atendimentoID, DateTime dataVencimento, double valorTotal, double valorAbatido = 0)
        {
            AtendimentoID = atendimentoID;
            DataVencimento = dataVencimento;
            ValorTotal = valorTotal;
            ValorAbatido = valorAbatido;
        }
        public long? ContaReceberID { get; set; }
        public long? AtendimentoID { get; set; }
        public Atendimento Atendimento { get; set; }
        public DateTime DataVencimento { get; set; }
        public double ValorTotal { get; set; }
        public double ValorAbatido { get; set; }
        public List<Caixa> Caixas { get; set; }

    }
}
