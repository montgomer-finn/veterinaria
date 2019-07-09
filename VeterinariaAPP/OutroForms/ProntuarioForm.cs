using Modelo;
using Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;

namespace VeterinariaAPP.OutroForms
{
    public partial class ProntuarioForm : Form
    {
        private Animal animal;
        private Atendimento atendimento;
        private AnimalServico animalServico = new AnimalServico();
        private AtendimentoServico atendimentoServico = new AtendimentoServico();
        public ProntuarioForm(Animal animal)
        {
            InitializeComponent();
            this.animal = animal;
            nomeLabelText.Text = animal.Nome;
            idadeLabelText.Text = (DateTime.Now - animal.DataNascimento).Humanize();
            animalServico.ObterTipo(animal);
            tipoLabelText.Text = animal.Tipo.Nome;
            animalServico.ObterHumano(animal);
            humanoLabelText.Text = animal.Humano.Nome;
            animalServico.ObterAtendimentos(animal);
            PopularDataGrid();
        }

        public void PopularDataGrid()
        {
            var aux = atendimentoServico.BuscarPorAnimalID(animal.AnimalID);

            foreach(var atendimento in aux)
            {
                atendimentoServico.ObterVeterinario(atendimento);
            }

            atendimentosDGV.DataSource = (from atendimento in aux
                                          select new
                                          {
                                              atendimento.AtendimentoID,
                                              atendimento.Data,
                                              atendimento.Veterinario,
                                              atendimento.Descricao,
                                              atendimento.Realizado,
                                          }
                                          ).ToList();
        }

        private void AtendimentosDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(atendimentosDGV.SelectedRows[0].Cells[0].Value);

            atendimento = atendimentoServico.ObterPorID(id);
            atendimentoServico.ObterExames(atendimento);
            atendimentoServico.ObterMedicamentos(atendimento);
            atendimentoServico.ObterVeterinario(atendimento);
            atendimentoServico.ObterAnimal(atendimento);

            string message = $"Realização: {atendimento.Data.Humanize()}\nAnimal: {atendimento.Animal.Nome}" +
                $"\nVeterinario: {atendimento.Veterinario.Nome}\nRealizado: {atendimento.Realizado}" +
                $"\nDescrição: {atendimento.Descricao}";

            if (atendimento.AtendimentoMedicamentos.Count == 0)
            {
                message += "\n\nNenhum medicamento cadastrado";
            }
            else
            {
                message += "\n\nMedicamentos: ";
                foreach (var atendimentoMedicamento in atendimento.AtendimentoMedicamentos)
                {
                    message += $"\n   Medicamento: {atendimentoMedicamento.Medicamento.Nome}" +
                        $"\n   Dosagem: {atendimentoMedicamento.Medicamento.Dosagem}" +
                        $"\n   Descrição: {atendimentoMedicamento.Medicamento.Descricao}\n";
                }
            }

            if (atendimento.AtendimentoExames.Count == 0)
            {
                message += "\n\nNenhum exame cadastrado";
            }
            else
            {
                message += "\n\nExames: ";
                foreach (var atendimentoExame in atendimento.AtendimentoExames)
                {
                    message += $"\n   Nome: {atendimentoExame.Exame.Nome}" +
                        $"\n   Descrição: {atendimentoExame.Exame.Descricao}\n";
                }
            }

            if (atendimento.Realizado)
            {
                atendimentoServico.ObterCaixas(atendimento);
                if (atendimento.Caixas != null && atendimento.Caixas.Count > 0)
                {
                    message += $"\n\nPagamento à vista\n   R${atendimento.Caixas[0].Valor}";
                }
                else
                {
                    atendimentoServico.ObterContasReceber(atendimento);
                    message += $"\n\nPagamento em {atendimento.ContasReceber.Count} parcelas";
                    int i = 1;
                    foreach (var contaReceber in atendimento.ContasReceber)
                    {
                        message += $"\n   Parcela {i}: Valor Total R${contaReceber.ValorTotal},  Valor Abatido: R${contaReceber.ValorAbatido}, Data de vencimento: {contaReceber.DataVencimento}";
                        i++;
                    }
                }
            }

            MessageBox.Show(message, "Detalhes");

        }
    }
}
