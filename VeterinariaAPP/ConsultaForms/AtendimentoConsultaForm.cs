using Modelo;
using Servico;
using Servico.Helpers;
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

namespace VeterinariaAPP.ConsultaForms
{
    public partial class AtendimentoConsultaForm : Form
    {
        private Atendimento atendimento;
        private AtendimentoServico atendimentoServico = new AtendimentoServico();
        private AtendimentoRemover atendimentoRemover = new AtendimentoRemover();
        private List<String> options = new List<String>()
        {
            "Id",
            "AnimalID",
            "VeterinarioID"
        };

        public AtendimentoConsultaForm()
        {
            InitializeComponent();
            optionsCombo.DataSource = options;
            AtualizarDGV();
        }

        private void AtualizarDGV()
        {
            atendimentosDGV.DataSource = null;
            atendimentosDGV.DataSource = (from atendimento in atendimentoServico.ObterTodos()
                                          select new
                                          {
                                              atendimento.AtendimentoID,
                                              atendimento.Data,
                                              atendimento.Realizado,
                                              atendimento.Descricao,
                                              atendimento.AnimalID,
                                              atendimento.VeterinarioID
                                          }).ToList();
        }

        private void ResetarCampos()
        {
            nomeTxt.Text = null;
            atendimento = null;
        }

        private void PesqButton_Click(object sender, EventArgs e)
        {
            mostrarTodosButton.Visible = true;
            if (optionsCombo.SelectedIndex == 0)
            {
                try
                {
                    List<Atendimento> aux = new List<Atendimento>();
                    aux.Add(atendimentoServico.ObterPorID(Convert.ToInt64(nomeTxt.Text)));
                    atendimentosDGV.DataSource = (from atendimento in aux
                                                  select new
                                                  {
                                                      atendimento.AtendimentoID,
                                                      atendimento.Data,
                                                      atendimento.Realizado,
                                                      atendimento.Descricao,
                                                      atendimento.AnimalID,
                                                      atendimento.VeterinarioID
                                                  }).ToList();
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o ID foi digitado corretamente");
                }
            }
            else if (optionsCombo.SelectedIndex == 1)
            {
                try
                {
                    atendimentosDGV.DataSource = (from atendimento in atendimentoServico.BuscarPorAnimalID(Convert.ToInt64(nomeTxt.Text))
                                                  select new
                                                  {
                                                      atendimento.AtendimentoID,
                                                      atendimento.Data,
                                                      atendimento.Realizado,
                                                      atendimento.Descricao,
                                                      atendimento.AnimalID,
                                                      atendimento.VeterinarioID
                                                  }).ToList();
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o AnimalID foi digitado corretamente");
                }
            }
            else if (optionsCombo.SelectedIndex == 2)
            {
                try
                {
                    atendimentosDGV.DataSource = (from atendimento in atendimentoServico.BuscarPorVeterinarioID(Convert.ToInt64(nomeTxt.Text))
                                                  select new
                                                  {
                                                      atendimento.AtendimentoID,
                                                      atendimento.Data,
                                                      atendimento.Realizado,
                                                      atendimento.Descricao,
                                                      atendimento.AnimalID,
                                                      atendimento.VeterinarioID
                                                  }).ToList();
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o VeterinarioID foi digitado corretamente");
                }
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
                if(atendimento.Caixas != null && atendimento.Caixas.Count > 0)
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

        private void EditarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(atendimentosDGV.SelectedRows[0].Cells[0].Value);
            atendimento = atendimentoServico.ObterPorID(id);
            if (atendimento.Realizado)
            {
                MessageBox.Show("Não é possível editar um atendimento realizado");
            }
            else
            {
                AtendimentoCadastroForm atendimentoCadastroForm = new AtendimentoCadastroForm(atendimento);
                atendimentoCadastroForm.MdiParent = this.MdiParent;
                atendimentoCadastroForm.Show();
            } 
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(atendimentosDGV.SelectedRows[0].Cells[0].Value);
            atendimento = atendimentoServico.ObterPorID(id);

            DialogResult result = DialogResult.Yes;
            if (atendimento.Realizado)
            {
                atendimentoServico.ObterCaixas(atendimento);
                if (atendimento.Caixas != null && atendimento.Caixas.Count > 0)
                {
                    result = MessageBox.Show("Esse atendimento possui um caixa.\nExcluí-lo excluirá também seu caixa.\nContinuar?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
                }
                else
                {
                    atendimentoServico.ObterContasReceber(atendimento);
                    result = MessageBox.Show("Esse atendimento possui contas à receber.\nExcluí-lo excluirá também todas as suas contas à receber.\nContinuar?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
                }
            }
            
            if(result == DialogResult.Yes)
            {
                atendimentoRemover.Remover(atendimento);
                MessageBox.Show("Excluido com sucesso");
                ResetarCampos();
                AtualizarDGV();
            }
        }

        private void AtendimentoConsultaForm_Activated(object sender, EventArgs e)
        {
            AtualizarDGV();
        }

        private void MostrarTodosButton_Click(object sender, EventArgs e)
        {
            AtualizarDGV();
        }
    }
}
