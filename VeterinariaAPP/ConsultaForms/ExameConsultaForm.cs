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
    public partial class ExameConsultaForm : Form
    {
        private ExameServico exameServico = new ExameServico();
        private Exame exame;
        private ExameRemover exameRemover = new ExameRemover();
        private List<String> options = new List<String>()
        {
            "Id",
            "Nome",
        };

        public ExameConsultaForm()
        {
            InitializeComponent();
            AtualizarDGV();
            optionsCombo.DataSource = options;
        }

        private void ResetarCampos()
        {
            nomeTxt.Text = null;
            exame = null;  
        }

        private void AtualizarDGV()
        {
            examesDGV.DataSource = null;
            examesDGV.DataSource = exameServico.ObterTodos();
        }


        private void PesqButton_Click(object sender, EventArgs e)
        {
            mostrarTodosButton.Visible = true;
            if (optionsCombo.SelectedIndex == 0)
            {
                try
                {
                    List<Exame> aux = new List<Exame>();
                    aux.Add(exameServico.ObterPorID(Convert.ToInt64(nomeTxt.Text)));
                    examesDGV.DataSource = aux;
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
                    examesDGV.DataSource = exameServico.BuscarPorNome(nomeTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o nome foi digitado corretamente");
                }
            }
        }

        private void Exames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(examesDGV.SelectedRows[0].Cells[0].Value);
            exame = exameServico.ObterPorID(id);
            exameServico.ObterAtendimentos(exame);
            string message = $"Nome: {exame.Nome}\nPreco: {exame.Preco}\nDescrição: {exame.Descricao}";

            if (exame.AtendimentosExame.Count == 0)
            {
                message += "\n\nNenhum atendimento cadastrado";
            }
            else
            {
                message += "\n\nAtendimentos: ";
                foreach (var atendimentoExame in exame.AtendimentosExame)
                {
                    message += $"\n   Atendimento: {atendimentoExame.Atendimento.AtendimentoID}   Dia: {atendimentoExame.Atendimento.Data}";
                }
            }
            MessageBox.Show(message);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(examesDGV.SelectedRows[0].Cells[0].Value);
            exame = exameServico.ObterPorID(id);
            ExameCadastroForm exameCadastroForm = new ExameCadastroForm(exame);
            exameCadastroForm.MdiParent = this.MdiParent;
            exameCadastroForm.Show();
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(examesDGV.SelectedRows[0].Cells[0].Value);
            exame = exameServico.ObterPorID(id);
            exameServico.ObterAtendimentos(exame);

            DialogResult result = DialogResult.Yes;

            if (exame.AtendimentosExame.Count > 0)
            {
                result = MessageBox.Show("Existem atendimentos associados a este exame.\n" +
                    "Exclui-lo, excluirá também os atendimentos que o possuem.\n" +
                    "Continuar?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
            }

            if (result == DialogResult.Yes)
            {
                exameRemover.Remover(exame);
                MessageBox.Show("Excluído com sucesso");
                ResetarCampos();
                AtualizarDGV();
            }
        }

        private void ExameConsultaForm_Activated(object sender, EventArgs e)
        {
            AtualizarDGV();
        }

        private void MostrarTodosButton_Click(object sender, EventArgs e)
        {
            AtualizarDGV();
        }
    }
}
