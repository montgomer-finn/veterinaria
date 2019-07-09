using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Servico;

namespace VeterinariaAPP
{
    public partial class ClienteCadastroForm : Form
    {
        private ClienteServico clienteServico = new ClienteServico();
        private VeterinarioServico veterinarioServico = new VeterinarioServico();
        private Cliente cliente;
        public ClienteCadastroForm()
        {
            InitializeComponent();
            
        }

        public ClienteCadastroForm(Cliente cliente)
        {
            InitializeComponent();
            nomeTxt.Text = cliente.Nome;
            CPFTxt.Text = Convert.ToString(cliente.CPF);
        }

        private void ResetarCampos()
        {
            nomeTxt.Text = null;
            CPFTxt.Text = null;
        }
        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente == null)
                {
                    if (clienteServico.BuscarPorCPF(CPFTxt.Text).Count > 0 || veterinarioServico.BuscarPorCPF(CPFTxt.Text).Count > 0)
                        MessageBox.Show("Não é possível cadastrar duas pessoas com o mesmo CPF");

                    else
                    {
                        cliente = new Cliente(nomeTxt.Text, CPFTxt.Text);
                        clienteServico.Inserir(cliente);
                        MessageBox.Show("Gravado com sucesso");
                        this.Close();
                    }
                }
                else
                {
                    cliente.Nome = nomeTxt.Text;
                    cliente.CPF = CPFTxt.Text;
                    clienteServico.Atualizar(cliente);
                    MessageBox.Show("Gravado com sucesso");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao gravar animal.\nConfira se os dados estão preenchidos corretamente");
            }
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

      

        private void LimparButton_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClienteCadastroForm_Load(object sender, EventArgs e)
        {

        }
    }
}
