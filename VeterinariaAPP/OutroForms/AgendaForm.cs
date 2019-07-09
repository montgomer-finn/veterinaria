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

namespace VeterinariaAPP
{
    public partial class AgendaForm : Form
    {
        private AtendimentoServico atendimentoServico = new AtendimentoServico();
        private Atendimento atendimento;
        public AgendaForm()
        {
            InitializeComponent();
            procurarButton.Visible = true;
        }

        private void PopularDataGrid(IList<Atendimento> atendimentos)
        {
            foreach (var atendimento in atendimentos)
            {
                atendimentoServico.ObterAnimal(atendimento);
                atendimentoServico.ObterVeterinario(atendimento);
            }

            agendaDGV.DataSource = (from atendimento in atendimentos
                                    select new
                                    {
                                        atendimento.AtendimentoID,
                                        atendimento.Veterinario,
                                        atendimento.Data,
                                        atendimento.Realizado,
                                        atendimento.Animal
                                    }).ToList();
        }

        public AgendaForm(DateTime data)
        {
            InitializeComponent();

            var atendimentos = atendimentoServico.BuscarPorData(data);
            PopularDataGrid(atendimentos);
            calendario.SelectionStart = data;
            calendario.SelectionEnd = data;
        }

        public AgendaForm(DateTime dataInicio, DateTime dataFim)
        {
            InitializeComponent();
            var atendimentos = atendimentoServico.BuscarPorData(dataInicio, dataFim);
            PopularDataGrid(atendimentos);
            calendario.SelectionStart = dataInicio;
            calendario.SelectionEnd = dataFim;
        }

        public AgendaForm(int mes, int ano)
        {
            InitializeComponent();

            var atendimentos = atendimentoServico.BuscarPorMes(mes, ano);
            PopularDataGrid(atendimentos);
            calendario.SelectionStart = new DateTime(ano, mes, 1);
            calendario.SelectionEnd = new DateTime(ano, mes, DateTime.DaysInMonth(ano, mes));
        }

        private void ProcurarButton_Click(object sender, EventArgs e)
        {
            var atendimentos = atendimentoServico.BuscarPorData(calendario.SelectionStart, calendario.SelectionEnd);
            PopularDataGrid(atendimentos);
        }

        private void AgendaDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(agendaDGV.SelectedRows[0].Cells[0].Value);

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
