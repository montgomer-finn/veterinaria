using Modelo;
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

namespace VeterinariaAPP.CadastroForms
{
    public partial class TipoCadastroForm : Form
    {
        private TipoServico tipoServico = new TipoServico();
        private Tipo tipo;
        public TipoCadastroForm()
        {
            InitializeComponent();
        }

        public TipoCadastroForm(Tipo tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            nomeTxt.Text = tipo.Nome;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipo == null)
                {
                    tipo = new Tipo(nomeTxt.Text);
                    tipoServico.Inserir(tipo);
                }
                else
                {
                    tipo.Nome = nomeTxt.Text;
                    tipoServico.Atualizar(tipo);
                }

                MessageBox.Show("Gravado com sucesso");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao gravar tipo.\nConfira se os dados estão preenchidos corretamente");
            }
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void ResetarCampos()
        {
            nomeTxt.Text = null;
        }
    }
}
