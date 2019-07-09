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
    public partial class VeterinarioCadastroForm : Form
    {
        private VeterinarioServico veterinarioServico = new VeterinarioServico();
        private ClienteServico clienteServico = new ClienteServico();
        Veterinario veterinario;

        public VeterinarioCadastroForm()
        {
            InitializeComponent();
        }

        public VeterinarioCadastroForm(Veterinario veterinario)
        {
            InitializeComponent();
            nomeTxt.Text = veterinario.Nome;
            CPFTxt.Text = veterinario.CPF;
        }
        private void ResetarCampos()
        {
            nomeTxt.Text = null;
            CPFTxt.Text = null;
            
        }

        private void VeterinarioForm_Load(object sender, EventArgs e)
        {

        }


        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (veterinario == null)
                {
                    if (clienteServico.BuscarPorCPF(CPFTxt.Text).Count > 0 || veterinarioServico.BuscarPorCPF(CPFTxt.Text).Count > 0)
                        MessageBox.Show("Não é possível cadastrar duas pessoas com o mesmo CPF");

                    else
                    {
                        veterinario = new Veterinario(nomeTxt.Text, CPFTxt.Text);
                        veterinarioServico.Inserir(veterinario);
                        MessageBox.Show("Gravado com sucesso");
                        this.Close();
                    }
                }
                else
                {
                    veterinario.Nome = nomeTxt.Text;
                    veterinario.CPF = CPFTxt.Text;
                    veterinarioServico.Atualizar(veterinario);
                    MessageBox.Show("Gravado com sucesso");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao gravar veterinario.\nConfira se os dados estão preenchidos corretamente");
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
