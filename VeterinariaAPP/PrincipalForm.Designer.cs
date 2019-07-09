namespace VeterinariaAPP
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hojeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estaSemanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esteMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervaloEspecíficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasÀReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.contasAReceberToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalToolStripMenuItem,
            this.humanoToolStripMenuItem,
            this.atendimentoToolStripMenuItem,
            this.exameToolStripMenuItem,
            this.medicamentoToolStripMenuItem,
            this.tipoToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // animalToolStripMenuItem
            // 
            this.animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            this.animalToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.animalToolStripMenuItem.Text = "Animal";
            this.animalToolStripMenuItem.Click += new System.EventHandler(this.AnimalToolStripMenuItem_Click);
            // 
            // humanoToolStripMenuItem
            // 
            this.humanoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.veterinárioToolStripMenuItem});
            this.humanoToolStripMenuItem.Name = "humanoToolStripMenuItem";
            this.humanoToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.humanoToolStripMenuItem.Text = "Humano";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.ClienteToolStripMenuItem_Click);
            // 
            // veterinárioToolStripMenuItem
            // 
            this.veterinárioToolStripMenuItem.Name = "veterinárioToolStripMenuItem";
            this.veterinárioToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.veterinárioToolStripMenuItem.Text = "Veterinário";
            this.veterinárioToolStripMenuItem.Click += new System.EventHandler(this.VeterinárioToolStripMenuItem_Click);
            // 
            // atendimentoToolStripMenuItem
            // 
            this.atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            this.atendimentoToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.atendimentoToolStripMenuItem.Text = "Atendimento";
            this.atendimentoToolStripMenuItem.Click += new System.EventHandler(this.AtendimentoToolStripMenuItem_Click);
            // 
            // exameToolStripMenuItem
            // 
            this.exameToolStripMenuItem.Name = "exameToolStripMenuItem";
            this.exameToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.exameToolStripMenuItem.Text = "Exame";
            this.exameToolStripMenuItem.Click += new System.EventHandler(this.ExameToolStripMenuItem_Click);
            // 
            // medicamentoToolStripMenuItem
            // 
            this.medicamentoToolStripMenuItem.Name = "medicamentoToolStripMenuItem";
            this.medicamentoToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.medicamentoToolStripMenuItem.Text = "Medicamento";
            this.medicamentoToolStripMenuItem.Click += new System.EventHandler(this.MedicamentoToolStripMenuItem_Click);
            // 
            // tipoToolStripMenuItem
            // 
            this.tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            this.tipoToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.tipoToolStripMenuItem.Text = "Tipo";
            this.tipoToolStripMenuItem.Click += new System.EventHandler(this.TipoToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animaisToolStripMenuItem,
            this.humanoToolStripMenuItem1,
            this.atendimentosToolStripMenuItem,
            this.examesToolStripMenuItem,
            this.medicamentosToolStripMenuItem,
            this.tiposToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // animaisToolStripMenuItem
            // 
            this.animaisToolStripMenuItem.Name = "animaisToolStripMenuItem";
            this.animaisToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.animaisToolStripMenuItem.Text = "Animais";
            this.animaisToolStripMenuItem.Click += new System.EventHandler(this.AnimaisToolStripMenuItem_Click);
            // 
            // humanoToolStripMenuItem1
            // 
            this.humanoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.veterinarioToolStripMenuItem});
            this.humanoToolStripMenuItem1.Name = "humanoToolStripMenuItem1";
            this.humanoToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.humanoToolStripMenuItem1.Text = "Humanos";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.clienteToolStripMenuItem1.Text = "Clientes";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.ClienteToolStripMenuItem1_Click);
            // 
            // veterinarioToolStripMenuItem
            // 
            this.veterinarioToolStripMenuItem.Name = "veterinarioToolStripMenuItem";
            this.veterinarioToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.veterinarioToolStripMenuItem.Text = "Veterinarios";
            this.veterinarioToolStripMenuItem.Click += new System.EventHandler(this.VeterinarioToolStripMenuItem_Click);
            // 
            // atendimentosToolStripMenuItem
            // 
            this.atendimentosToolStripMenuItem.Name = "atendimentosToolStripMenuItem";
            this.atendimentosToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.atendimentosToolStripMenuItem.Text = "Atendimentos";
            this.atendimentosToolStripMenuItem.Click += new System.EventHandler(this.AtendimentosToolStripMenuItem_Click);
            // 
            // examesToolStripMenuItem
            // 
            this.examesToolStripMenuItem.Name = "examesToolStripMenuItem";
            this.examesToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.examesToolStripMenuItem.Text = "Exames";
            this.examesToolStripMenuItem.Click += new System.EventHandler(this.ExamesToolStripMenuItem_Click);
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";
            this.medicamentosToolStripMenuItem.Click += new System.EventHandler(this.MedicamentosToolStripMenuItem_Click);
            // 
            // tiposToolStripMenuItem
            // 
            this.tiposToolStripMenuItem.Name = "tiposToolStripMenuItem";
            this.tiposToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.tiposToolStripMenuItem.Text = "Tipos";
            this.tiposToolStripMenuItem.Click += new System.EventHandler(this.TiposToolStripMenuItem_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hojeToolStripMenuItem,
            this.estaSemanaToolStripMenuItem,
            this.esteMêsToolStripMenuItem,
            this.intervaloEspecíficoToolStripMenuItem});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // hojeToolStripMenuItem
            // 
            this.hojeToolStripMenuItem.Name = "hojeToolStripMenuItem";
            this.hojeToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.hojeToolStripMenuItem.Text = "Hoje";
            this.hojeToolStripMenuItem.Click += new System.EventHandler(this.HojeToolStripMenuItem_Click);
            // 
            // estaSemanaToolStripMenuItem
            // 
            this.estaSemanaToolStripMenuItem.Name = "estaSemanaToolStripMenuItem";
            this.estaSemanaToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.estaSemanaToolStripMenuItem.Text = "Esta semana";
            this.estaSemanaToolStripMenuItem.Click += new System.EventHandler(this.EstaSemanaToolStripMenuItem_Click);
            // 
            // esteMêsToolStripMenuItem
            // 
            this.esteMêsToolStripMenuItem.Name = "esteMêsToolStripMenuItem";
            this.esteMêsToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.esteMêsToolStripMenuItem.Text = "Este mês";
            this.esteMêsToolStripMenuItem.Click += new System.EventHandler(this.EsteMêsToolStripMenuItem_Click);
            // 
            // intervaloEspecíficoToolStripMenuItem
            // 
            this.intervaloEspecíficoToolStripMenuItem.Name = "intervaloEspecíficoToolStripMenuItem";
            this.intervaloEspecíficoToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.intervaloEspecíficoToolStripMenuItem.Text = "Intervalo específico";
            this.intervaloEspecíficoToolStripMenuItem.Click += new System.EventHandler(this.IntervaloEspecíficoToolStripMenuItem_Click);
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagarContaToolStripMenuItem,
            this.contasÀReceberToolStripMenuItem});
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.contasAReceberToolStripMenuItem.Text = "Financeiro";
            this.contasAReceberToolStripMenuItem.Click += new System.EventHandler(this.ContasAReceberToolStripMenuItem_Click);
            // 
            // pagarContaToolStripMenuItem
            // 
            this.pagarContaToolStripMenuItem.Name = "pagarContaToolStripMenuItem";
            this.pagarContaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pagarContaToolStripMenuItem.Text = "Caixa";
            this.pagarContaToolStripMenuItem.Click += new System.EventHandler(this.PagarContaToolStripMenuItem_Click);
            // 
            // contasÀReceberToolStripMenuItem
            // 
            this.contasÀReceberToolStripMenuItem.Name = "contasÀReceberToolStripMenuItem";
            this.contasÀReceberToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.contasÀReceberToolStripMenuItem.Text = "Contas à Receber";
            this.contasÀReceberToolStripMenuItem.Click += new System.EventHandler(this.ContasÀReceberToolStripMenuItem_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 866);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem veterinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hojeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estaSemanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esteMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervaloEspecíficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasÀReceberToolStripMenuItem;
    }
}