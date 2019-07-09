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

namespace VeterinariaAPP.ConsultaForms
{
    public partial class MedicamentoConsultaForm : Form
    {
        private MedicamentoServico medicamentoServico = new MedicamentoServico();
        private Medicamento medicamento;
        private MedicamentoRemover medicamentoRemover = new MedicamentoRemover();
        private List<String> options = new List<String>()
        {
            "Id",
            "Nome",
        };
        public MedicamentoConsultaForm()
        {
            InitializeComponent();
            AtualizarDGV();
            optionsCombo.DataSource = options;
        }

        private void AtualizarDGV()
        {
            medicamentosDGV.DataSource = null;
            medicamentosDGV.DataSource = medicamentoServico.ObterTodos();
        }

        private void PesqButton_Click(object sender, EventArgs e)
        {
            mostrarTodosButton.Visible = true;
            if (optionsCombo.SelectedIndex == 0)
            {
                try
                {
                    List<Medicamento> aux = new List<Medicamento>();
                    aux.Add(medicamentoServico.ObterPorID(Convert.ToInt64(nomeTxt.Text)));
                    medicamentosDGV.DataSource = aux;
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
                    medicamentosDGV.DataSource = medicamentoServico.BuscarPorNome(nomeTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o nome foi digitado corretamente");
                }
            }

        }

        private void ExamesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NomeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void OptionsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MedicamentosDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(medicamentosDGV.SelectedRows[0].Cells[0].Value);
            medicamento = medicamentoServico.ObterPorID(id);
            medicamentoServico.ObterAtendimentos(medicamento);
            string message = $"Nome: {medicamento.Nome}\nDosagem: {medicamento.Dosagem}\nDescrição: {medicamento.Descricao}";

            if (medicamento.AtendimentosMedicamento.Count == 0)
            {
                message += "\n\nNenhum atendimento cadastrado";
            }
            else
            {
                message += "\n\nAtendimentos: ";
                foreach (var atendimentoMedicamento in medicamento.AtendimentosMedicamento)
                {
                    message += $"\n   Atendimento: {atendimentoMedicamento.Atendimento.AtendimentoID}   Dia: {atendimentoMedicamento.Atendimento.Data}";
                }
            }
            MessageBox.Show(message);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(medicamentosDGV.SelectedRows[0].Cells[0].Value);
            medicamento = medicamentoServico.ObterPorID(id);
            MedicamentoCadastroForm medicamentoCadastroForm = new MedicamentoCadastroForm(medicamento);
            medicamentoCadastroForm.MdiParent = this.MdiParent;
            medicamentoCadastroForm.Show();
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(medicamentosDGV.SelectedRows[0].Cells[0].Value);
            medicamento = medicamentoServico.ObterPorID(id);
            medicamentoServico.ObterAtendimentos(medicamento);

            DialogResult result = DialogResult.Yes;

            if (medicamento.AtendimentosMedicamento.Count > 0)
            {
                result = MessageBox.Show("Existem atendimentos associados a este medicamento.\n" +
                    "Exclui-lo, excluirá também todos os atendimentos que o contenham.\n" +
                    "Continuar?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
            }

            if (result == DialogResult.Yes)
            {
                medicamentoRemover.Remover(medicamento);
                MessageBox.Show("Excluído com sucesso");
                AtualizarDGV();
            }
        }

        private void MedicamentoConsultaForm_Load(object sender, EventArgs e)
        {

        }

        private void MedicamentoConsultaForm_Activated(object sender, EventArgs e)
        {
            AtualizarDGV();
        }

        private void MostrarTodosButton_Click(object sender, EventArgs e)
        {
            AtualizarDGV();
        }
    }
}
