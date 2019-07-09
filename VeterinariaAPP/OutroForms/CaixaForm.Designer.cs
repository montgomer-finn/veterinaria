namespace VeterinariaAPP.OutroForms
{
    partial class CaixaForm
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
            this.excluirButton = new System.Windows.Forms.Button();
            this.infoLbl = new System.Windows.Forms.Label();
            this.optionsCombo = new System.Windows.Forms.ComboBox();
            this.pesqButton = new System.Windows.Forms.Button();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.caixasDGV = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.caixasDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(433, 517);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(300, 23);
            this.excluirButton.TabIndex = 51;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(9, 60);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(360, 17);
            this.infoLbl.TabIndex = 53;
            this.infoLbl.Text = "Clique duas vezes em um cadastro para exibir detalhes.";
            // 
            // optionsCombo
            // 
            this.optionsCombo.FormattingEnabled = true;
            this.optionsCombo.Location = new System.Drawing.Point(52, 12);
            this.optionsCombo.Name = "optionsCombo";
            this.optionsCombo.Size = new System.Drawing.Size(121, 24);
            this.optionsCombo.TabIndex = 47;
            this.optionsCombo.SelectedIndexChanged += new System.EventHandler(this.OptionsCombo_SelectedIndexChanged);
            // 
            // pesqButton
            // 
            this.pesqButton.Location = new System.Drawing.Point(394, 15);
            this.pesqButton.Name = "pesqButton";
            this.pesqButton.Size = new System.Drawing.Size(91, 23);
            this.pesqButton.TabIndex = 49;
            this.pesqButton.Text = "Pesquisar";
            this.pesqButton.UseVisualStyleBackColor = true;
            this.pesqButton.Click += new System.EventHandler(this.PesqButton_Click);
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(179, 15);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(200, 22);
            this.nomeTxt.TabIndex = 48;
            this.nomeTxt.Visible = false;
            // 
            // caixasDGV
            // 
            this.caixasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caixasDGV.Location = new System.Drawing.Point(12, 80);
            this.caixasDGV.Name = "caixasDGV";
            this.caixasDGV.ReadOnly = true;
            this.caixasDGV.RowTemplate.Height = 24;
            this.caixasDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.caixasDGV.Size = new System.Drawing.Size(721, 431);
            this.caixasDGV.TabIndex = 52;
            this.caixasDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CaixasDGV_CellDoubleClick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(179, 15);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 54;
            this.dateTimePicker.Visible = false;
            // 
            // CaixaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.optionsCombo);
            this.Controls.Add(this.pesqButton);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.caixasDGV);
            this.Name = "CaixaForm";
            this.Text = "CaixaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.CaixaForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.caixasDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.ComboBox optionsCombo;
        private System.Windows.Forms.Button pesqButton;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.DataGridView caixasDGV;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}