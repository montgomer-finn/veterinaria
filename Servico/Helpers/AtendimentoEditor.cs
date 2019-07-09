using Modelo;
using Servico.ServicosEspecializados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servico
{
    public class AtendimentoEditor
    {
        private Atendimento atendimento;

        private List<Exame> examesVelhos = new List<Exame>();
        private List<Medicamento> medicamentosVelhos = new List<Medicamento>();

        private List<Exame> examesNovos = new List<Exame>();
        private List<Medicamento> medicamentosNovos = new List<Medicamento>();

        AtendimentoServico atendimentoServico = new AtendimentoServico();
        CaixaServico caixaServico = new CaixaServico();
        ContaReceberServico contaReceberServico = new ContaReceberServico();
        GenericService<AtendimentoExame> atendimentoExameServico = new GenericService<AtendimentoExame>();
        GenericService<AtendimentoMedicamento> atendimentoMedicamentoServico = new GenericService<AtendimentoMedicamento>();
        private int? parcelas = null;
        private int diaParcela;
        private double preco;


        public AtendimentoEditor(Atendimento atendimento)
        {
            if(atendimento.Realizado == true)
            {
                throw new Exception("Não é possível editar um atendimento já realizado");
            }

            this.atendimento = atendimento;

            atendimentoServico.ObterExames(atendimento);
            foreach(var atendimentoExame in atendimento.AtendimentoExames)
            {
                examesVelhos.Add(atendimentoExame.Exame);
            }

            atendimentoServico.ObterMedicamentos(atendimento);
            foreach (var atendimentoMedicamento in atendimento.AtendimentoMedicamentos)
            {
                medicamentosVelhos.Add(atendimentoMedicamento.Medicamento);
            }
        }

        public AtendimentoEditor NaData(DateTime data)
        {
            atendimento.Data = data;
            return this;
        }

        public AtendimentoEditor PrecoAtendimento(double preco)
        {
            this.preco = preco;
            JaRealizado();
            return this;
        }

        public AtendimentoEditor JaRealizado()
        {
            atendimento.Realizado = true;
            return this;
        }

        public AtendimentoEditor ComDescricao(string descricao)
        {
            atendimento.Descricao = descricao;
            return this;
        }

        public AtendimentoEditor ParaAnimal(Animal animal)
        {
            atendimento.AnimalID = animal.AnimalID;
            return this;
        }

        public AtendimentoEditor ComVeterinario(Veterinario veterinario)
        {
            atendimento.VeterinarioID = veterinario.HumanoID;
            return this;
        }

        public AtendimentoEditor ComExame(Exame exame)
        {
            if (examesVelhos.Contains(exame))
                examesVelhos.Remove(exame);

            else
                examesNovos.Add(exame);

            return this;
        }

        public AtendimentoEditor ComMedicamento(Medicamento medicamento)
        {
            if (medicamentosVelhos.Contains(medicamento))
                medicamentosVelhos.Remove(medicamento);

            else
                medicamentosNovos.Add(medicamento);

            return this;
        }

        public AtendimentoEditor PagamentoParcelado(int parcelas, int dia)
        {
            this.parcelas = parcelas;
            this.diaParcela = dia;
            JaRealizado();
            return this;
        }

        public AtendimentoEditor PagamentoAVista()
        {
            this.parcelas = 0;
            JaRealizado();
            return this;
        }

        public Atendimento Edit()
        {
            foreach (var exame in examesVelhos)
            {
                var aux = from atendimentoExame in atendimento.AtendimentoExames where atendimentoExame.ExameID == exame.ExameID select atendimentoExame.AtendimentoExameID;
                foreach (var atendimentoExameID in aux)
                {
                    atendimentoExameServico.Remover(atendimentoExameID);
                }
            }

            foreach (var medicamento in medicamentosVelhos)
            {
                var aux = from atendimentoMedicamento in atendimento.AtendimentoMedicamentos where atendimentoMedicamento.MedicamentoID == medicamento.MedicamentoID select atendimentoMedicamento.AtendimentoMedicamentoID;
                foreach (var atendimentoMedicamentoID in aux)
                {
                    atendimentoMedicamentoServico.Remover(atendimentoMedicamentoID);
                }
            }

            foreach (var exame in examesNovos)
            {
                atendimentoExameServico.Inserir(new AtendimentoExame(exame.Preco, atendimento.AtendimentoID, exame.ExameID));
            }

            foreach (var medicamento in medicamentosNovos)
            {
                atendimentoMedicamentoServico.Inserir(new AtendimentoMedicamento(atendimento.AtendimentoID, medicamento.MedicamentoID));
            }

            if (atendimento.Realizado)
            {
                atendimento.Valor = preco;
                atendimentoServico.ObterExames(atendimento);
                foreach(var atendimentoExame in atendimento.AtendimentoExames)
                {
                    preco += atendimentoExame.Preco;
                }
                if (parcelas == 0)
                {
                    caixaServico.Inserir(new Caixa(atendimento.Data, preco, atendimento.AtendimentoID));
                }
                else if (parcelas > 0)
                {
                    preco = Convert.ToDouble(preco / parcelas);
                    for (int i = 1; i <= parcelas; i++)
                    {
                        int mesAux = atendimento.Data.Month + i;
                        int anoAux = atendimento.Data.Year;
                        while (mesAux > 12)
                        {
                            mesAux -= 12;
                            anoAux++;
                        }
                        DateTime dataAux = new DateTime(anoAux, mesAux, diaParcela);
                        contaReceberServico.Inserir(new ContaReceber(atendimento.AtendimentoID, dataAux, preco));
                    }
                }
            }

            atendimentoServico.Atualizar(atendimento);

            return atendimento;
        }
    }
}
