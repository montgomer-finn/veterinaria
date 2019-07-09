using Humanizer;
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
    public partial class AnimalConsultaForm : Form
    {
        private AnimalServico animalServico = new AnimalServico();
        private Animal animal;
        private AnimalRemover animalRemover = new AnimalRemover();
        private List<String> options = new List<String>()
        {
            "Id",
            "Nome",
            "HumanoID",
        };


        public AnimalConsultaForm()
        {
            InitializeComponent();
            optionsCombo.DataSource = options;
            AtualizarDados();
        }

        private void ResetarCampos()
        {
            nomeTxt.Text = null;
            animal = null;
        }
      
        private void AtualizarDados()
        {
            animaisDGV.DataSource = null;
            animaisDGV.DataSource = (from animal in animalServico.ObterTodos() select new { animal.AnimalID, animal.Nome, animal.TipoID, animal.DataNascimento, animal.HumanoID }).ToList();
        }
        
        private void AnimaisDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(animaisDGV.SelectedRows[0].Cells[0].Value);
            animal = animalServico.ObterPorID(id);
            animalServico.ObterHumano(animal);
            animalServico.ObterTipo(animal);
            string message = $"Nome: {animal.Nome}\nTipo: {animal.Tipo.Nome}\nIdade: {(DateTime.Now - animal.DataNascimento).Humanize()}\nHumano: {animal.Humano.Nome}";
            MessageBox.Show(message, "Detalhes");
            
            ResetarCampos();
        }

        private void PesqButton_Click(object sender, EventArgs e)
        {
            mostrarTodosButton.Visible = true;
            if (optionsCombo.SelectedIndex == 0)
            {
                try
                {
                    List<Animal> aux = new List<Animal>();
                    aux.Add(animalServico.ObterPorID(Convert.ToInt64(nomeTxt.Text)));
                    animaisDGV.DataSource = (from animal in aux select new { animal.AnimalID, animal.Nome, animal.TipoID, animal.DataNascimento, animal.HumanoID }).ToList();
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
                    animaisDGV.DataSource = (from animal in animalServico.BuscarPorNome(nomeTxt.Text) select new { animal.AnimalID, animal.Nome, animal.TipoID, animal.DataNascimento, animal.HumanoID }).ToList();
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
                    animaisDGV.DataSource = (from animal in animalServico.BuscarPorHumanoID(Convert.ToInt64(nomeTxt.Text)) select new { animal.AnimalID, animal.Nome, animal.TipoID, animal.DataNascimento, animal.HumanoID }).ToList();
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o HumanoID foi digitado corretamente");
                }
            }
        }

        private void OptionsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NomeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(animaisDGV.SelectedRows[0].Cells[0].Value);
            animal = animalServico.ObterPorID(id);

            AnimalCadastroForm animalCadastroForm = new AnimalCadastroForm(animal);
            animalCadastroForm.MdiParent = this.MdiParent;
            animalCadastroForm.Show();
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(animaisDGV.SelectedRows[0].Cells[0].Value);
            animal = animalServico.ObterPorID(id);
            animalServico.ObterAtendimentos(animal);
            DialogResult result = DialogResult.Yes;

            if (animal.Atendimentos.Count > 0)
            {
                result = MessageBox.Show("Existem atendimentos associados a este animal.\n" +
                    "Exclui-lo, excluirá também todos seus atendimentos.\n" +
                    "Continuar?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
            }

            if(result == DialogResult.Yes)
            {
                animalRemover.Remover(animal);
                MessageBox.Show("Excluido com sucesso.");
                ResetarCampos();
            }
        }

        private void ProtuarioButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(animaisDGV.SelectedRows[0].Cells[0].Value);
            animal = animalServico.ObterPorID(id);
            ProntuarioForm prontuarioForm = new ProntuarioForm(animal);
            prontuarioForm.MdiParent = this.MdiParent;
            prontuarioForm.Show();
        }

        private void AnimalConsultaForm_Activated(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private void MostrarTodosButton_Click(object sender, EventArgs e)
        {
            AtualizarDados();
        }
    }
}
