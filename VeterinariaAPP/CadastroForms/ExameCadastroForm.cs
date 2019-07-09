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

namespace VeterinariaAPP
{
    public partial class ExameCadastroForm : Form
    {
        private ExameServico exameServico = new ExameServico();
        private Exame exame;

        public ExameCadastroForm()
        {
            InitializeComponent();
        }

        public ExameCadastroForm(Exame exame)
        {
            InitializeComponent();
            this.exame = exame;
            nomeTxt.Text = exame.Nome;
            descText.Text = exame.Descricao;
            precoTxt.Text = Convert.ToString(exame.Preco);
        }

        private void ResetarCampos()
        {
            nomeTxt.Text = null;
            descText.Text = null;
            precoTxt.Text = null;
            exame = null;
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (exame == null)
                {
                    exame = new Exame(nomeTxt.Text, descText.Text, Convert.ToDouble(precoTxt.Text));
                    exameServico.Inserir(exame);
                }
                else
                {
                    exame.Nome = nomeTxt.Text;
                    exame.Preco = Convert.ToDouble(precoTxt.Text);
                    exame.Descricao = descText.Text;
                    exameServico.Atualizar(exame);
                }
                MessageBox.Show("Gravado com sucesso");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao gravar exame.\nConfira se os dados estão preenchidos corretamente");
            }
        }

        
        private void LimparButton_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }

       

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExameCadastroForm_Load(object sender, EventArgs e)
        {

        }
    }
}
