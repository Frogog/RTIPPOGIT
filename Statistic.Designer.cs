namespace RTIPPOGIT
{
    partial class Statistic
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
            this.table = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сhips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableHeader = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.bankLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.score,
            this.bet,
            this.сhips});
            this.table.Location = new System.Drawing.Point(12, 37);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(393, 365);
            this.table.TabIndex = 2;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 62;
            // 
            // score
            // 
            this.score.HeaderText = "Счет";
            this.score.MinimumWidth = 6;
            this.score.Name = "score";
            this.score.ReadOnly = true;
            this.score.Width = 68;
            // 
            // bet
            // 
            this.bet.HeaderText = "Ставка";
            this.bet.MinimumWidth = 6;
            this.bet.Name = "bet";
            this.bet.ReadOnly = true;
            this.bet.Width = 83;
            // 
            // сhips
            // 
            this.сhips.HeaderText = "Баланс";
            this.сhips.MinimumWidth = 6;
            this.сhips.Name = "сhips";
            this.сhips.ReadOnly = true;
            this.сhips.Width = 79;
            // 
            // tableHeader
            // 
            this.tableHeader.AutoSize = true;
            this.tableHeader.Location = new System.Drawing.Point(12, 9);
            this.tableHeader.Name = "tableHeader";
            this.tableHeader.Size = new System.Drawing.Size(120, 16);
            this.tableHeader.TabIndex = 3;
            this.tableHeader.Text = "Результаты игры";
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Location = new System.Drawing.Point(180, 9);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(142, 16);
            this.winnerLabel.TabIndex = 4;
            this.winnerLabel.Text = "Победитель: Игрок 1";
            this.winnerLabel.Visible = false;
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Location = new System.Drawing.Point(339, 9);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(66, 16);
            this.bankLabel.TabIndex = 5;
            this.bankLabel.Text = "Банк: 230";
            this.bankLabel.Visible = false;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 414);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.tableHeader);
            this.Controls.Add(this.table);
            this.Name = "Statistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Statistic_FormClosing);
            this.Load += new System.EventHandler(this.Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn bet;
        private System.Windows.Forms.DataGridViewTextBoxColumn сhips;
        private System.Windows.Forms.Label tableHeader;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label bankLabel;
    }
}