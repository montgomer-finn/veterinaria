namespace VeterinariaAPP
{
    partial class MedicamentoCadastroForm
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
            this.descText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.dosagemText = new System.Windows.Forms.TextBox();
            this.dosagemLabel = new System.Windows.Forms.Label();
            this.limparButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descText
            // 
            this.descText.HideSelection = false;
            this.descText.Location = new System.Drawing.Point(15, 99);
            this.descText.Name = "descText";
            this.descText.Size = new System.Drawing.Size(240, 92);
            this.descText.TabIndex = 3;
            this.descText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Descrição:";
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.Location = new System.Drawing.Point(243, 213);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(127, 23);
            this.cadastrarButton.TabIndex = 4;
            this.cadastrarButton.Text = "Gravar";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(87, 13);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(168, 22);
            this.nomeTxt.TabIndex = 0;
            this.nomeTxt.TextChanged += new System.EventHandler(this.NomeTxt_TextChanged);
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(12, 15);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(49, 17);
            this.nomeLabel.TabIndex = 15;
            this.nomeLabel.Text = "Nome:";
            // 
            // dosagemText
            // 
            this.dosagemText.Location = new System.Drawing.Point(87, 45);
            this.dosagemText.Name = "dosagemText";
            this.dosagemText.Size = new System.Drawing.Size(168, 22);
            this.dosagemText.TabIndex = 2;
            // 
            // dosagemLabel
            // 
            this.dosagemLabel.AutoSize = true;
            this.dosagemLabel.Location = new System.Drawing.Point(9, 48);
            this.dosagemLabel.Name = "dosagemLabel";
            this.dosagemLabel.Size = new System.Drawing.Size(72, 17);
            this.dosagemLabel.TabIndex = 24;
            this.dosagemLabel.Text = "Dosagem:";
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(116, 213);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(121, 23);
            this.limparButton.TabIndex = 5;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(12, 213);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(98, 23);
            this.cancelarButton.TabIndex = 6;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // MedicamentoCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.dosagemLabel);
            this.Controls.Add(this.dosagemText);
            this.Controls.Add(this.descText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.nomeLabel);
            this.Name = "MedicamentoCadastroForm";
            this.Text = "MedicamentoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox dosagemText;
        private System.Windows.Forms.Label dosagemLabel;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}