using Modelo;
using Servico.Helpers;
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
using VeterinariaAPP.CadastroForms;

namespace VeterinariaAPP.ConsultaForms
{
    public partial class TipoConsultaForm : Form
    {
        private TipoServico tipoServico = new TipoServico();
        private Tipo tipo;
        private TipoRemover tipoRemover = new TipoRemover();
        private List<String> options = new List<String>()
        {
            "Id",
            "Nome",
        };
        public TipoConsultaForm()
        {
            InitializeComponent();
            AtualizarDGV();
            optionsCombo.DataSource = options;
        }

        private void AtualizarDGV()
        {
            tiposDGV.DataSource = null;
            tiposDGV.DataSource = tipoServico.ObterTodos();
        }

        private void PesqButton_Click(object sender, EventArgs e)
        {
            mostrarTodosButton.Visible = true;
            if (optionsCombo.SelectedIndex == 0)
            {
                try
                {
                    List<Tipo> aux = new List<Tipo>();
                    aux.Add(tipoServico.ObterPorID(Convert.ToInt64(nomeTxt.Text)));
                    tiposDGV.DataSource = aux;
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
                    tiposDGV.DataSource = tipoServico.BuscarPorNome(nomeTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o nome foi digitado corretamente");
                }
            }
        }

        private void TiposDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(tiposDGV.SelectedRows[0].Cells[0].Value);
            tipo = tipoServico.ObterPorID(id);
            tipoServico.ObterAnimais(tipo);
            string message = $"Nome: {tipo.Nome}";

            if (tipo.Animais.Count == 0)
            {
                message += "\n\nNenhum animal cadastrado";
            }
            else
            {
                message += "\n\nAnimais: ";
                foreach (var animal in tipo.Animais)
                {
                    message += $"\n   {animal.Nome}";
                }
            }

            MessageBox.Show(message);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tiposDGV.SelectedRows[0].Cells[0].Value);
            tipo = tipoServico.ObterPorID(id);
            TipoCadastroForm tipoCadastroForm = new TipoCadastroForm(tipo);
            tipoCadastroForm.MdiParent = this.MdiParent;
            tipoCadastroForm.Show();
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tiposDGV.SelectedRows[0].Cells[0].Value);
            tipo = tipoServico.ObterPorID(id);
            tipoServico.ObterAnimais(tipo);

            DialogResult result = DialogResult.Yes;

            if (tipo.Animais.Count > 0)
            {
                result = MessageBox.Show("Existem animais associados a este tipo.\n" +
                    "Exclui-lo, excluirá também todos seus animais, e os atendimentos de seus animais.\n" +
                    "Continuar?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
            }

            if (result == DialogResult.Yes)
            {
                tipoRemover.Remover(tipo);
                MessageBox.Show("Excluído com sucesso");
                AtualizarDGV();
            }
        }

        private void TipoConsultaForm_Activated(object sender, EventArgs e)
        {
            AtualizarDGV();
        }

        private void MostrarTodosButton_Click(object sender, EventArgs e)
        {
            AtualizarDGV();
        }
    }
}
