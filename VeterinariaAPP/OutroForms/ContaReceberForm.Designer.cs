namespace VeterinariaAPP.OutroForms
{
    partial class ContaReceberForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.excluirButton = new System.Windows.Forms.Button();
            this.infoLbl = new System.Windows.Forms.Label();
            this.optionsCombo = new System.Windows.Forms.ComboBox();
            this.pesqButton = new System.Windows.Forms.Button();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.contasReceberDGV = new System.Windows.Forms.DataGridView();
            this.pagarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(179, 20);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 61;
            this.dateTimePicker.Visible = false;
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(433, 522);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(300, 23);
            this.excluirButton.TabIndex = 58;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(9, 65);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(360, 17);
            this.infoLbl.TabIndex = 60;
            this.infoLbl.Text = "Clique duas vezes em um cadastro para exibir detalhes.";
            // 
            // optionsCombo
            // 
            this.optionsCombo.FormattingEnabled = true;
            this.optionsCombo.Location = new System.Drawing.Point(52, 17);
            this.optionsCombo.Name = "optionsCombo";
            this.optionsCombo.Size = new System.Drawing.Size(121, 24);
            this.optionsCombo.TabIndex = 55;
            this.optionsCombo.SelectedIndexChanged += new System.EventHandler(this.OptionsCombo_SelectedIndexChanged);
            // 
            // pesqButton
            // 
            this.pesqButton.Location = new System.Drawing.Point(394, 20);
            this.pesqButton.Name = "pesqButton";
            this.pesqButton.Size = new System.Drawing.Size(91, 23);
            this.pesqButton.TabIndex = 57;
            this.pesqButton.Text = "Pesquisar";
            this.pesqButton.UseVisualStyleBackColor = true;
            this.pesqButton.Click += new System.EventHandler(this.PesqButton_Click);
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(179, 20);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(200, 22);
            this.nomeTxt.TabIndex = 56;
            this.nomeTxt.Visible = false;
            // 
            // contasReceberDGV
            // 
            this.contasReceberDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contasReceberDGV.Location = new System.Drawing.Point(12, 85);
            this.contasReceberDGV.Name = "contasReceberDGV";
            this.contasReceberDGV.ReadOnly = true;
            this.contasReceberDGV.RowTemplate.Height = 24;
            this.contasReceberDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contasReceberDGV.Size = new System.Drawing.Size(721, 431);
            this.contasReceberDGV.TabIndex = 59;
            this.contasReceberDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContasReceberDGV_CellDoubleClick);
            // 
            // pagarButton
            // 
            this.pagarButton.Location = new System.Drawing.Point(12, 522);
            this.pagarButton.Name = "pagarButton";
            this.pagarButton.Size = new System.Drawing.Size(249, 23);
            this.pagarButton.TabIndex = 62;
            this.pagarButton.Text = "Pagar";
            this.pagarButton.UseVisualStyleBackColor = true;
            this.pagarButton.Click += new System.EventHandler(this.PagarButton_Click);
            // 
            // ContaReceberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.pagarButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.optionsCombo);
            this.Controls.Add(this.pesqButton);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.contasReceberDGV);
            this.Name = "ContaReceberForm";
            this.Text = "ContaReceberForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ContaReceberForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.ComboBox optionsCombo;
        private System.Windows.Forms.Button pesqButton;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.DataGridView contasReceberDGV;
        private System.Windows.Forms.Button pagarButton;
    }
}