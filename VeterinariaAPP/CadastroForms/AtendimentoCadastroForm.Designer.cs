namespace VeterinariaAPP
{
    partial class AtendimentoCadastroForm
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
            this.dataLabel = new System.Windows.Forms.Label();
            this.dataRealizacaoTxt = new System.Windows.Forms.DateTimePicker();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.veterinarioTxt = new System.Windows.Forms.TextBox();
            this.VeterinarioLabel = new System.Windows.Forms.Label();
            this.animalLabel = new System.Windows.Forms.Label();
            this.animalTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removerExameButton = new System.Windows.Forms.Button();
            this.adicionarExameButton = new System.Windows.Forms.Button();
            this.exameLabel = new System.Windows.Forms.Label();
            this.exameTxt = new System.Windows.Forms.TextBox();
            this.examesDGV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removerMedicamentoButton = new System.Windows.Forms.Button();
            this.adicionarMedicamentoButton = new System.Windows.Forms.Button();
            this.medicamentoTxt = new System.Windows.Forms.TextBox();
            this.medicamentoLabel = new System.Windows.Forms.Label();
            this.medicamentosDGV = new System.Windows.Forms.DataGridView();
            this.descLabel = new System.Windows.Forms.Label();
            this.descTxt = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.realizadoButtonNao = new System.Windows.Forms.RadioButton();
            this.realizadoButtonSim = new System.Windows.Forms.RadioButton();
            this.limparButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.pagamentoBox = new System.Windows.Forms.GroupBox();
            this.precoTotalTxt = new System.Windows.Forms.Label();
            this.precoTotalLabel = new System.Windows.Forms.Label();
            this.precoLabelTxt = new System.Windows.Forms.Label();
            this.precoExamesLabel = new System.Windows.Forms.Label();
            this.precoTxt = new System.Windows.Forms.TextBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.diaParcelaTxt = new System.Windows.Forms.TextBox();
            this.diaParcelaLabel = new System.Windows.Forms.Label();
            this.numeroParcealsTxt = new System.Windows.Forms.TextBox();
            this.numeroParcelasLabel = new System.Windows.Forms.Label();
            this.aPrazoButton = new System.Windows.Forms.RadioButton();
            this.aVistaButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examesDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosDGV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.pagamentoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(12, 9);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(42, 17);
            this.dataLabel.TabIndex = 21;
            this.dataLabel.Text = "Data:";
            // 
            // dataRealizacaoTxt
            // 
            this.dataRealizacaoTxt.Location = new System.Drawing.Point(116, 4);
            this.dataRealizacaoTxt.Name = "dataRealizacaoTxt";
            this.dataRealizacaoTxt.Size = new System.Drawing.Size(200, 22);
            this.dataRealizacaoTxt.TabIndex = 0;
            this.dataRealizacaoTxt.ValueChanged += new System.EventHandler(this.DataNascimento_ValueChanged);
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.Location = new System.Drawing.Point(1001, 489);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(426, 23);
            this.cadastrarButton.TabIndex = 8;
            this.cadastrarButton.Text = "Gravar";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
            // 
            // veterinarioTxt
            // 
            this.veterinarioTxt.Location = new System.Drawing.Point(116, 60);
            this.veterinarioTxt.Name = "veterinarioTxt";
            this.veterinarioTxt.Size = new System.Drawing.Size(200, 22);
            this.veterinarioTxt.TabIndex = 2;
            // 
            // VeterinarioLabel
            // 
            this.VeterinarioLabel.AutoSize = true;
            this.VeterinarioLabel.Location = new System.Drawing.Point(12, 63);
            this.VeterinarioLabel.Name = "VeterinarioLabel";
            this.VeterinarioLabel.Size = new System.Drawing.Size(98, 17);
            this.VeterinarioLabel.TabIndex = 15;
            this.VeterinarioLabel.Text = "Veterinario ID:";
            // 
            // animalLabel
            // 
            this.animalLabel.AutoSize = true;
            this.animalLabel.Location = new System.Drawing.Point(12, 35);
            this.animalLabel.Name = "animalLabel";
            this.animalLabel.Size = new System.Drawing.Size(71, 17);
            this.animalLabel.TabIndex = 22;
            this.animalLabel.Text = "Animal ID:";
            // 
            // animalTxt
            // 
            this.animalTxt.Location = new System.Drawing.Point(116, 32);
            this.animalTxt.Name = "animalTxt";
            this.animalTxt.Size = new System.Drawing.Size(200, 22);
            this.animalTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removerExameButton);
            this.groupBox1.Controls.Add(this.adicionarExameButton);
            this.groupBox1.Controls.Add(this.exameLabel);
            this.groupBox1.Controls.Add(this.exameTxt);
            this.groupBox1.Controls.Add(this.examesDGV);
            this.groupBox1.Location = new System.Drawing.Point(4, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 302);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exames";
            // 
            // removerExameButton
            // 
            this.removerExameButton.Location = new System.Drawing.Point(324, 273);
            this.removerExameButton.Name = "removerExameButton";
            this.removerExameButton.Size = new System.Drawing.Size(75, 23);
            this.removerExameButton.TabIndex = 2;
            this.removerExameButton.Text = "Remover";
            this.removerExameButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.removerExameButton.UseVisualStyleBackColor = true;
            this.removerExameButton.Click += new System.EventHandler(this.RemoverExameButton_Click);
            // 
            // adicionarExameButton
            // 
            this.adicionarExameButton.Location = new System.Drawing.Point(243, 273);
            this.adicionarExameButton.Name = "adicionarExameButton";
            this.adicionarExameButton.Size = new System.Drawing.Size(75, 23);
            this.adicionarExameButton.TabIndex = 1;
            this.adicionarExameButton.Text = "Adicionar";
            this.adicionarExameButton.UseVisualStyleBackColor = true;
            this.adicionarExameButton.Click += new System.EventHandler(this.AdicionarExameButton_Click);
            // 
            // exameLabel
            // 
            this.exameLabel.AutoSize = true;
            this.exameLabel.Location = new System.Drawing.Point(18, 273);
            this.exameLabel.Name = "exameLabel";
            this.exameLabel.Size = new System.Drawing.Size(71, 17);
            this.exameLabel.TabIndex = 2;
            this.exameLabel.Text = "Exame ID:";
            // 
            // exameTxt
            // 
            this.exameTxt.Location = new System.Drawing.Point(137, 274);
            this.exameTxt.Name = "exameTxt";
            this.exameTxt.Size = new System.Drawing.Size(100, 22);
            this.exameTxt.TabIndex = 0;
            this.exameTxt.TextChanged += new System.EventHandler(this.ExameTxt_TextChanged);
            // 
            // examesDGV
            // 
            this.examesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examesDGV.Location = new System.Drawing.Point(6, 23);
            this.examesDGV.Name = "examesDGV";
            this.examesDGV.ReadOnly = true;
            this.examesDGV.RowTemplate.Height = 24;
            this.examesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.examesDGV.Size = new System.Drawing.Size(684, 234);
            this.examesDGV.TabIndex = 0;
            this.examesDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExamesDGV_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removerMedicamentoButton);
            this.groupBox2.Controls.Add(this.adicionarMedicamentoButton);
            this.groupBox2.Controls.Add(this.medicamentoTxt);
            this.groupBox2.Controls.Add(this.medicamentoLabel);
            this.groupBox2.Controls.Add(this.medicamentosDGV);
            this.groupBox2.Location = new System.Drawing.Point(721, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 302);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicamentos";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // removerMedicamentoButton
            // 
            this.removerMedicamentoButton.Location = new System.Drawing.Point(316, 274);
            this.removerMedicamentoButton.Name = "removerMedicamentoButton";
            this.removerMedicamentoButton.Size = new System.Drawing.Size(75, 23);
            this.removerMedicamentoButton.TabIndex = 2;
            this.removerMedicamentoButton.Text = "Remover";
            this.removerMedicamentoButton.UseVisualStyleBackColor = true;
            this.removerMedicamentoButton.Click += new System.EventHandler(this.RemoverMedicamentoButton_Click);
            // 
            // adicionarMedicamentoButton
            // 
            this.adicionarMedicamentoButton.Location = new System.Drawing.Point(235, 273);
            this.adicionarMedicamentoButton.Name = "adicionarMedicamentoButton";
            this.adicionarMedicamentoButton.Size = new System.Drawing.Size(75, 23);
            this.adicionarMedicamentoButton.TabIndex = 1;
            this.adicionarMedicamentoButton.Text = "Adicionar";
            this.adicionarMedicamentoButton.UseVisualStyleBackColor = true;
            this.adicionarMedicamentoButton.Click += new System.EventHandler(this.AdicionarMedicamentoButton_Click);
            // 
            // medicamentoTxt
            // 
            this.medicamentoTxt.Location = new System.Drawing.Point(129, 275);
            this.medicamentoTxt.Name = "medicamentoTxt";
            this.medicamentoTxt.Size = new System.Drawing.Size(100, 22);
            this.medicamentoTxt.TabIndex = 0;
            // 
            // medicamentoLabel
            // 
            this.medicamentoLabel.AutoSize = true;
            this.medicamentoLabel.Location = new System.Drawing.Point(10, 273);
            this.medicamentoLabel.Name = "medicamentoLabel";
            this.medicamentoLabel.Size = new System.Drawing.Size(113, 17);
            this.medicamentoLabel.TabIndex = 27;
            this.medicamentoLabel.Text = "Medicamento ID:";
            // 
            // medicamentosDGV
            // 
            this.medicamentosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicamentosDGV.Location = new System.Drawing.Point(6, 21);
            this.medicamentosDGV.Name = "medicamentosDGV";
            this.medicamentosDGV.ReadOnly = true;
            this.medicamentosDGV.RowTemplate.Height = 24;
            this.medicamentosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicamentosDGV.Size = new System.Drawing.Size(673, 236);
            this.medicamentosDGV.TabIndex = 0;
            this.medicamentosDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicamentosDGV_CellDoubleClick);
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(334, 9);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(75, 17);
            this.descLabel.TabIndex = 4;
            this.descLabel.Text = "Descrição:";
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(337, 35);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(363, 109);
            this.descTxt.TabIndex = 4;
            this.descTxt.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.realizadoButtonNao);
            this.groupBox3.Controls.Add(this.realizadoButtonSim);
            this.groupBox3.Location = new System.Drawing.Point(15, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 53);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Realizado:";
            // 
            // realizadoButtonNao
            // 
            this.realizadoButtonNao.AutoSize = true;
            this.realizadoButtonNao.Location = new System.Drawing.Point(179, 21);
            this.realizadoButtonNao.Name = "realizadoButtonNao";
            this.realizadoButtonNao.Size = new System.Drawing.Size(55, 21);
            this.realizadoButtonNao.TabIndex = 1;
            this.realizadoButtonNao.TabStop = true;
            this.realizadoButtonNao.Text = "Não";
            this.realizadoButtonNao.UseVisualStyleBackColor = true;
            this.realizadoButtonNao.CheckedChanged += new System.EventHandler(this.RealizadoButtonNao_CheckedChanged);
            // 
            // realizadoButtonSim
            // 
            this.realizadoButtonSim.AutoSize = true;
            this.realizadoButtonSim.Location = new System.Drawing.Point(101, 21);
            this.realizadoButtonSim.Name = "realizadoButtonSim";
            this.realizadoButtonSim.Size = new System.Drawing.Size(52, 21);
            this.realizadoButtonSim.TabIndex = 0;
            this.realizadoButtonSim.TabStop = true;
            this.realizadoButtonSim.Text = "Sim";
            this.realizadoButtonSim.UseVisualStyleBackColor = true;
            this.realizadoButtonSim.CheckedChanged += new System.EventHandler(this.RealizadoButtonSim_CheckedChanged);
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(504, 489);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(491, 23);
            this.limparButton.TabIndex = 9;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(10, 489);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(488, 23);
            this.cancelarButton.TabIndex = 10;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // pagamentoBox
            // 
            this.pagamentoBox.Controls.Add(this.precoTotalTxt);
            this.pagamentoBox.Controls.Add(this.precoTotalLabel);
            this.pagamentoBox.Controls.Add(this.precoLabelTxt);
            this.pagamentoBox.Controls.Add(this.precoExamesLabel);
            this.pagamentoBox.Controls.Add(this.precoTxt);
            this.pagamentoBox.Controls.Add(this.labelPreco);
            this.pagamentoBox.Controls.Add(this.diaParcelaTxt);
            this.pagamentoBox.Controls.Add(this.diaParcelaLabel);
            this.pagamentoBox.Controls.Add(this.numeroParcealsTxt);
            this.pagamentoBox.Controls.Add(this.numeroParcelasLabel);
            this.pagamentoBox.Controls.Add(this.aPrazoButton);
            this.pagamentoBox.Controls.Add(this.aVistaButton);
            this.pagamentoBox.Location = new System.Drawing.Point(721, 20);
            this.pagamentoBox.Name = "pagamentoBox";
            this.pagamentoBox.Size = new System.Drawing.Size(678, 131);
            this.pagamentoBox.TabIndex = 7;
            this.pagamentoBox.TabStop = false;
            this.pagamentoBox.Text = "Pagamento";
            this.pagamentoBox.Visible = false;
            this.pagamentoBox.Enter += new System.EventHandler(this.GroupBox4_Enter);
            // 
            // precoTotalTxt
            // 
            this.precoTotalTxt.AutoSize = true;
            this.precoTotalTxt.Location = new System.Drawing.Point(558, 43);
            this.precoTotalTxt.Name = "precoTotalTxt";
            this.precoTotalTxt.Size = new System.Drawing.Size(36, 17);
            this.precoTotalTxt.TabIndex = 11;
            this.precoTotalTxt.Text = "0,00";
            // 
            // precoTotalLabel
            // 
            this.precoTotalLabel.AutoSize = true;
            this.precoTotalLabel.Location = new System.Drawing.Point(467, 41);
            this.precoTotalLabel.Name = "precoTotalLabel";
            this.precoTotalLabel.Size = new System.Drawing.Size(85, 17);
            this.precoTotalLabel.TabIndex = 10;
            this.precoTotalLabel.Text = "Preco Total:";
            // 
            // precoLabelTxt
            // 
            this.precoLabelTxt.AutoSize = true;
            this.precoLabelTxt.Location = new System.Drawing.Point(403, 41);
            this.precoLabelTxt.Name = "precoLabelTxt";
            this.precoLabelTxt.Size = new System.Drawing.Size(36, 17);
            this.precoLabelTxt.TabIndex = 9;
            this.precoLabelTxt.Text = "0,00";
            // 
            // precoExamesLabel
            // 
            this.precoExamesLabel.AutoSize = true;
            this.precoExamesLabel.Location = new System.Drawing.Point(295, 41);
            this.precoExamesLabel.Name = "precoExamesLabel";
            this.precoExamesLabel.Size = new System.Drawing.Size(102, 17);
            this.precoExamesLabel.TabIndex = 8;
            this.precoExamesLabel.Text = "Preço Exames:";
            // 
            // precoTxt
            // 
            this.precoTxt.Location = new System.Drawing.Point(174, 38);
            this.precoTxt.Name = "precoTxt";
            this.precoTxt.Size = new System.Drawing.Size(100, 22);
            this.precoTxt.TabIndex = 0;
            this.precoTxt.TextChanged += new System.EventHandler(this.PrecoTxt_TextChanged);
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(27, 41);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(131, 17);
            this.labelPreco.TabIndex = 6;
            this.labelPreco.Text = "Preço atendimento:";
            // 
            // diaParcelaTxt
            // 
            this.diaParcelaTxt.Location = new System.Drawing.Point(520, 82);
            this.diaParcelaTxt.Name = "diaParcelaTxt";
            this.diaParcelaTxt.Size = new System.Drawing.Size(100, 22);
            this.diaParcelaTxt.TabIndex = 2;
            // 
            // diaParcelaLabel
            // 
            this.diaParcelaLabel.AutoSize = true;
            this.diaParcelaLabel.Location = new System.Drawing.Point(430, 84);
            this.diaParcelaLabel.Name = "diaParcelaLabel";
            this.diaParcelaLabel.Size = new System.Drawing.Size(83, 17);
            this.diaParcelaLabel.TabIndex = 4;
            this.diaParcelaLabel.Text = "Dia do mês:";
            // 
            // numeroParcealsTxt
            // 
            this.numeroParcealsTxt.Location = new System.Drawing.Point(348, 82);
            this.numeroParcealsTxt.Name = "numeroParcealsTxt";
            this.numeroParcealsTxt.Size = new System.Drawing.Size(66, 22);
            this.numeroParcealsTxt.TabIndex = 1;
            // 
            // numeroParcelasLabel
            // 
            this.numeroParcelasLabel.AutoSize = true;
            this.numeroParcelasLabel.Location = new System.Drawing.Point(200, 86);
            this.numeroParcelasLabel.Name = "numeroParcelasLabel";
            this.numeroParcelasLabel.Size = new System.Drawing.Size(141, 17);
            this.numeroParcelasLabel.TabIndex = 2;
            this.numeroParcelasLabel.Text = "Número de Parcelas:";
            // 
            // aPrazoButton
            // 
            this.aPrazoButton.AutoSize = true;
            this.aPrazoButton.Location = new System.Drawing.Point(106, 82);
            this.aPrazoButton.Name = "aPrazoButton";
            this.aPrazoButton.Size = new System.Drawing.Size(78, 21);
            this.aPrazoButton.TabIndex = 1;
            this.aPrazoButton.TabStop = true;
            this.aPrazoButton.Text = "À prazo";
            this.aPrazoButton.UseVisualStyleBackColor = true;
            // 
            // aVistaButton
            // 
            this.aVistaButton.AutoSize = true;
            this.aVistaButton.Location = new System.Drawing.Point(15, 83);
            this.aVistaButton.Name = "aVistaButton";
            this.aVistaButton.Size = new System.Drawing.Size(71, 21);
            this.aVistaButton.TabIndex = 0;
            this.aVistaButton.TabStop = true;
            this.aVistaButton.Text = "À vista";
            this.aVistaButton.UseVisualStyleBackColor = true;
            // 
            // AtendimentoCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 578);
            this.Controls.Add(this.pagamentoBox);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.animalTxt);
            this.Controls.Add(this.animalLabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.dataRealizacaoTxt);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.veterinarioTxt);
            this.Controls.Add(this.VeterinarioLabel);
            this.Name = "AtendimentoCadastroForm";
            this.Text = "z";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examesDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosDGV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pagamentoBox.ResumeLayout(false);
            this.pagamentoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.DateTimePicker dataRealizacaoTxt;
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.TextBox veterinarioTxt;
        private System.Windows.Forms.Label VeterinarioLabel;
        private System.Windows.Forms.Label animalLabel;
        private System.Windows.Forms.TextBox animalTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removerExameButton;
        private System.Windows.Forms.Button adicionarExameButton;
        private System.Windows.Forms.Label exameLabel;
        private System.Windows.Forms.TextBox exameTxt;
        private System.Windows.Forms.DataGridView examesDGV;
        private System.Windows.Forms.Button removerMedicamentoButton;
        private System.Windows.Forms.Button adicionarMedicamentoButton;
        private System.Windows.Forms.TextBox medicamentoTxt;
        private System.Windows.Forms.Label medicamentoLabel;
        private System.Windows.Forms.DataGridView medicamentosDGV;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.RichTextBox descTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton realizadoButtonNao;
        private System.Windows.Forms.RadioButton realizadoButtonSim;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.GroupBox pagamentoBox;
        private System.Windows.Forms.TextBox diaParcelaTxt;
        private System.Windows.Forms.Label diaParcelaLabel;
        private System.Windows.Forms.TextBox numeroParcealsTxt;
        private System.Windows.Forms.Label numeroParcelasLabel;
        private System.Windows.Forms.RadioButton aPrazoButton;
        private System.Windows.Forms.RadioButton aVistaButton;
        private System.Windows.Forms.Label precoTotalTxt;
        private System.Windows.Forms.Label precoTotalLabel;
        private System.Windows.Forms.Label precoLabelTxt;
        private System.Windows.Forms.Label precoExamesLabel;
        private System.Windows.Forms.TextBox precoTxt;
        private System.Windows.Forms.Label labelPreco;
    }
}