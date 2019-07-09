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
using VeterinariaAPP.OutroForms;

namespace VeterinariaAPP.ConsultaForms
{
    public partial class VeterinarioConsultaForm : Form
    {
        private VeterinarioServico veterinarioServico = new VeterinarioServico();
        private Veterinario veterinario;
        private VeterinarioRemover veterinarioRemover = new VeterinarioRemover();

        private List<String> options = new List<String>()
        {
            "Id",
            "Nome",
            "CPF",
        };

        private void AtualizarDGV()
        {
            veterinariosDGV.DataSource = null;
            veterinariosDGV.DataSource = veterinarioServico.ObterTodos();
        }

        public VeterinarioConsultaForm()
        {
            InitializeComponent();
            AtualizarDGV();
            optionsCombo.DataSource = options;
        }

        private void VeterinariosDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(veterinariosDGV.SelectedRows[0].Cells[0].Value);
            veterinario = veterinarioServico.ObterPorID(id);
            veterinarioServico.ObterAnimais(veterinario);
            string message = $"Nome: {veterinario.Nome}\nCPF: {veterinario.CPF}";

            if (veterinario.Animais.Count == 0)
            {
                message += "\n\nNenhum animal cadastrado";
            }
            else
            {
                message += "\n\nAnimais: ";
                foreach (var animal in veterinario.Animais)
                {
                    message += $"\n   {animal.Nome}";
                }
            }

            MessageBox.Show(message);
        }

        private void PesqButton_Click(object sender, EventArgs e)
        {
            mostrarTodosButton.Visible = true;
            if (optionsCombo.SelectedIndex == 0)
            {
                try
                {
                    List<Veterinario> aux = new List<Veterinario>();
                    aux.Add(veterinarioServico.ObterPorID(Convert.ToInt64(nomeTxt.Text)));
                    veterinariosDGV.DataSource = aux;
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o ID foi digitado corretamente");
                }
            }
            else if (optionsCombo.SelectedIndex == 1)
                try
                {
                    veterinariosDGV.DataSource = veterinarioServico.BuscarPorNome(nomeTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o nome foi digitado corretamente");
                }
            else if (optionsCombo.SelectedIndex == 2)
            {
                try
                {
                    veterinariosDGV.DataSource = veterinarioServico.BuscarPorCPF(nomeTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o CPF foi digitado corretamente");
                }
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(veterinariosDGV.SelectedRows[0].Cells[0].Value);
            veterinario = veterinarioServico.ObterPorID(id);
            VeterinarioCadastroForm veterinarioCadastroForm = new VeterinarioCadastroForm(veterinario);
            veterinarioCadastroForm.MdiParent = this.MdiParent;
            veterinarioCadastroForm.Show();
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(veterinariosDGV.SelectedRows[0].Cells[0].Value);
            veterinario = veterinarioServico.ObterPorID(id);

            veterinarioServico.ObterAnimais(veterinario);

            DialogResult result = DialogResult.Yes;
            string message = "";
            bool restricao = false;

            if (veterinario.Animais.Count > 0)
            {
                message = "Existem animais associados a este veterinario.\n" +
                    "Exclui-lo, excluirá também todos seus animais, e os atendimentos de seus animais.\n";
                restricao = true;
            }

            veterinarioServico.ObterAtendimentos(veterinario);

            if (veterinario.Atendimentos.Count > 0)
            {
                message += "Existem atendimentos associados a este veterinario.\n" +
                    "Exclui-lo, excluirá também todos os seus atendimentos.\n";
                restricao = true;
            }

            if(restricao == true)
            {
                message += "\nContinuar?";
                result = MessageBox.Show(message, "Confirmar Exclusão", MessageBoxButtons.YesNo);
            }

            if (result == DialogResult.Yes)
            {
                veterinarioRemover.Remover(veterinario);
                MessageBox.Show("Excluído com sucesso");
                AtualizarDGV();
            }
        }

        private void HistoricoButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(veterinariosDGV.SelectedRows[0].Cells[0].Value);
            veterinario = veterinarioServico.ObterPorID(id);

            HistoricoHumanoForm historicoHumanoForm = new HistoricoHumanoForm(veterinario);
            historicoHumanoForm.MdiParent = this.MdiParent;
            historicoHumanoForm.Show();
        }

        private void VeterinarioConsultaForm_Activated(object sender, EventArgs e)
        {
            AtualizarDGV();
        }

        private void MostrarTodosButton_Click(object sender, EventArgs e)
        {
            AtualizarDGV();
        }
    }
}
