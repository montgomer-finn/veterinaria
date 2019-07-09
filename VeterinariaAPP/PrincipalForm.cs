using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaAPP.CadastroForms;
using VeterinariaAPP.ConsultaForms;
using VeterinariaAPP.OutroForms;

namespace VeterinariaAPP
{
    public partial class PrincipalForm : Form
    {
        private AnimalCadastroForm animalCadastroForm;
        private ClienteCadastroForm clienteCadastroForm;
        private VeterinarioCadastroForm veterinarioCadastroForm;
        private AtendimentoCadastroForm atendimentoCadastroForm;
        private ExameCadastroForm exameCadastroForm;
        private MedicamentoCadastroForm medicamentoCadastroForm;
        private TipoCadastroForm tipoCadastroForm;

        private AnimalConsultaForm animalConsultaForm;
        private ClienteConsultaForm clienteConsultaForm;
        private VeterinarioConsultaForm veterinarioConsultaForm;
        private ExameConsultaForm exameConsultaForm;
        private MedicamentoConsultaForm medicamentoConsultaForm;
        private AtendimentoConsultaForm atendimentoConsultaForm;
        private TipoConsultaForm tipoConsultaForm;
        private CaixaForm caixaForm;
        private ContaReceberForm contaReceberForm;

        private AgendaForm agendaForm;

        public PrincipalForm()
        {
            InitializeComponent();
        }


        private void AnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (animalCadastroForm != null && !animalCadastroForm.IsDisposed)
                animalCadastroForm.BringToFront();
            else
            {
                animalCadastroForm = new AnimalCadastroForm();
                animalCadastroForm.MdiParent = this;
                animalCadastroForm.Show();
            }
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clienteCadastroForm != null && !clienteCadastroForm.IsDisposed)
                clienteCadastroForm.BringToFront();
            else
            {
                clienteCadastroForm = new ClienteCadastroForm();
                clienteCadastroForm.MdiParent = this;
                clienteCadastroForm.Show();
            }
        }

        private void VeterinárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (veterinarioCadastroForm != null && !veterinarioCadastroForm.IsDisposed)
                veterinarioCadastroForm.BringToFront();
            else
            {
                veterinarioCadastroForm = new VeterinarioCadastroForm();
                veterinarioCadastroForm.MdiParent = this;
                veterinarioCadastroForm.Show();
            }
        }

        private void AtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (atendimentoCadastroForm != null && !atendimentoCadastroForm.IsDisposed)
                atendimentoCadastroForm.BringToFront();
            else
            {
                atendimentoCadastroForm = new AtendimentoCadastroForm();
                atendimentoCadastroForm.MdiParent = this;
                atendimentoCadastroForm.Show();
            }
        }

        private void ExameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exameCadastroForm != null && !exameCadastroForm.IsDisposed)
                exameCadastroForm.BringToFront();
            else
            {
                exameCadastroForm = new ExameCadastroForm();
                exameCadastroForm.MdiParent = this;
                exameCadastroForm.Show();
            }
        }

        private void MedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (medicamentoCadastroForm != null && !medicamentoCadastroForm.IsDisposed)
                medicamentoCadastroForm.BringToFront();
            else
            {
                medicamentoCadastroForm = new MedicamentoCadastroForm();
                medicamentoCadastroForm.MdiParent = this;
                medicamentoCadastroForm.Show();
            }
            
        }

        private void AnimaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (animalConsultaForm != null && !animalConsultaForm.IsDisposed)
                animalConsultaForm.BringToFront();
            else
            {
                animalConsultaForm = new AnimalConsultaForm();
                animalConsultaForm.MdiParent = this;
                animalConsultaForm.Show();
            }
        }

        private void ClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (clienteConsultaForm != null && !clienteConsultaForm.IsDisposed)
                clienteConsultaForm.BringToFront();
            else
            {
                clienteConsultaForm = new ClienteConsultaForm();
                clienteConsultaForm.MdiParent = this;
                clienteConsultaForm.Show();
            }
        }

        private void VeterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (veterinarioConsultaForm != null && !veterinarioConsultaForm.IsDisposed)
                veterinarioConsultaForm.BringToFront();
            else
            {
                veterinarioConsultaForm = new VeterinarioConsultaForm();
                veterinarioConsultaForm.MdiParent = this;
                veterinarioConsultaForm.Show();
            }
        }

        private void ExamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exameConsultaForm != null && !exameConsultaForm.IsDisposed)
                exameConsultaForm.BringToFront();
            else
            {
                exameConsultaForm = new ExameConsultaForm();
                exameConsultaForm.MdiParent = this;
                exameConsultaForm.Show();
            }
        }

        private void MedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (medicamentoConsultaForm != null && !medicamentoConsultaForm.IsDisposed)
                medicamentoConsultaForm.BringToFront();
            else
            {
                medicamentoConsultaForm = new MedicamentoConsultaForm();
                medicamentoConsultaForm.MdiParent = this;
                medicamentoConsultaForm.Show();
            }
        }

        private void AtendimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (atendimentoConsultaForm != null && !atendimentoConsultaForm.IsDisposed)
                atendimentoConsultaForm.BringToFront();
            else
            {
                atendimentoConsultaForm = new AtendimentoConsultaForm();
                atendimentoConsultaForm.MdiParent = this;
                atendimentoConsultaForm.Show();
            }
        }

        private void HojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (agendaForm != null)
                agendaForm.Close();
            else
            {
                agendaForm = new AgendaForm(DateTime.Now);
                agendaForm.MdiParent = this;
                agendaForm.Show();
            }
        }

        private void EstaSemanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (agendaForm != null)
                agendaForm.Close();

            DateTime dataInicio = DateTime.Now;
            DateTime dataFim = DateTime.Now;
            int c = 0, f = 0;

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday :
                    c = 0;
                    f = 6;
                    break;

                case DayOfWeek.Monday:
                    c = 1;
                    f = 5;
                    break;

                case DayOfWeek.Tuesday:
                    c = 2;
                    f = 4;
                    break;

                case DayOfWeek.Wednesday:
                    c = 3;
                    f = 3;
                    break;

                case DayOfWeek.Thursday:
                    c = 4;
                    f = 2;
                    break;

                case DayOfWeek.Friday:
                    c = 5;
                    f = 1;
                    break;

                case DayOfWeek.Saturday:
                    c = 6;
                    f = 0;
                    break;
            }

            for(int i=0; i<c; i++)
            {
                dataInicio = dataInicio.AddDays(-1);
            }

            for (int i = 0; i < f; i++)
            {
                dataFim = dataFim.AddDays(1);
            }

            agendaForm = new AgendaForm(dataInicio, dataFim);
            agendaForm.MdiParent = this;
            agendaForm.Show();
        }

        private void EsteMêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (agendaForm != null)
                agendaForm.Close();

            agendaForm = new AgendaForm(DateTime.Now.Month, DateTime.Now.Year);
            agendaForm.MdiParent = this;
            agendaForm.Show();
        }

        private void IntervaloEspecíficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (agendaForm != null)
                agendaForm.Close();

            agendaForm = new AgendaForm();
            agendaForm.MdiParent = this;
            agendaForm.Show();
        }

        private void TipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tipoCadastroForm != null && !tipoCadastroForm.IsDisposed) 
                tipoCadastroForm.BringToFront();
            else
            {
                tipoCadastroForm = new TipoCadastroForm();
                tipoCadastroForm.MdiParent = this;
                tipoCadastroForm.Show();
            }
        }

        private void TiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tipoConsultaForm != null && !tipoConsultaForm.IsDisposed)
                tipoConsultaForm.BringToFront();
            else
            {
                tipoConsultaForm = new TipoConsultaForm();
                tipoConsultaForm.MdiParent = this;
                tipoConsultaForm.Show();
            }
        }

        private void ContasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PagarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (caixaForm != null && !caixaForm.IsDisposed)
                caixaForm.BringToFront();
            else
            {
                caixaForm = new CaixaForm();
                caixaForm.MdiParent = this;
                caixaForm.Show();
            }
        }

        private void TodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contaReceberForm != null)
                contaReceberForm.Close();

            contaReceberForm = new ContaReceberForm();
            contaReceberForm.MdiParent = this;
            contaReceberForm.Show();
        }

        private void ContasÀReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contaReceberForm != null)
                contaReceberForm.Close();

            contaReceberForm = new ContaReceberForm();
            contaReceberForm.MdiParent = this;
            contaReceberForm.Show();
        }
    }
}
