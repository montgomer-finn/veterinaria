namespace VeterinariaAPP.ConsultaForms
{
    partial class TipoConsultaForm
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
            this.editarButton = new System.Windows.Forms.Button();
            this.infoLbl = new System.Windows.Forms.Label();
            this.optionsCombo = new System.Windows.Forms.ComboBox();
            this.pesqButton = new System.Windows.Forms.Button();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.tiposDGV = new System.Windows.Forms.DataGridView();
            this.mostrarTodosButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tiposDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(433, 518);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(300, 23);
            this.excluirButton.TabIndex = 4;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(10, 518);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(300, 23);
            this.editarButton.TabIndex = 3;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(9, 61);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(360, 17);
            this.infoLbl.TabIndex = 46;
            this.infoLbl.Text = "Clique duas vezes em um cadastro para exibir detalhes.";
            // 
            // optionsCombo
            // 
            this.optionsCombo.FormattingEnabled = true;
            this.optionsCombo.Location = new System.Drawing.Point(52, 13);
            this.optionsCombo.Name = "optionsCombo";
            this.optionsCombo.Size = new System.Drawing.Size(121, 24);
            this.optionsCombo.TabIndex = 0;
            // 
            // pesqButton
            // 
            this.pesqButton.Location = new System.Drawing.Point(285, 13);
            this.pesqButton.Name = "pesqButton";
            this.pesqButton.Size = new System.Drawing.Size(91, 23);
            this.pesqButton.TabIndex = 2;
            this.pesqButton.Text = "Pesquisar";
            this.pesqButton.UseVisualStyleBackColor = true;
            this.pesqButton.Click += new System.EventHandler(this.PesqButton_Click);
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(179, 16);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(100, 22);
            this.nomeTxt.TabIndex = 1;
            // 
            // tiposDGV
            // 
            this.tiposDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tiposDGV.Location = new System.Drawing.Point(12, 81);
            this.tiposDGV.Name = "tiposDGV";
            this.tiposDGV.ReadOnly = true;
            this.tiposDGV.RowTemplate.Height = 24;
            this.tiposDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tiposDGV.Size = new System.Drawing.Size(721, 431);
            this.tiposDGV.TabIndex = 42;
            this.tiposDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TiposDGV_CellDoubleClick);
            // 
            // mostrarTodosButton
            // 
            this.mostrarTodosButton.Location = new System.Drawing.Point(554, 16);
            this.mostrarTodosButton.Name = "mostrarTodosButton";
            this.mostrarTodosButton.Size = new System.Drawing.Size(134, 23);
            this.mostrarTodosButton.TabIndex = 47;
            this.mostrarTodosButton.Text = "Mostrar Todos";
            this.mostrarTodosButton.UseVisualStyleBackColor = true;
            this.mostrarTodosButton.Visible = false;
            this.mostrarTodosButton.Click += new System.EventHandler(this.MostrarTodosButton_Click);
            // 
            // TipoConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 553);
            this.Controls.Add(this.mostrarTodosButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.optionsCombo);
            this.Controls.Add(this.pesqButton);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.tiposDGV);
            this.Name = "TipoConsultaForm";
            this.Text = "TipoConsultaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.TipoConsultaForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.tiposDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.ComboBox optionsCombo;
        private System.Windows.Forms.Button pesqButton;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.DataGridView tiposDGV;
        private System.Windows.Forms.Button mostrarTodosButton;
    }
}