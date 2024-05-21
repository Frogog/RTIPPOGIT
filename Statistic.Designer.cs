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
            this.allTurn = new System.Windows.Forms.DataGridView();
            this.round = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreTurn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTurn)).BeginInit();
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
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(462, 365);
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
            // allTurn
            // 
            this.allTurn.AllowUserToAddRows = false;
            this.allTurn.AllowUserToDeleteRows = false;
            this.allTurn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allTurn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.round,
            this.turnName,
            this.scoreTurn,
            this.turn,
            this.winner});
            this.allTurn.Location = new System.Drawing.Point(480, 12);
            this.allTurn.Name = "allTurn";
            this.allTurn.ReadOnly = true;
            this.allTurn.RowHeadersWidth = 51;
            this.allTurn.RowTemplate.Height = 24;
            this.allTurn.Size = new System.Drawing.Size(447, 365);
            this.allTurn.TabIndex = 3;
            // 
            // round
            // 
            this.round.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.round.HeaderText = "Раунд";
            this.round.MinimumWidth = 6;
            this.round.Name = "round";
            this.round.ReadOnly = true;
            this.round.Width = 77;
            // 
            // turnName
            // 
            this.turnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.turnName.HeaderText = "Имя";
            this.turnName.MinimumWidth = 6;
            this.turnName.Name = "turnName";
            this.turnName.ReadOnly = true;
            this.turnName.Width = 62;
            // 
            // scoreTurn
            // 
            this.scoreTurn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.scoreTurn.HeaderText = "Счет";
            this.scoreTurn.MinimumWidth = 6;
            this.scoreTurn.Name = "scoreTurn";
            this.scoreTurn.ReadOnly = true;
            this.scoreTurn.Width = 68;
            // 
            // turn
            // 
            this.turn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.turn.HeaderText = "Ход";
            this.turn.MinimumWidth = 6;
            this.turn.Name = "turn";
            this.turn.ReadOnly = true;
            this.turn.Width = 60;
            // 
            // winner
            // 
            this.winner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.winner.HeaderText = "Победитель";
            this.winner.MinimumWidth = 6;
            this.winner.Name = "winner";
            this.winner.ReadOnly = true;
            this.winner.Width = 116;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 459);
            this.Controls.Add(this.allTurn);
            this.Controls.Add(this.table);
            this.Name = "Statistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Statistic_FormClosing);
            this.Load += new System.EventHandler(this.Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTurn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn bet;
        private System.Windows.Forms.DataGridViewTextBoxColumn сhips;
        private System.Windows.Forms.DataGridView allTurn;
        private System.Windows.Forms.DataGridViewTextBoxColumn round;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreTurn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winner;
    }
}