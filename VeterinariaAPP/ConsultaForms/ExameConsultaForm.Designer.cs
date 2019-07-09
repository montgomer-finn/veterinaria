namespace VeterinariaAPP.ConsultaForms
{
    partial class ExameConsultaForm
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
            this.optionsCombo = new System.Windows.Forms.ComboBox();
            this.pesqButton = new System.Windows.Forms.Button();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.examesDGV = new System.Windows.Forms.DataGridView();
            this.infoLbl = new System.Windows.Forms.Label();
            this.excluirButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.mostrarTodosButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.examesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsCombo
            // 
            this.optionsCombo.FormattingEnabled = true;
            this.optionsCombo.Location = new System.Drawing.Point(49, 17);
            this.optionsCombo.Name = "optionsCombo";
            this.optionsCombo.Size = new System.Drawing.Size(121, 24);
            this.optionsCombo.TabIndex = 0;
            // 
            // pesqButton
            // 
            this.pesqButton.Location = new System.Drawing.Point(282, 17);
            this.pesqButton.Name = "pesqButton";
            this.pesqButton.Size = new System.Drawing.Size(91, 23);
            this.pesqButton.TabIndex = 2;
            this.pesqButton.Text = "Pesquisar";
            this.pesqButton.UseVisualStyleBackColor = true;
            this.pesqButton.Click += new System.EventHandler(this.PesqButton_Click);
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(176, 20);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(100, 22);
            this.nomeTxt.TabIndex = 1;
            // 
            // examesDGV
            // 
            this.examesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examesDGV.Location = new System.Drawing.Point(12, 71);
            this.examesDGV.Name = "examesDGV";
            this.examesDGV.ReadOnly = true;
            this.examesDGV.RowTemplate.Height = 24;
            this.examesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.examesDGV.Size = new System.Drawing.Size(761, 457);
            this.examesDGV.TabIndex = 26;
            this.examesDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Exames_CellDoubleClick);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(12, 51);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(360, 17);
            this.infoLbl.TabIndex = 30;
            this.infoLbl.Text = "Clique duas vezes em um cadastro para exibir detalhes.";
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(473, 534);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(300, 23);
            this.excluirButton.TabIndex = 4;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(12, 534);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(300, 23);
            this.editarButton.TabIndex = 3;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // mostrarTodosButton
            // 
            this.mostrarTodosButton.Location = new System.Drawing.Point(575, 20);
            this.mostrarTodosButton.Name = "mostrarTodosButton";
            this.mostrarTodosButton.Size = new System.Drawing.Size(134, 23);
            this.mostrarTodosButton.TabIndex = 31;
            this.mostrarTodosButton.Text = "Mostrar Todos";
            this.mostrarTodosButton.UseVisualStyleBackColor = true;
            this.mostrarTodosButton.Visible = false;
            this.mostrarTodosButton.Click += new System.EventHandler(this.MostrarTodosButton_Click);
            // 
            // ExameConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 572);
            this.Controls.Add(this.mostrarTodosButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.optionsCombo);
            this.Controls.Add(this.pesqButton);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.examesDGV);
            this.Name = "ExameConsultaForm";
            this.Text = "ExameConsultaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ExameConsultaForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.examesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox optionsCombo;
        private System.Windows.Forms.Button pesqButton;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.DataGridView examesDGV;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button mostrarTodosButton;
    }
}