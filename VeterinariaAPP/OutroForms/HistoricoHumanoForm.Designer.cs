namespace VeterinariaAPP.OutroForms
{
    partial class HistoricoHumanoForm
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
            this.atendimentosDGV = new System.Windows.Forms.DataGridView();
            this.tipoLabelText = new System.Windows.Forms.Label();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.CPFLabelText = new System.Windows.Forms.Label();
            this.CPFLabel = new System.Windows.Forms.Label();
            this.nomeLabelText = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.groupVeterinarioOnly = new System.Windows.Forms.GroupBox();
            this.paraButton = new System.Windows.Forms.RadioButton();
            this.porButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentosDGV)).BeginInit();
            this.groupVeterinarioOnly.SuspendLayout();
            this.SuspendLayout();
            // 
            // atendimentosDGV
            // 
            this.atendimentosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atendimentosDGV.Location = new System.Drawing.Point(12, 109);
            this.atendimentosDGV.Name = "atendimentosDGV";
            this.atendimentosDGV.ReadOnly = true;
            this.atendimentosDGV.RowTemplate.Height = 24;
            this.atendimentosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.atendimentosDGV.Size = new System.Drawing.Size(776, 348);
            this.atendimentosDGV.TabIndex = 17;
            this.atendimentosDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AtendimentosDGV_CellDoubleClick);
            // 
            // tipoLabelText
            // 
            this.tipoLabelText.AutoSize = true;
            this.tipoLabelText.Location = new System.Drawing.Point(393, 14);
            this.tipoLabelText.Name = "tipoLabelText";
            this.tipoLabelText.Size = new System.Drawing.Size(39, 17);
            this.tipoLabelText.TabIndex = 14;
            this.tipoLabelText.Text = "teste";
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(322, 14);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(40, 17);
            this.tipoLabel.TabIndex = 13;
            this.tipoLabel.Text = "Tipo:";
            // 
            // CPFLabelText
            // 
            this.CPFLabelText.AutoSize = true;
            this.CPFLabelText.Location = new System.Drawing.Point(83, 41);
            this.CPFLabelText.Name = "CPFLabelText";
            this.CPFLabelText.Size = new System.Drawing.Size(39, 17);
            this.CPFLabelText.TabIndex = 12;
            this.CPFLabelText.Text = "teste";
            // 
            // CPFLabel
            // 
            this.CPFLabel.AutoSize = true;
            this.CPFLabel.Location = new System.Drawing.Point(12, 41);
            this.CPFLabel.Name = "CPFLabel";
            this.CPFLabel.Size = new System.Drawing.Size(47, 17);
            this.CPFLabel.TabIndex = 11;
            this.CPFLabel.Text = "Idade:";
            // 
            // nomeLabelText
            // 
            this.nomeLabelText.AutoSize = true;
            this.nomeLabelText.Location = new System.Drawing.Point(83, 12);
            this.nomeLabelText.Name = "nomeLabelText";
            this.nomeLabelText.Size = new System.Drawing.Size(39, 17);
            this.nomeLabelText.TabIndex = 10;
            this.nomeLabelText.Text = "teste";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(12, 12);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(49, 17);
            this.nomeLabel.TabIndex = 9;
            this.nomeLabel.Text = "Nome:";
            // 
            // groupVeterinarioOnly
            // 
            this.groupVeterinarioOnly.Controls.Add(this.paraButton);
            this.groupVeterinarioOnly.Controls.Add(this.porButton);
            this.groupVeterinarioOnly.Location = new System.Drawing.Point(15, 62);
            this.groupVeterinarioOnly.Name = "groupVeterinarioOnly";
            this.groupVeterinarioOnly.Size = new System.Drawing.Size(773, 41);
            this.groupVeterinarioOnly.TabIndex = 18;
            this.groupVeterinarioOnly.TabStop = false;
            this.groupVeterinarioOnly.Visible = false;
            // 
            // paraButton
            // 
            this.paraButton.AutoSize = true;
            this.paraButton.Checked = true;
            this.paraButton.Location = new System.Drawing.Point(335, 14);
            this.paraButton.Name = "paraButton";
            this.paraButton.Size = new System.Drawing.Size(319, 21);
            this.paraButton.TabIndex = 1;
            this.paraButton.TabStop = true;
            this.paraButton.Text = "Atendimentos realizados para este veterinário";
            this.paraButton.UseVisualStyleBackColor = true;
            this.paraButton.Visible = false;
            this.paraButton.CheckedChanged += new System.EventHandler(this.ParaButton_CheckedChanged);
            // 
            // porButton
            // 
            this.porButton.AutoSize = true;
            this.porButton.Location = new System.Drawing.Point(7, 14);
            this.porButton.Name = "porButton";
            this.porButton.Size = new System.Drawing.Size(311, 21);
            this.porButton.TabIndex = 0;
            this.porButton.Text = "Atendimentos realizados por este veterinário";
            this.porButton.UseVisualStyleBackColor = true;
            this.porButton.Visible = false;
            this.porButton.CheckedChanged += new System.EventHandler(this.PorButton_CheckedChanged);
            // 
            // HistoricoHumanoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 469);
            this.Controls.Add(this.groupVeterinarioOnly);
            this.Controls.Add(this.atendimentosDGV);
            this.Controls.Add(this.tipoLabelText);
            this.Controls.Add(this.tipoLabel);
            this.Controls.Add(this.CPFLabelText);
            this.Controls.Add(this.CPFLabel);
            this.Controls.Add(this.nomeLabelText);
            this.Controls.Add(this.nomeLabel);
            this.Name = "HistoricoHumanoForm";
            this.Text = "HistoricoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.atendimentosDGV)).EndInit();
            this.groupVeterinarioOnly.ResumeLayout(false);
            this.groupVeterinarioOnly.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView atendimentosDGV;
        private System.Windows.Forms.Label tipoLabelText;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.Label CPFLabelText;
        private System.Windows.Forms.Label CPFLabel;
        private System.Windows.Forms.Label nomeLabelText;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.GroupBox groupVeterinarioOnly;
        private System.Windows.Forms.RadioButton paraButton;
        private System.Windows.Forms.RadioButton porButton;
    }
}