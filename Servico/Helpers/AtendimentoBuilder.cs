using Modelo;
using Servico.ServicosEspecializados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class AtendimentoBuilder
    {
        private DateTime data;
        private Boolean realizado = false;
        private string descricao;
        private long? animalID;
        private long? veterinarioID;
        private double preco;
        private  List<Exame> exames = new List<Exame>();
        private List<Medicamento> medicamentos = new List<Medicamento>();
        private int? parcelas = null;
        private int diaParcela;

        AtendimentoServico atendimentoServico = new AtendimentoServico();
        CaixaServico caixaServico = new CaixaServico();
        ContaReceberServico contaReceberServico = new ContaReceberServico();
        GenericService<AtendimentoExame> atendimentoExameServico = new GenericService<AtendimentoExame>();
        GenericService<AtendimentoMedicamento> atendimentoMedicamentoServico = new GenericService<AtendimentoMedicamento>();

        public AtendimentoBuilder NaData(DateTime data)
        {
            this.data = data;
            return this;
        }

        public AtendimentoBuilder PrecoAtendimento(double preco)
        {
            this.preco = preco;
            realizado = true;
            return this;
        }

        public AtendimentoBuilder JaRealizado()
        {
            realizado = true;
            return this;
        }

        public AtendimentoBuilder ComDescricao(string descricao)
        {
            this.descricao = descricao;
            return this;
        }

        public AtendimentoBuilder ParaAnimal(Animal animal)
        {
            animalID = animal.AnimalID;
            return this;
        }

        public AtendimentoBuilder ComVeterinario(Veterinario veterinario)
        {
            veterinarioID = veterinario.HumanoID;
            return this;
        }

        public AtendimentoBuilder ComExame(Exame exame)
        {
            exames.Add(exame);
            return this;
        }

        public AtendimentoBuilder ComMedicamento(Medicamento medicamento)
        {
            medicamentos.Add(medicamento);
            return this;
        }

        public AtendimentoBuilder PagamentoParcelado(int parcelas, int dia = 0)
        {
            this.parcelas = parcelas;
            this.diaParcela = dia;
            return this;
        }

        public AtendimentoBuilder PagamentoAVista()
        {
            this.parcelas = 0;
            return this;
        }

        public Atendimento Build()
        {
            Atendimento atendimento;

            if (realizado == true)
            {
                atendimento = new Atendimento(data, descricao, animalID, veterinarioID, realizado, preco);
                atendimentoServico.Inserir(atendimento);

                foreach (var exame in exames)
                {
                    preco += exame.Preco;
                }

                if (parcelas == 0)
                {
                    caixaServico.Inserir(new Caixa(data, preco, atendimento.AtendimentoID));
                }
                else if (parcelas > 0)
                {
                    for (int i = 1; i <= parcelas; i++)
                    {
                        int mesAux = data.Month + i;
                        int anoAux = data.Year;
                        while (mesAux > 12)
                        {
                            mesAux -= 12;
                            anoAux++;
                        }

                        DateTime dataAux = new DateTime(anoAux, mesAux, diaParcela);
                        contaReceberServico.Inserir(new ContaReceber(atendimento.AtendimentoID, dataAux, Convert.ToDouble(preco / parcelas)));
                    }
                }
            }
            else
            {
                atendimento = new Atendimento(data, descricao, animalID, veterinarioID);
                atendimentoServico.Inserir(atendimento);
            }

            foreach(var exame in exames)
            {
                atendimentoExameServico.Inserir(new AtendimentoExame(exame.Preco, atendimento.AtendimentoID, exame.ExameID));
            }

            foreach(var medicamento in medicamentos)
            {
                atendimentoMedicamentoServico.Inserir(new AtendimentoMedicamento(atendimento.AtendimentoID, medicamento.MedicamentoID));
            }

            return atendimento;
        }
    }
}
