namespace VeterinariaAPP
{
    partial class VeterinarioCadastroForm
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
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.CPFLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.limparButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.CPFTxt = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.Location = new System.Drawing.Point(251, 96);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(111, 23);
            this.cadastrarButton.TabIndex = 2;
            this.cadastrarButton.Text = "Gravar";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(67, 12);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(188, 22);
            this.nomeTxt.TabIndex = 0;
            // 
            // CPFLabel
            // 
            this.CPFLabel.AutoSize = true;
            this.CPFLabel.Location = new System.Drawing.Point(12, 44);
            this.CPFLabel.Name = "CPFLabel";
            this.CPFLabel.Size = new System.Drawing.Size(38, 17);
            this.CPFLabel.TabIndex = 7;
            this.CPFLabel.Text = "CPF:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(12, 15);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(49, 17);
            this.nomeLabel.TabIndex = 6;
            this.nomeLabel.Text = "Nome:";
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(115, 96);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(130, 23);
            this.limparButton.TabIndex = 3;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(12, 96);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(97, 23);
            this.cancelarButton.TabIndex = 4;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // CPFTxt
            // 
            this.CPFTxt.Location = new System.Drawing.Point(67, 41);
            this.CPFTxt.Mask = "000.000.000-00";
            this.CPFTxt.Name = "CPFTxt";
            this.CPFTxt.Size = new System.Drawing.Size(188, 22);
            this.CPFTxt.TabIndex = 1;
            // 
            // VeterinarioCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.CPFTxt);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.CPFLabel);
            this.Controls.Add(this.nomeLabel);
            this.Name = "VeterinarioCadastroForm";
            this.Text = "VeterinarioForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VeterinarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label CPFLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.MaskedTextBox CPFTxt;
    }
}