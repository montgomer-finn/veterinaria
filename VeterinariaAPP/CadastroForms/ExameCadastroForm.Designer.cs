namespace VeterinariaAPP
{
    partial class ExameCadastroForm
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
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.precoTxt = new System.Windows.Forms.TextBox();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.precoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descText = new System.Windows.Forms.RichTextBox();
            this.limparButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.Location = new System.Drawing.Point(233, 169);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(137, 23);
            this.cadastrarButton.TabIndex = 3;
            this.cadastrarButton.Text = "Gravar";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
            // 
            // precoTxt
            // 
            this.precoTxt.Location = new System.Drawing.Point(67, 41);
            this.precoTxt.Name = "precoTxt";
            this.precoTxt.Size = new System.Drawing.Size(188, 22);
            this.precoTxt.TabIndex = 1;
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(67, 12);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(188, 22);
            this.nomeTxt.TabIndex = 0;
            // 
            // precoLabel
            // 
            this.precoLabel.AutoSize = true;
            this.precoLabel.Location = new System.Drawing.Point(12, 38);
            this.precoLabel.Name = "precoLabel";
            this.precoLabel.Size = new System.Drawing.Size(49, 17);
            this.precoLabel.TabIndex = 7;
            this.precoLabel.Text = "Preço:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(12, 9);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(49, 17);
            this.nomeLabel.TabIndex = 6;
            this.nomeLabel.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Descrição:";
            // 
            // descText
            // 
            this.descText.HideSelection = false;
            this.descText.Location = new System.Drawing.Point(12, 91);
            this.descText.Name = "descText";
            this.descText.Size = new System.Drawing.Size(243, 63);
            this.descText.TabIndex = 2;
            this.descText.Text = "";
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(110, 169);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(117, 23);
            this.limparButton.TabIndex = 4;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(-2, 169);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(106, 23);
            this.cancelarButton.TabIndex = 5;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ExameCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.descText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.precoTxt);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.precoLabel);
            this.Controls.Add(this.nomeLabel);
            this.Name = "ExameCadastroForm";
            this.Text = "ExameForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExameCadastroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.TextBox precoTxt;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label precoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descText;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}