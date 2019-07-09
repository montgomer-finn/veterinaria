using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class AtendimentoExame
    {
        public AtendimentoExame(double preco, long? atendimentoID, long? exameID)
        {
            Preco = preco;
            AtendimentoID = atendimentoID;
            ExameID = exameID;
        }
        public AtendimentoExame()
        {

        }
        public long? AtendimentoExameID { get; set; }
        public double Preco { get; set; }
        public long? AtendimentoID { get; set; }
        public virtual Atendimento Atendimento { get; set; }
        public long? ExameID { get; set; }
        public virtual Exame Exame { get; set; }
    }
}
