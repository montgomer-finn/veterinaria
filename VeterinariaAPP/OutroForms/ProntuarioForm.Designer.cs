namespace VeterinariaAPP.OutroForms
{
    partial class ProntuarioForm
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
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeLabelText = new System.Windows.Forms.Label();
            this.idadeLabel = new System.Windows.Forms.Label();
            this.idadeLabelText = new System.Windows.Forms.Label();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.tipoLabelText = new System.Windows.Forms.Label();
            this.humanoLabel = new System.Windows.Forms.Label();
            this.humanoLabelText = new System.Windows.Forms.Label();
            this.atendimentosDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(12, 9);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(49, 17);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome:";
            // 
            // nomeLabelText
            // 
            this.nomeLabelText.AutoSize = true;
            this.nomeLabelText.Location = new System.Drawing.Point(83, 9);
            this.nomeLabelText.Name = "nomeLabelText";
            this.nomeLabelText.Size = new System.Drawing.Size(39, 17);
            this.nomeLabelText.TabIndex = 1;
            this.nomeLabelText.Text = "teste";
            // 
            // idadeLabel
            // 
            this.idadeLabel.AutoSize = true;
            this.idadeLabel.Location = new System.Drawing.Point(12, 38);
            this.idadeLabel.Name = "idadeLabel";
            this.idadeLabel.Size = new System.Drawing.Size(47, 17);
            this.idadeLabel.TabIndex = 2;
            this.idadeLabel.Text = "Idade:";
            // 
            // idadeLabelText
            // 
            this.idadeLabelText.AutoSize = true;
            this.idadeLabelText.Location = new System.Drawing.Point(83, 38);
            this.idadeLabelText.Name = "idadeLabelText";
            this.idadeLabelText.Size = new System.Drawing.Size(39, 17);
            this.idadeLabelText.TabIndex = 3;
            this.idadeLabelText.Text = "teste";
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(322, 11);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(40, 17);
            this.tipoLabel.TabIndex = 4;
            this.tipoLabel.Text = "Tipo:";
            // 
            // tipoLabelText
            // 
            this.tipoLabelText.AutoSize = true;
            this.tipoLabelText.Location = new System.Drawing.Point(393, 11);
            this.tipoLabelText.Name = "tipoLabelText";
            this.tipoLabelText.Size = new System.Drawing.Size(39, 17);
            this.tipoLabelText.TabIndex = 5;
            this.tipoLabelText.Text = "teste";
            // 
            // humanoLabel
            // 
            this.humanoLabel.AutoSize = true;
            this.humanoLabel.Location = new System.Drawing.Point(322, 38);
            this.humanoLabel.Name = "humanoLabel";
            this.humanoLabel.Size = new System.Drawing.Size(65, 17);
            this.humanoLabel.TabIndex = 6;
            this.humanoLabel.Text = "Humano:";
            // 
            // humanoLabelText
            // 
            this.humanoLabelText.AutoSize = true;
            this.humanoLabelText.Location = new System.Drawing.Point(393, 38);
            this.humanoLabelText.Name = "humanoLabelText";
            this.humanoLabelText.Size = new System.Drawing.Size(39, 17);
            this.humanoLabelText.TabIndex = 7;
            this.humanoLabelText.Text = "teste";
            // 
            // atendimentosDGV
            // 
            this.atendimentosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atendimentosDGV.Location = new System.Drawing.Point(12, 74);
            this.atendimentosDGV.Name = "atendimentosDGV";
            this.atendimentosDGV.ReadOnly = true;
            this.atendimentosDGV.RowTemplate.Height = 24;
            this.atendimentosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.atendimentosDGV.Size = new System.Drawing.Size(776, 380);
            this.atendimentosDGV.TabIndex = 8;
            this.atendimentosDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AtendimentosDGV_CellDoubleClick);
            // 
            // ProntuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.atendimentosDGV);
            this.Controls.Add(this.humanoLabelText);
            this.Controls.Add(this.humanoLabel);
            this.Controls.Add(this.tipoLabelText);
            this.Controls.Add(this.tipoLabel);
            this.Controls.Add(this.idadeLabelText);
            this.Controls.Add(this.idadeLabel);
            this.Controls.Add(this.nomeLabelText);
            this.Controls.Add(this.nomeLabel);
            this.Name = "ProntuarioForm";
            this.Text = "ProntuarioForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.atendimentosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label nomeLabelText;
        private System.Windows.Forms.Label idadeLabel;
        private System.Windows.Forms.Label idadeLabelText;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.Label tipoLabelText;
        private System.Windows.Forms.Label humanoLabel;
        private System.Windows.Forms.Label humanoLabelText;
        private System.Windows.Forms.DataGridView atendimentosDGV;
    }
}