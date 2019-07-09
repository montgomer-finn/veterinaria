using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Atendimento
    {
        public Atendimento(DateTime data, string descricao, long? animalID, long? veterinarioID)
        {
            Data = data;
            Descricao = descricao;
            AnimalID = animalID;
            VeterinarioID = veterinarioID;
            Realizado = false;
        }
        public Atendimento(DateTime data, string descricao, long? animalID, long? veterinarioID, Boolean realizado, double valor)
        {
            Data = data;
            Descricao = descricao;
            AnimalID = animalID;
            VeterinarioID = veterinarioID;
            Realizado = realizado;
            Valor = valor;
        }
        public Atendimento()
        {

        }
        public long? AtendimentoID { get; set; }
        public DateTime Data { get; set; }
        public Boolean Realizado { get; set; }
        public string Descricao { get; set; }
        public long? AnimalID { get; set; }
        public virtual Animal Animal { get; set; }
        public long? VeterinarioID { get; set; }
        public virtual Veterinario Veterinario { get; set; }
        public double Valor { get; set; }
        public virtual List<Caixa> Caixas { get; set; }
        public virtual List<ContaReceber> ContasReceber { get; set; }
        public virtual List<AtendimentoExame> AtendimentoExames { get; set; }
        public virtual List<AtendimentoMedicamento> AtendimentoMedicamentos { get; set; }
    }
}
