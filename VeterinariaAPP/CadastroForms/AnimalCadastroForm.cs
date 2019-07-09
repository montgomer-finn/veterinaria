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

namespace VeterinariaAPP
{
    public partial class AnimalCadastroForm : Form
    {
        private AnimalServico animalServico = new AnimalServico();
        Animal animal;
        private TipoServico tipoServico = new TipoServico();
        private IList<Tipo> tipos = new List<Tipo>();
        public AnimalCadastroForm()
        {
            InitializeComponent();
        }

        public AnimalCadastroForm(Animal animal)
        {
            InitializeComponent();
            tipos = tipoServico.ObterTodos();
            this.animal = animal;
            nomeTxt.Text = animal.Nome;
            humanoTxt.Text = Convert.ToString(animal.HumanoID);
            dataNascimento.Text = Convert.ToString(animal.DataNascimento);
            tipoTxt.Text = Convert.ToString(animal.TipoID);
       }

        private void ResetarCampos()
        {
            nomeTxt.Text = null;
            humanoTxt.Text = null;
            dataNascimento.Text = null;
            animal = null;
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (animal == null)
                {
                    animal = new Animal(nomeTxt.Text, Convert.ToDateTime(dataNascimento.Text), Convert.ToInt64(humanoTxt.Text), Convert.ToInt64(tipoTxt.Text));
                    animalServico.Inserir(animal);
                }
                else
                {
                    animal.Nome = nomeTxt.Text;
                    animal.HumanoID = Convert.ToInt64(humanoTxt.Text);
                    animal.DataNascimento = Convert.ToDateTime(dataNascimento.Text);
                    animal.TipoID = Convert.ToInt64(tipoTxt.Text);
                    animalServico.Atualizar(animal);
                }
                MessageBox.Show("Gravado com sucesso");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao gravar animal.\nConfira se os dados estão preenchidos corretamente");
            }
        }

        
        private void LimparButton_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void AnimalForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
