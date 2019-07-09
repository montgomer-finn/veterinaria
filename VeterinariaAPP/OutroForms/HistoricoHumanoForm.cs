using Modelo;
using Servico;
using Servico.ServicosEspecializados;
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
    public partial class HistoricoHumanoForm : Form
    {
        private Humano humano;
        HumanoServico<Humano> humanoServico = new HumanoServico<Humano>();

        private Veterinario veterinario;
        private VeterinarioServico veterinarioServico;

        private Atendimento atendimento;
        private AtendimentoServico atendimentoServico = new AtendimentoServico();
        
        private AnimalServico animalServico = new AnimalServico();
    
        public HistoricoHumanoForm(Cliente cliente)
        {
            InitializeComponent();
            humano = cliente;
            ObterInformacoes();
            PopularDataGrid();
        }

        public HistoricoHumanoForm(Veterinario veterinario)
        {
            InitializeComponent();
            humano = veterinario;

            this.veterinario = veterinario;
            tipoLabelText.Text = "Veterinario";
            veterinarioServico = new VeterinarioServico();

            groupVeterinarioOnly.Visible = true;
            porButton.Visible = true;
            paraButton.Visible = true;
            porButton.Checked = true;
            paraButton.Checked = false;

            ObterInformacoes();
            PopularDataGrid();
        }

        private void ObterInformacoes()
        {
            nomeLabelText.Text = humano.Nome;
            CPFLabelText.Text = humano.CPF;
            humanoServico.ObterAnimais(humano);
        }

        public void PopularDataGrid()
        {
            if(paraButton.Checked == true)
            {
                List<Atendimento> atendimentos = new List<Atendimento>();

                foreach (var animal in humano.Animais)
                {
                    animalServico.ObterAtendimentos(animal);
                    foreach(var atendimento in animal.Atendimentos)
                    {
                        atendimentoServico.ObterAnimal(atendimento);
                        atendimentos.Add(atendimento);
                    }
                }
            
                atendimentosDGV.DataSource = (from atendimento in atendimentos
                                              select new
                                              {
                                                  atendimento.AtendimentoID,
                                                  atendimento.Data,
                                                  atendimento.Animal,
                                                  atendimento.Descricao,
                                                  atendimento.Realizado,
                                              }
                                              ).ToList();
            }
            else
            {
                veterinarioServico.ObterAtendimentos(veterinario);

                foreach (var atendimento in veterinario.Atendimentos)
                {
                    atendimentoServico.ObterAnimal(atendimento);
                }

                atendimentosDGV.DataSource = (from atendimento in veterinario.Atendimentos
                                              select new
                                              {
                                                  atendimento.AtendimentoID,
                                                  atendimento.Data,
                                                  atendimento.Animal,
                                                  atendimento.Descricao,
                                                  atendimento.Realizado,
                                              }
                                              ).ToList();
            }
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
                    }
                }
            }

            MessageBox.Show(message, "Detalhes");
        }

        private void PorButton_CheckedChanged(object sender, EventArgs e)
        {
            PopularDataGrid();
        }

        private void ParaButton_CheckedChanged(object sender, EventArgs e)
        {
            PopularDataGrid();
        }
    }
}
