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
using Humanizer;

namespace VeterinariaAPP.OutroForms
{
    public partial class CaixaForm : Form
    {
        private CaixaServico caixaServico = new CaixaServico();
        private AtendimentoServico atendimentoServico = new AtendimentoServico();
        private ContaReceberServico contaReceberServico = new ContaReceberServico();
        private AnimalServico animalServico = new AnimalServico();
        private Caixa caixa;
        private List<String> options = new List<String>()
        {
            "Id",
            "Data",
        };
        public CaixaForm()
        {
            InitializeComponent();
            AtualizarDGV();
            optionsCombo.DataSource = options;
        }

        private void AtualizarDGV()
        {
            caixasDGV.DataSource = null;
            caixasDGV.DataSource = (from caixa in caixaServico.ObterTodos() select new
                                    {
                                        caixa.CaixaID,
                                        caixa.AtendimentoID,
                                        caixa.ContaReceberID,
                                        caixa.Valor,
                                        caixa.Data
                                    }).ToList();
        }

        private void OptionsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(optionsCombo.SelectedIndex == 0)
            {
                nomeTxt.Visible = true;
                dateTimePicker.Visible = false;
            }
            else if(optionsCombo.SelectedIndex == 1)
            {
                dateTimePicker.Visible = true;
                nomeTxt.Visible = false;
            }
        }

        private void PesqButton_Click(object sender, EventArgs e)
        {
            if (optionsCombo.SelectedIndex == 0)
            {
                try
                {
                    List<Caixa> aux = new List<Caixa>();
                    aux.Add(caixaServico.ObterPorID(Convert.ToInt64(nomeTxt.Text)));
                    caixasDGV.DataSource = (from caixa in aux
                                            select new
                                            {
                                                caixa.CaixaID,
                                                caixa.AtendimentoID,
                                                caixa.ContaReceberID,
                                                caixa.Valor,
                                                caixa.Data
                                            }).ToList();
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
                    caixasDGV.DataSource = (from caixa in caixaServico.BuscarPorData(dateTimePicker.Value)
                                                 select new
                                                 {
                                                     caixa.CaixaID,
                                                     caixa.AtendimentoID,
                                                     caixa.ContaReceberID,
                                                     caixa.Valor,
                                                     caixa.Data
                                                 }).ToList();
                }
                catch
                {
                    MessageBox.Show("Não foi possível realizar a consulta. Verifique se o nome foi digitado corretamente");
                }
            }
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(caixasDGV.SelectedRows[0].Cells[0].Value);
            caixa = caixaServico.ObterPorID(id);
            caixaServico.ObterAtendimento(caixa);
            
            caixaServico.Remover(caixa.CaixaID);
            MessageBox.Show("Excluído com sucesso");
            AtualizarDGV();
            
        }

        private void CaixasDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(caixasDGV.SelectedRows[0].Cells[0].Value);
            caixa = caixaServico.ObterPorID(id);

            string message = "";

            if (caixa.AtendimentoID != null)
            {
                caixaServico.ObterAtendimento(caixa);
                atendimentoServico.ObterAnimal(caixa.Atendimento);
                animalServico.ObterHumano(caixa.Atendimento.Animal);
                atendimentoServico.ObterVeterinario(caixa.Atendimento);
                message += $"Caixa proveniente do atendimento{caixa.Atendimento.AtendimentoID}\n" +
                    $"Realizado para o animal {caixa.Atendimento.Animal.Nome}\n" +
                    $"Pertencente ao humano: {caixa.Atendimento.Animal.Humano.Nome}\n" +
                    $"Pelo veterinario {caixa.Atendimento.Veterinario.Nome}\n" +
                    $"{caixa.Atendimento.Data.Humanize()}";

            }else if(caixa.ContaReceberID != null)
            {
                caixaServico.ObterContaReceber(caixa);
                contaReceberServico.ObterAtendimento(caixa.ContaReceber);
                atendimentoServico.ObterAnimal(caixa.ContaReceber.Atendimento);
                animalServico.ObterHumano(caixa.ContaReceber.Atendimento.Animal);
                atendimentoServico.ObterVeterinario(caixa.ContaReceber.Atendimento);
                message += $"Caixa proveniente de parcela do atendimento{caixa.ContaReceber.Atendimento.AtendimentoID}\n" +
                    $"Realizado para o animal {caixa.ContaReceber.Atendimento.Animal}\n" +
                    $"Pertencente ao humano {caixa.ContaReceber.Atendimento.Animal.Humano.Nome}\n" +
                    $"Pelo veterinario {caixa.ContaReceber.Atendimento.Veterinario.Nome}\n" +
                    $"{caixa.ContaReceber.Atendimento.Data.Humanize()}";
            }

            MessageBox.Show(message, "Detalhes");
        }

        private void CaixaForm_Activated(object sender, EventArgs e)
        {
            AtualizarDGV();
        }
    }
}
