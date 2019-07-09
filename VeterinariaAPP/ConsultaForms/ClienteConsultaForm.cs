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
    public partial class ClienteConsultaForm : Form
    {
        private ClienteServico clienteServico = new ClienteServico();
        private Cliente cliente;
        private ClienteRemover clienteRemover = new ClienteRemover();
        public ClienteConsultaForm()
        {
            InitializeComponent();
            optionsCombo.DataSource = options;
            AtualizarDGV();
        }

        private List<String> options = new List<String>()
        {
            "Id",
            "Nome",
            "CPF",
        };

        private void AtualizarDGV()
        {
            clientesDGV.DataSource = null;
            clientesDGV.DataSource = clienteServico.ObterTodos();
        }

        private void ClientesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CPFTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPFLabel_Click(object sender, EventArgs e)
        {

        }

        private void NomeLabel_Click(object sender, EventArgs e)
        {

        }
       

        private void PesqButton_Click(object sender, EventArgs e)
        {
            mostrarTodosButton.Visible = true;
            if (optionsCombo.SelectedIndex == 0)
            {
                try
                {
                    List<Cliente> aux = new List<Cliente>();
                    aux.Add(clienteServico.ObterPorID(Convert.ToInt64(nomeTxt.Text)));
                    clientesDGV.DataSource = aux;
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
                    clientesDGV.DataSource = clienteServico.BuscarPorNome(nomeTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o nome foi digitado corretamente");
                }
            }
            else if (optionsCombo.SelectedIndex == 2)
            {
                try
                {
                    clientesDGV.DataSource = clienteServico.BuscarPorCPF(nomeTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o CPF foi digitado corretamente");
                }
            }
        }

        private void ClientesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(clientesDGV.SelectedRows[0].Cells[0].Value);
            cliente = clienteServico.ObterPorID(id);
            clienteServico.ObterAnimais(cliente);
            string message = $"Nome: {cliente.Nome}\nCPF: {cliente.CPF}";

            if (cliente.Animais.Count == 0)
            {
                message += "\n\nNenhum animal cadastrado";
            }
            else
            {
                message += "\n\nAnimais: ";
                foreach (var animal in cliente.Animais)
                {
                    message += $"\n   {animal.Nome}";
                }
            }
            
            MessageBox.Show(message);    
        }

        private void ClienteConsultaForm_Load(object sender, EventArgs e)
        {

        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(clientesDGV.SelectedRows[0].Cells[0].Value);
            cliente = clienteServico.ObterPorID(id);
            ClienteCadastroForm clienteCadastroForm = new ClienteCadastroForm(cliente);
            clienteCadastroForm.MdiParent = this.MdiParent;
            clienteCadastroForm.Show();
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(clientesDGV.SelectedRows[0].Cells[0].Value);
            cliente = clienteServico.ObterPorID(id);
            clienteServico.ObterAnimais(cliente);

            DialogResult result = DialogResult.Yes;

            if (cliente.Animais.Count > 0)
            {
                result = MessageBox.Show("Existem animais associados a este cliente.\n" +
                    "Exclui-lo, excluirá também todos seus animais, e os atendimentos de seus animais.\n" +
                    "Continuar?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
            }

            if (result == DialogResult.Yes)
            {
                clienteRemover.Remover(cliente);
                MessageBox.Show("Excluído com sucesso");
                AtualizarDGV();
            }
        }

        private void HistoricoButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(clientesDGV.SelectedRows[0].Cells[0].Value);
            cliente = clienteServico.ObterPorID(id);

            HistoricoHumanoForm historicoHumanoForm = new HistoricoHumanoForm(cliente);
            historicoHumanoForm.MdiParent = this.MdiParent;
            historicoHumanoForm.Show();
        }

        private void ClienteConsultaForm_Activated(object sender, EventArgs e)
        {
            AtualizarDGV();
        }

        private void MostrarTodosButton_Click(object sender, EventArgs e)
        {
            AtualizarDGV();
        }
    }
}
