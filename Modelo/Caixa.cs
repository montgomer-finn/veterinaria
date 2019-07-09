using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Caixa
    {
        public Caixa()
        {

        }
        public Caixa(DateTime data, double valor, long? atendimentoID = null, long? contaReceberID = null)
        {
            AtendimentoID = atendimentoID;
            ContaReceberID = contaReceberID;
            Data = data;
            Valor = valor;
        }

        public long? CaixaID { get; set; }
        public long? AtendimentoID { get; set; }
        public Atendimento Atendimento { get; set; }
        public long? ContaReceberID { get; set; }
        public ContaReceber ContaReceber { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
    }
}
