using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class AtendimentoServico : GenericService<Atendimento>
    {
        private AtendimentoDAL atendimentoDAL = new AtendimentoDAL();
        public void ObterExames(Atendimento atendimento)
        {
            atendimentoDAL.ObterExames(atendimento);
        }

        public void ObterMedicamentos(Atendimento atendimento)
        {
            atendimentoDAL.ObterMedicamentos(atendimento);
        }
        public void ObterVeterinario(Atendimento atendimento)
        {
            atendimentoDAL.ObterVeterinario(atendimento);
        }
        public void ObterAnimal(Atendimento atendimento)
        {
            atendimentoDAL.ObterAnimal(atendimento);
        }

        public IList<Atendimento> BuscarPorData(DateTime data)
        {
            return atendimentoDAL.Buscar(a => a.Data.Date == data.Date);
        }

        public IList<Atendimento> BuscarPorData(DateTime dataInicio, DateTime dataFim)
        {
            return atendimentoDAL.Buscar(a => a.Data.Date >= dataInicio.Date && a.Data.Date <= dataFim.Date);
        }

        public IList<Atendimento> BuscarPorMes(int mes, int ano)
        {
            return atendimentoDAL.Buscar(a => a.Data.Month == mes && a.Data.Year == ano);
        }

        public IList<Atendimento> BuscarPorVeterinarioID(long? humanoID)
        {
            return atendimentoDAL.Buscar(a => a.VeterinarioID == humanoID);
        }

        public IList<Atendimento> BuscarPorAnimalID(long? animalID)
        {
            return atendimentoDAL.Buscar(a => a.AnimalID == animalID);
        }

        public void ObterCaixas(Atendimento atendimento)
        {
            atendimentoDAL.ObterCaixas(atendimento);
        }

        public void ObterContasReceber(Atendimento atendimento)
        {
            atendimentoDAL.ObterContasReceber(atendimento);
        }
    }
}
