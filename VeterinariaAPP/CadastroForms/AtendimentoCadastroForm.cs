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
    public partial class AtendimentoCadastroForm : Form
    {
        private AtendimentoBuilder atendimentoBuilder;
        private AtendimentoEditor atendimentoEditor;
        private AtendimentoServico atendimentoServico = new AtendimentoServico();

        private Exame exame;
        private Medicamento medicamento;
        private Atendimento atendimento;

        private List<Exame> exames = new List<Exame>();
        private List<Medicamento> medicamentos = new List<Medicamento>();

        private ExameServico exameServico = new ExameServico();
        private MedicamentoServico medicamentoServico = new MedicamentoServico();
        private VeterinarioServico veterinarioServico = new VeterinarioServico();
        private AnimalServico animalServico = new AnimalServico();

        public AtendimentoCadastroForm()
        {
            InitializeComponent();
        }

        public AtendimentoCadastroForm(Atendimento atendimento)
        {
            InitializeComponent();

            if(atendimento.Realizado == true)
            {
                MessageBox.Show("Não é possível editar um atendimento já realizado");
                this.Close();
            }

            this.atendimento = atendimento;

            atendimentoServico.ObterExames(atendimento);
            foreach (var exame in atendimento.AtendimentoExames)
            {
                exames.Add(exame.Exame);
            }
            AtualizarExamesDGV();

            atendimentoServico.ObterMedicamentos(atendimento);
            foreach(var medicamento in atendimento.AtendimentoMedicamentos)
            {
                medicamentos.Add(medicamento.Medicamento);
            }
            AtualizarMedicamentosDGV();

            dataRealizacaoTxt.Text = Convert.ToString(atendimento.Data);
            veterinarioTxt.Text = Convert.ToString(atendimento.VeterinarioID);
            animalTxt.Text = Convert.ToString(atendimento.AnimalID);
            descTxt.Text = atendimento.Descricao;
            realizadoButtonNao.Checked = true;
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ExameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ResetarCampos()
        {
            exames.Clear();
            medicamentos.Clear();
            exame = null;
            medicamento = null;
            AtualizarMedicamentosDGV();
            AtualizarExamesDGV();
            dataRealizacaoTxt.Text = null;
            veterinarioTxt.Text = null;
            animalTxt.Text = null;
            descTxt.Text = null;
            exameTxt.Text = null;
            precoTxt.Text = null;
            medicamentoTxt.Text = null;
        }

        private void AtualizarPrecoTotal()
        {
            double aux = 0;
            try
            {
                aux = Convert.ToDouble(precoTxt.Text);
            }
            catch
            {
            }
            foreach(var exame in exames)
            {
                aux += exame.Preco;
            }
            precoTotalTxt.Text = Convert.ToString(aux);
        }

        private void AtualizarExamesDGV()
        {
            examesDGV.DataSource = null;
            examesDGV.DataSource = exames;
        }

        private void AtualizarMedicamentosDGV()
        {
            medicamentosDGV.DataSource = null;
            medicamentosDGV.DataSource = medicamentos;
        }

        private void AdicionarExameButton_Click(object sender, EventArgs e)
        {
            try
            {
                exame = exameServico.ObterPorID(Convert.ToInt64(exameTxt.Text));
                if(exame == null)
                {
                    throw new Exception();
                }
                else
                {
                    exameTxt.Text = null;
                    exames.Add(exame);
                    exame = null;
                    AtualizarPrecoTotal();
                    AtualizarExamesDGV();
                }
            }
            catch
            {
                MessageBox.Show("Exame não encontrado");
            }
        }

        private void AdicionarMedicamentoButton_Click(object sender, EventArgs e)
        {
            try
            {
                medicamento = medicamentoServico.ObterPorID(Convert.ToInt64(medicamentoTxt.Text));
                if (medicamento == null)
                {
                    throw new Exception();
                }
                else
                {
                    medicamentoTxt.Text = null;
                    medicamentos.Add(medicamento);
                    medicamento = null;
                    AtualizarMedicamentosDGV();
                }
               
            }
            catch
            {
                MessageBox.Show("Medicamento não encontrado");
            }
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (atendimento == null)
                {
                    atendimentoBuilder = new AtendimentoBuilder()
                        .ComDescricao(descTxt.Text)
                        .ComVeterinario(veterinarioServico.ObterPorID(Convert.ToInt64(veterinarioTxt.Text)))
                        .ParaAnimal(animalServico.ObterPorID(Convert.ToInt64(animalTxt.Text)))
                        .NaData(Convert.ToDateTime(dataRealizacaoTxt.Text));

                    foreach (var exame in exames)
                    {
                        atendimentoBuilder.ComExame(exame);
                    }

                    foreach (var medicamento in medicamentos)
                    {
                        atendimentoBuilder.ComMedicamento(medicamento);
                    }

                    if (realizadoButtonSim.Checked == true)
                    {
                        atendimentoBuilder.JaRealizado();
                        atendimentoBuilder.PrecoAtendimento(Convert.ToDouble(precoTxt.Text));
                        if (aVistaButton.Checked == true)
                        {
                            atendimentoBuilder.PagamentoAVista();
                        }
                        if (aPrazoButton.Checked == true)
                        {
                            atendimentoBuilder.PagamentoParcelado(Convert.ToInt32(numeroParcealsTxt.Text), Convert.ToInt32(diaParcelaTxt.Text));
                        }
                    }

                    atendimentoBuilder.Build();

                }
                else
                {
                    atendimentoEditor = new AtendimentoEditor(atendimento)
                        .ComDescricao(descTxt.Text)
                        .ComVeterinario(veterinarioServico.ObterPorID(Convert.ToInt64(veterinarioTxt.Text)))
                        .ParaAnimal(animalServico.ObterPorID(Convert.ToInt64(animalTxt.Text)))
                        .NaData(Convert.ToDateTime(dataRealizacaoTxt.Text));

                    foreach (var exame in exames)
                    {
                        atendimentoEditor.ComExame(exame);
                    }

                    foreach (var medicamento in medicamentos)
                    {
                        atendimentoEditor.ComMedicamento(medicamento);
                    }

                    if (realizadoButtonSim.Checked == true)
                    {
                        atendimentoEditor.JaRealizado();
                        atendimentoEditor.PrecoAtendimento(Convert.ToDouble(precoTxt.Text));
                        if (aVistaButton.Checked == true)
                        {
                            atendimentoEditor.PagamentoAVista();
                        }
                        if (aPrazoButton.Checked == true)
                        {
                            atendimentoEditor.PagamentoParcelado(Convert.ToInt32(numeroParcealsTxt.Text), Convert.ToInt32(diaParcelaTxt.Text));
                        }
                    }

                    atendimentoEditor.Edit();
                }

                this.Close();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao gravar atendimento.\nConfira se os dados estão preenchidos corretamente");
            }
        }

        private void RemoverExameButton_Click(object sender, EventArgs e)
        {
            if (examesDGV.SelectedRows.Count == 1)
            {
                foreach (var exame in exames)
                {
                    if (exame.ExameID == Convert.ToInt64(examesDGV.SelectedRows[0].Cells[0].Value))
                    {
                        exames.Remove(exame);
                        break;
                    }
                }
            }
            else if (examesDGV.SelectedRows.Count > 1) {
                MessageBox.Show("Selecione apenas um registro");
            }
            else
            {
                try
                {
                    foreach (var exame in exames)
                    {
                        if (exame.ExameID == Convert.ToInt64(exameTxt.Text))
                        {
                            exames.Remove(exame);
                            break;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Exame inválido");
                }
            }

            AtualizarPrecoTotal();
            AtualizarExamesDGV();
        }

        private void RemoverMedicamentoButton_Click(object sender, EventArgs e)
        {
            if (medicamentosDGV.SelectedRows.Count == 1)
            {
                foreach (var medicamento in medicamentos)
                {
                    if (medicamento.MedicamentoID == Convert.ToInt64(medicamentosDGV.SelectedRows[0].Cells[0].Value))
                    {
                        medicamentos.Remove(medicamento);
                        break;
                    }
                }
            }
            else if (medicamentosDGV.SelectedRows.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro");
            }
            else
            {
                try
                {
                    foreach (var medicamento in medicamentos)
                    {
                        if (medicamento.MedicamentoID == Convert.ToInt64(medicamentoTxt.Text))
                        {
                            medicamentos.Remove(medicamento);
                            break;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Medicamento inválido");
                }
            }
            AtualizarMedicamentosDGV();
        }

        

        private void ExamesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MedicamentosDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void RealizadoButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            if(realizadoButtonSim.Checked == true) {
                pagamentoBox.Visible = true;
            }
        }

        private void RealizadoButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            if(realizadoButtonNao.Checked == true)
            {
                pagamentoBox.Visible = false;
            }
        }

        private void PrecoTxt_TextChanged(object sender, EventArgs e)
        {
            AtualizarPrecoTotal();
        }
    }
}
