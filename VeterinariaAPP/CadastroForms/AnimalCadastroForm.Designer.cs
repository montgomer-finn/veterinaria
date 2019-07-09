namespace VeterinariaAPP
{
    partial class AnimalCadastroForm
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
            this.humanoTxt = new System.Windows.Forms.TextBox();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.HumanoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.dataLabel = new System.Windows.Forms.Label();
            this.limparButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.Location = new System.Drawing.Point(226, 164);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(129, 23);
            this.cadastrarButton.TabIndex = 4;
            this.cadastrarButton.Text = "Gravar";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
            // 
            // humanoTxt
            // 
            this.humanoTxt.Location = new System.Drawing.Point(155, 49);
            this.humanoTxt.Name = "humanoTxt";
            this.humanoTxt.Size = new System.Drawing.Size(200, 22);
            this.humanoTxt.TabIndex = 1;
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(155, 12);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(200, 22);
            this.nomeTxt.TabIndex = 0;
            // 
            // HumanoLabel
            // 
            this.HumanoLabel.AutoSize = true;
            this.HumanoLabel.Location = new System.Drawing.Point(9, 52);
            this.HumanoLabel.Name = "HumanoLabel";
            this.HumanoLabel.Size = new System.Drawing.Size(82, 17);
            this.HumanoLabel.TabIndex = 7;
            this.HumanoLabel.Text = "Humano ID:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(9, 17);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(49, 17);
            this.nomeLabel.TabIndex = 6;
            this.nomeLabel.Text = "Nome:";
            // 
            // dataNascimento
            // 
            this.dataNascimento.Location = new System.Drawing.Point(155, 86);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(200, 22);
            this.dataNascimento.TabIndex = 2;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(9, 91);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(140, 17);
            this.dataLabel.TabIndex = 13;
            this.dataLabel.Text = "Data de Nascimento:";
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(105, 164);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(115, 23);
            this.limparButton.TabIndex = 5;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(9, 164);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(90, 23);
            this.cancelarButton.TabIndex = 6;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tipo:";
            // 
            // tipoTxt
            // 
            this.tipoTxt.Location = new System.Drawing.Point(155, 120);
            this.tipoTxt.Name = "tipoTxt";
            this.tipoTxt.Size = new System.Drawing.Size(200, 22);
            this.tipoTxt.TabIndex = 3;
            // 
            // AnimalCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.tipoTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.humanoTxt);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.HumanoLabel);
            this.Controls.Add(this.nomeLabel);
            this.Name = "AnimalCadastroForm";
            this.Text = "AnimalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnimalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.TextBox humanoTxt;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label HumanoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tipoTxt;
    }
}