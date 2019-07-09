namespace VeterinariaAPP
{
    partial class AgendaForm
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
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.agendaDGV = new System.Windows.Forms.DataGridView();
            this.procurarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(18, 18);
            this.calendario.MaxSelectionCount = 31;
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 0;
            // 
            // agendaDGV
            // 
            this.agendaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agendaDGV.Location = new System.Drawing.Point(344, 18);
            this.agendaDGV.Name = "agendaDGV";
            this.agendaDGV.ReadOnly = true;
            this.agendaDGV.RowTemplate.Height = 24;
            this.agendaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.agendaDGV.Size = new System.Drawing.Size(765, 589);
            this.agendaDGV.TabIndex = 4;
            this.agendaDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgendaDGV_CellDoubleClick);
            // 
            // procurarButton
            // 
            this.procurarButton.Location = new System.Drawing.Point(109, 237);
            this.procurarButton.Name = "procurarButton";
            this.procurarButton.Size = new System.Drawing.Size(75, 23);
            this.procurarButton.TabIndex = 5;
            this.procurarButton.Text = "Procurar";
            this.procurarButton.UseVisualStyleBackColor = true;
            this.procurarButton.Visible = false;
            this.procurarButton.Click += new System.EventHandler(this.ProcurarButton_Click);
            // 
            // AgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 619);
            this.Controls.Add(this.procurarButton);
            this.Controls.Add(this.agendaDGV);
            this.Controls.Add(this.calendario);
            this.Name = "AgendaForm";
            this.Text = "AgendaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.agendaDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.DataGridView agendaDGV;
        private System.Windows.Forms.Button procurarButton;
    }
}