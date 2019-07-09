using Humanizer;
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

namespace VeterinariaAPP.OutroForms
{
    public partial class ContaReceberForm : Form
    {
        private ContaReceber contaReceber;
        private CaixaServico caixaServico = new CaixaServico();
        private AtendimentoServico atendimentoServico = new AtendimentoServico();
        private AnimalServico animalServico = new AnimalServico();
        private ContaReceberServico contaReceberServico = new ContaReceberServico();

        private List<String> options = new List<String>()
        {
            "Id",
            "Data",
        };
        public ContaReceberForm()
        {
            InitializeComponent();
            optionsCombo.DataSource = options;
            AtualizarDGV();
        }
      
        private void AtualizarDGV()
        {
            contasReceberDGV.DataSource = null;
            IList<ContaReceber> aux = contaReceberServico.ObterTodos();

            foreach (var contaReceber in aux)
            {
                contaReceberServico.ObterAtendimento(contaReceber);
                atendimentoServico.ObterAnimal(contaReceber.Atendimento);
            }

            contasReceberDGV.DataSource = (from contaReceber in aux
                                           select new
                                           {
                                               contaReceber.ContaReceberID,
                                               contaReceber.DataVencimento,
                                               contaReceber.Atendimento.Animal.HumanoID,
                                               contaReceber.ValorTotal,
                                               contaReceber.ValorAbatido
                                           }).ToList();
        }

        private void ContasReceberDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(contasReceberDGV.SelectedRows[0].Cells[0].Value);
            contaReceber = contaReceberServico.ObterPorID(id);

            string message = "";

            contaReceberServico.ObterAtendimento(contaReceber);
            contaReceberServico.ObterCaixas(contaReceber);
            atendimentoServico.ObterAnimal(contaReceber.Atendimento);
            animalServico.ObterHumano(contaReceber.Atendimento.Animal);
            atendimentoServico.ObterVeterinario(contaReceber.Atendimento);

            message += $"Conta referente ao atendimento {contaReceber.AtendimentoID}\n" +
                $"Realizada para o animal {contaReceber.Atendimento.Animal.Nome}\n" +
                $"Pertencente ao humano: {contaReceber.Atendimento.Animal.Humano.Nome}\n" +
                $"Pelo veterinario {contaReceber.Atendimento.Veterinario.Nome}\n" +
                $"{contaReceber.Atendimento.Data.Humanize()}";

            if (contaReceber.Caixas.Count > 0)
            {
                message += "\n\nCaixas associados à esta conta à Receber:";
                foreach (var caixa in contaReceber.Caixas)
                {
                    message += $"{caixa.CaixaID}";
                }
            }

            MessageBox.Show(message);
        }

        private void PesqButton_Click(object sender, EventArgs e)
        {
            if (optionsCombo.SelectedIndex == 0)
            {
                try
                {
                    List<ContaReceber> aux = new List<ContaReceber>();
                    aux.Add(contaReceberServico.ObterPorID(Convert.ToInt64(nomeTxt.Text)));
                    contasReceberDGV.DataSource = (from contaReceber in aux
                                                   select new
                                                   {
                                                       contaReceber.ContaReceberID,
                                                       contaReceber.DataVencimento,
                                                       contaReceber.ValorTotal,
                                                       contaReceber.ValorAbatido
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
                    contasReceberDGV.DataSource = (from contaReceber in contaReceberServico.BuscarPorData(dateTimePicker.Value)
                                                   select new
                                                   {
                                                       contaReceber.ContaReceberID,
                                                       contaReceber.DataVencimento,
                                                       contaReceber.ValorTotal,
                                                       contaReceber.ValorAbatido
                                                   }).ToList();
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o nome foi digitado corretamente");
                }
            }
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(contasReceberDGV.SelectedRows[0].Cells[0].Value);
            contaReceber = contaReceberServico.ObterPorID(id);

            contaReceberServico.Remover(contaReceber.ContaReceberID);
            MessageBox.Show("Excluído com sucesso");
            AtualizarDGV();
        }

        private void OptionsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(optionsCombo.SelectedIndex == 0)
            {
                nomeTxt.Visible = true;
                dateTimePicker.Visible = false;
            }
            else if(optionsCombo.SelectedIndex == 1)
            {
                nomeTxt.Visible = false;
                dateTimePicker.Visible = true;
            }
        }

        private void PagarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(contasReceberDGV.SelectedRows[0].Cells[0].Value);
            contaReceber = contaReceberServico.ObterPorID(id);
            PagamentoContaReceberForm pagamentoContaReceber = new PagamentoContaReceberForm(contaReceber);
            pagamentoContaReceber.MdiParent = this.MdiParent;
            pagamentoContaReceber.Show();
        }

        private void ContaReceberForm_Activated(object sender, EventArgs e)
        {
            AtualizarDGV();
        }
    }
}
