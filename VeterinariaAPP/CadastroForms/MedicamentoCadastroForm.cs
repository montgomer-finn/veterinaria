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
    public partial class MedicamentoCadastroForm : Form
    {
        private MedicamentoServico medicamentoServico = new MedicamentoServico();
        private Medicamento medicamento;
        public MedicamentoCadastroForm()
        {
            InitializeComponent();
        }

        public MedicamentoCadastroForm(Medicamento medicamento)
        {
            InitializeComponent();
            this.medicamento = medicamento;
            nomeTxt.Text = medicamento.Nome;
            dosagemText.Text = Convert.ToString(medicamento.Dosagem);
            descText.Text = medicamento.Descricao;
        }

        private void NomeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetarCampos()
        {
            nomeTxt.Text = null;
            dosagemText.Text = null;
            descText.Text = null;
            medicamento = null;
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (medicamento == null)
                {
                    medicamento = new Medicamento(nomeTxt.Text, Convert.ToDouble(dosagemText.Text), descText.Text);
                    medicamentoServico.Inserir(medicamento);
                }
                else
                {
                    medicamento.Nome = nomeTxt.Text;
                    medicamento.Dosagem = Convert.ToDouble(dosagemText.Text);
                    medicamento.Descricao = descText.Text;
                    medicamentoServico.Atualizar(medicamento);
                }
                MessageBox.Show("Gravado com sucesso");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao gravar medicamento.\nConfira se os dados estão preenchidos corretamente");
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
    }
}
