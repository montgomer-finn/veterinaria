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

namespace VeterinariaAPP.OutroForms
{
    public partial class PagamentoContaReceberForm : Form
    {
        private ContaReceber contaReceber;
        private ContaReceberServico contaReceberServico = new ContaReceberServico();
        private CaixaServico caixaServico = new CaixaServico();
        public PagamentoContaReceberForm(ContaReceber contaReceber)
        {
            InitializeComponent();
            this.contaReceber = contaReceber;
            contaIDTxt.Text = Convert.ToString(contaReceber.ContaReceberID);
            valorTotalTxt.Text = Convert.ToString(contaReceber.ValorTotal);
            valorAbatidoTxt.Text = Convert.ToString(contaReceber.ValorAbatido);
        }

        private void PagarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToDouble(valorPagoTxt.Text) > contaReceber.ValorTotal - contaReceber.ValorAbatido)
                {
                    MessageBox.Show("Não é possível pagar um valor superior ao valor restante da parcela");
                }
                else
                {
                    contaReceber.ValorAbatido += Convert.ToDouble(valorPagoTxt.Text);
                    contaReceberServico.Atualizar(contaReceber);
                    caixaServico.Inserir(new Caixa(DateTime.Now, Convert.ToDouble(valorPagoTxt.Text), null, contaReceber.ContaReceberID));
                    MessageBox.Show("Pagamento efetuado com sucesso");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar pagamento.\nConfira se o valor digitado está em um formato váldo.");
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
