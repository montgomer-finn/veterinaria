namespace VeterinariaAPP.OutroForms
{
    partial class PagamentoContaReceberForm
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
            this.contaIDLabel = new System.Windows.Forms.Label();
            this.contaIDTxt = new System.Windows.Forms.Label();
            this.valorTotalLabel = new System.Windows.Forms.Label();
            this.valorTotalTxt = new System.Windows.Forms.Label();
            this.valorAbatidoLabel = new System.Windows.Forms.Label();
            this.valorAbatidoTxt = new System.Windows.Forms.Label();
            this.valorPagoLabel = new System.Windows.Forms.Label();
            this.valorPagoTxt = new System.Windows.Forms.TextBox();
            this.pagarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contaIDLabel
            // 
            this.contaIDLabel.AutoSize = true;
            this.contaIDLabel.Location = new System.Drawing.Point(23, 13);
            this.contaIDLabel.Name = "contaIDLabel";
            this.contaIDLabel.Size = new System.Drawing.Size(62, 17);
            this.contaIDLabel.TabIndex = 0;
            this.contaIDLabel.Text = "ContaID:";
            // 
            // contaIDTxt
            // 
            this.contaIDTxt.AutoSize = true;
            this.contaIDTxt.Location = new System.Drawing.Point(123, 13);
            this.contaIDTxt.Name = "contaIDTxt";
            this.contaIDTxt.Size = new System.Drawing.Size(39, 17);
            this.contaIDTxt.TabIndex = 1;
            this.contaIDTxt.Text = "teste";
            // 
            // valorTotalLabel
            // 
            this.valorTotalLabel.AutoSize = true;
            this.valorTotalLabel.Location = new System.Drawing.Point(23, 46);
            this.valorTotalLabel.Name = "valorTotalLabel";
            this.valorTotalLabel.Size = new System.Drawing.Size(81, 17);
            this.valorTotalLabel.TabIndex = 2;
            this.valorTotalLabel.Text = "Valor Total:";
            // 
            // valorTotalTxt
            // 
            this.valorTotalTxt.AutoSize = true;
            this.valorTotalTxt.Location = new System.Drawing.Point(123, 46);
            this.valorTotalTxt.Name = "valorTotalTxt";
            this.valorTotalTxt.Size = new System.Drawing.Size(39, 17);
            this.valorTotalTxt.TabIndex = 3;
            this.valorTotalTxt.Text = "teste";
            // 
            // valorAbatidoLabel
            // 
            this.valorAbatidoLabel.AutoSize = true;
            this.valorAbatidoLabel.Location = new System.Drawing.Point(23, 87);
            this.valorAbatidoLabel.Name = "valorAbatidoLabel";
            this.valorAbatidoLabel.Size = new System.Drawing.Size(93, 17);
            this.valorAbatidoLabel.TabIndex = 4;
            this.valorAbatidoLabel.Text = "Valor Abatido";
            // 
            // valorAbatidoTxt
            // 
            this.valorAbatidoTxt.AutoSize = true;
            this.valorAbatidoTxt.Location = new System.Drawing.Point(123, 87);
            this.valorAbatidoTxt.Name = "valorAbatidoTxt";
            this.valorAbatidoTxt.Size = new System.Drawing.Size(39, 17);
            this.valorAbatidoTxt.TabIndex = 5;
            this.valorAbatidoTxt.Text = "teste";
            // 
            // valorPagoLabel
            // 
            this.valorPagoLabel.AutoSize = true;
            this.valorPagoLabel.Location = new System.Drawing.Point(23, 128);
            this.valorPagoLabel.Name = "valorPagoLabel";
            this.valorPagoLabel.Size = new System.Drawing.Size(82, 17);
            this.valorPagoLabel.TabIndex = 6;
            this.valorPagoLabel.Text = "Valor Pago:";
            // 
            // valorPagoTxt
            // 
            this.valorPagoTxt.Location = new System.Drawing.Point(126, 123);
            this.valorPagoTxt.Name = "valorPagoTxt";
            this.valorPagoTxt.Size = new System.Drawing.Size(100, 22);
            this.valorPagoTxt.TabIndex = 7;
            // 
            // pagarButton
            // 
            this.pagarButton.Location = new System.Drawing.Point(126, 163);
            this.pagarButton.Name = "pagarButton";
            this.pagarButton.Size = new System.Drawing.Size(75, 23);
            this.pagarButton.TabIndex = 8;
            this.pagarButton.Text = "Pagar";
            this.pagarButton.UseVisualStyleBackColor = true;
            this.pagarButton.Click += new System.EventHandler(this.PagarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(26, 163);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 9;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // PagamentoContaReceberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 223);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.pagarButton);
            this.Controls.Add(this.valorPagoTxt);
            this.Controls.Add(this.valorPagoLabel);
            this.Controls.Add(this.valorAbatidoTxt);
            this.Controls.Add(this.valorAbatidoLabel);
            this.Controls.Add(this.valorTotalTxt);
            this.Controls.Add(this.valorTotalLabel);
            this.Controls.Add(this.contaIDTxt);
            this.Controls.Add(this.contaIDLabel);
            this.Name = "PagamentoContaReceberForm";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contaIDLabel;
        private System.Windows.Forms.Label contaIDTxt;
        private System.Windows.Forms.Label valorTotalLabel;
        private System.Windows.Forms.Label valorTotalTxt;
        private System.Windows.Forms.Label valorAbatidoLabel;
        private System.Windows.Forms.Label valorAbatidoTxt;
        private System.Windows.Forms.Label valorPagoLabel;
        private System.Windows.Forms.TextBox valorPagoTxt;
        private System.Windows.Forms.Button pagarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}