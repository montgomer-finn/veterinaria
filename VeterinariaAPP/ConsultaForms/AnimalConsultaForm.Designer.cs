namespace VeterinariaAPP.ConsultaForms
{
    partial class AnimalConsultaForm
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
            this.animaisDGV = new System.Windows.Forms.DataGridView();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.pesqButton = new System.Windows.Forms.Button();
            this.optionsCombo = new System.Windows.Forms.ComboBox();
            this.infoLbl = new System.Windows.Forms.Label();
            this.editarButton = new System.Windows.Forms.Button();
            this.protuarioButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.mostrarTodosButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // animaisDGV
            // 
            this.animaisDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animaisDGV.Location = new System.Drawing.Point(12, 82);
            this.animaisDGV.Name = "animaisDGV";
            this.animaisDGV.ReadOnly = true;
            this.animaisDGV.RowTemplate.Height = 24;
            this.animaisDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.animaisDGV.Size = new System.Drawing.Size(738, 397);
            this.animaisDGV.TabIndex = 21;
            this.animaisDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnimaisDGV_CellDoubleClick);
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(176, 26);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(100, 22);
            this.nomeTxt.TabIndex = 1;
            this.nomeTxt.TextChanged += new System.EventHandler(this.NomeTxt_TextChanged);
            // 
            // pesqButton
            // 
            this.pesqButton.Location = new System.Drawing.Point(282, 23);
            this.pesqButton.Name = "pesqButton";
            this.pesqButton.Size = new System.Drawing.Size(91, 23);
            this.pesqButton.TabIndex = 2;
            this.pesqButton.Text = "Pesquisar";
            this.pesqButton.UseVisualStyleBackColor = true;
            this.pesqButton.Click += new System.EventHandler(this.PesqButton_Click);
            // 
            // optionsCombo
            // 
            this.optionsCombo.FormattingEnabled = true;
            this.optionsCombo.Location = new System.Drawing.Point(49, 23);
            this.optionsCombo.Name = "optionsCombo";
            this.optionsCombo.Size = new System.Drawing.Size(121, 24);
            this.optionsCombo.TabIndex = 0;
            this.optionsCombo.SelectedIndexChanged += new System.EventHandler(this.OptionsCombo_SelectedIndexChanged);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(12, 62);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(360, 17);
            this.infoLbl.TabIndex = 26;
            this.infoLbl.Text = "Clique duas vezes em um cadastro para exibir detalhes.";
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(12, 485);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(264, 23);
            this.editarButton.TabIndex = 3;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // protuarioButton
            // 
            this.protuarioButton.Location = new System.Drawing.Point(282, 485);
            this.protuarioButton.Name = "protuarioButton";
            this.protuarioButton.Size = new System.Drawing.Size(198, 23);
            this.protuarioButton.TabIndex = 4;
            this.protuarioButton.Text = "Protuário";
            this.protuarioButton.UseVisualStyleBackColor = true;
            this.protuarioButton.Click += new System.EventHandler(this.ProtuarioButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(486, 485);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(219, 23);
            this.excluirButton.TabIndex = 5;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // mostrarTodosButton
            // 
            this.mostrarTodosButton.Location = new System.Drawing.Point(551, 26);
            this.mostrarTodosButton.Name = "mostrarTodosButton";
            this.mostrarTodosButton.Size = new System.Drawing.Size(134, 23);
            this.mostrarTodosButton.TabIndex = 27;
            this.mostrarTodosButton.Text = "Mostrar Todos";
            this.mostrarTodosButton.UseVisualStyleBackColor = true;
            this.mostrarTodosButton.Visible = false;
            this.mostrarTodosButton.Click += new System.EventHandler(this.MostrarTodosButton_Click);
            // 
            // AnimalConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 530);
            this.Controls.Add(this.mostrarTodosButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.protuarioButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.optionsCombo);
            this.Controls.Add(this.pesqButton);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.animaisDGV);
            this.Name = "AnimalConsultaForm";
            this.Text = "AnimalConsultaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.AnimalConsultaForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.animaisDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView animaisDGV;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Button pesqButton;
        private System.Windows.Forms.ComboBox optionsCombo;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button protuarioButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button mostrarTodosButton;
    }
}