namespace RTIPPOGIT
{
    partial class Field
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.statB = new System.Windows.Forms.Button();
            this.bank = new System.Windows.Forms.Label();
            this.round = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.playB = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.turnTable = new System.Windows.Forms.DataGridView();
            this.idT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuesT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDiceImage3 = new System.Windows.Forms.PictureBox();
            this.scoreDiceImage2 = new System.Windows.Forms.PictureBox();
            this.scoreDiceImage1 = new System.Windows.Forms.PictureBox();
            this.diceImage3 = new System.Windows.Forms.PictureBox();
            this.diceImage2 = new System.Windows.Forms.PictureBox();
            this.diceImage1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.turnTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDiceImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDiceImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDiceImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statB
            // 
            this.statB.Location = new System.Drawing.Point(44, 295);
            this.statB.Name = "statB";
            this.statB.Size = new System.Drawing.Size(214, 37);
            this.statB.TabIndex = 29;
            this.statB.Text = "Статистика";
            this.statB.UseVisualStyleBackColor = true;
            this.statB.Click += new System.EventHandler(this.statB_Click);
            // 
            // bank
            // 
            this.bank.AutoSize = true;
            this.bank.Location = new System.Drawing.Point(239, 9);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(52, 16);
            this.bank.TabIndex = 24;
            this.bank.Text = "Банк: 1";
            // 
            // round
            // 
            this.round.AutoSize = true;
            this.round.Location = new System.Drawing.Point(120, 9);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(61, 16);
            this.round.TabIndex = 23;
            this.round.Text = "Раунд: 1";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(56, 16);
            this.name.TabIndex = 20;
            this.name.Text = "Игрок 1";
            // 
            // playB
            // 
            this.playB.Location = new System.Drawing.Point(44, 252);
            this.playB.Name = "playB";
            this.playB.Size = new System.Drawing.Size(214, 37);
            this.playB.TabIndex = 19;
            this.playB.Text = "Разыграть";
            this.playB.UseVisualStyleBackColor = true;
            this.playB.Click += new System.EventHandler(this.playB_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(124, 55);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(49, 16);
            this.scoreLabel.TabIndex = 34;
            this.scoreLabel.Text = "Счет 0";
            // 
            // turnTable
            // 
            this.turnTable.AllowUserToAddRows = false;
            this.turnTable.AllowUserToDeleteRows = false;
            this.turnTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turnTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idT,
            this.nameT,
            this.valuesT,
            this.scoreT});
            this.turnTable.Location = new System.Drawing.Point(327, 28);
            this.turnTable.Name = "turnTable";
            this.turnTable.ReadOnly = true;
            this.turnTable.RowHeadersVisible = false;
            this.turnTable.RowHeadersWidth = 51;
            this.turnTable.RowTemplate.Height = 24;
            this.turnTable.Size = new System.Drawing.Size(256, 304);
            this.turnTable.TabIndex = 39;
            // 
            // idT
            // 
            this.idT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idT.HeaderText = "ID";
            this.idT.MinimumWidth = 6;
            this.idT.Name = "idT";
            this.idT.ReadOnly = true;
            this.idT.Visible = false;
            this.idT.Width = 125;
            // 
            // nameT
            // 
            this.nameT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameT.HeaderText = "Имя";
            this.nameT.MinimumWidth = 6;
            this.nameT.Name = "nameT";
            this.nameT.ReadOnly = true;
            this.nameT.Width = 62;
            // 
            // valuesT
            // 
            this.valuesT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valuesT.HeaderText = "Кости";
            this.valuesT.MinimumWidth = 6;
            this.valuesT.Name = "valuesT";
            this.valuesT.ReadOnly = true;
            this.valuesT.Width = 74;
            // 
            // scoreT
            // 
            this.scoreT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.scoreT.HeaderText = "Счет";
            this.scoreT.MinimumWidth = 6;
            this.scoreT.Name = "scoreT";
            this.scoreT.ReadOnly = true;
            this.scoreT.Width = 68;
            // 
            // scoreDiceImage3
            // 
            this.scoreDiceImage3.Image = global::RTIPPOGIT.Properties.Resources.Side_0;
            this.scoreDiceImage3.Location = new System.Drawing.Point(179, 86);
            this.scoreDiceImage3.Name = "scoreDiceImage3";
            this.scoreDiceImage3.Size = new System.Drawing.Size(50, 50);
            this.scoreDiceImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scoreDiceImage3.TabIndex = 36;
            this.scoreDiceImage3.TabStop = false;
            // 
            // scoreDiceImage2
            // 
            this.scoreDiceImage2.Image = global::RTIPPOGIT.Properties.Resources.Side_0;
            this.scoreDiceImage2.Location = new System.Drawing.Point(123, 86);
            this.scoreDiceImage2.Name = "scoreDiceImage2";
            this.scoreDiceImage2.Size = new System.Drawing.Size(50, 50);
            this.scoreDiceImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scoreDiceImage2.TabIndex = 35;
            this.scoreDiceImage2.TabStop = false;
            // 
            // scoreDiceImage1
            // 
            this.scoreDiceImage1.Image = global::RTIPPOGIT.Properties.Resources.Side_0;
            this.scoreDiceImage1.Location = new System.Drawing.Point(67, 86);
            this.scoreDiceImage1.Name = "scoreDiceImage1";
            this.scoreDiceImage1.Size = new System.Drawing.Size(50, 50);
            this.scoreDiceImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scoreDiceImage1.TabIndex = 33;
            this.scoreDiceImage1.TabStop = false;
            // 
            // diceImage3
            // 
            this.diceImage3.BackColor = System.Drawing.Color.BurlyWood;
            this.diceImage3.Location = new System.Drawing.Point(179, 162);
            this.diceImage3.Name = "diceImage3";
            this.diceImage3.Size = new System.Drawing.Size(50, 50);
            this.diceImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceImage3.TabIndex = 32;
            this.diceImage3.TabStop = false;
            // 
            // diceImage2
            // 
            this.diceImage2.BackColor = System.Drawing.Color.BurlyWood;
            this.diceImage2.Location = new System.Drawing.Point(123, 162);
            this.diceImage2.Name = "diceImage2";
            this.diceImage2.Size = new System.Drawing.Size(50, 50);
            this.diceImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceImage2.TabIndex = 31;
            this.diceImage2.TabStop = false;
            // 
            // diceImage1
            // 
            this.diceImage1.BackColor = System.Drawing.Color.BurlyWood;
            this.diceImage1.Location = new System.Drawing.Point(67, 162);
            this.diceImage1.Name = "diceImage1";
            this.diceImage1.Size = new System.Drawing.Size(50, 50);
            this.diceImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceImage1.TabIndex = 30;
            this.diceImage1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox1.Location = new System.Drawing.Point(44, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 95);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // tableHeader
            // 
            this.tableHeader.AutoSize = true;
            this.tableHeader.Location = new System.Drawing.Point(327, 9);
            this.tableHeader.Name = "tableHeader";
            this.tableHeader.Size = new System.Drawing.Size(127, 16);
            this.tableHeader.TabIndex = 42;
            this.tableHeader.Text = "Результаты ходов";
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(595, 341);
            this.Controls.Add(this.tableHeader);
            this.Controls.Add(this.turnTable);
            this.Controls.Add(this.scoreDiceImage3);
            this.Controls.Add(this.scoreDiceImage2);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreDiceImage1);
            this.Controls.Add(this.diceImage3);
            this.Controls.Add(this.diceImage2);
            this.Controls.Add(this.diceImage1);
            this.Controls.Add(this.statB);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.round);
            this.Controls.Add(this.name);
            this.Controls.Add(this.playB);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Field";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игровая доска";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Field_FormClosing);
            this.Load += new System.EventHandler(this.Field_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turnTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDiceImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDiceImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDiceImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox diceImage3;
        private System.Windows.Forms.PictureBox diceImage2;
        private System.Windows.Forms.PictureBox diceImage1;
        private System.Windows.Forms.Button statB;
        private System.Windows.Forms.Label bank;
        private System.Windows.Forms.Label round;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button playB;
        private System.Windows.Forms.PictureBox scoreDiceImage1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox scoreDiceImage2;
        private System.Windows.Forms.PictureBox scoreDiceImage3;
        private System.Windows.Forms.DataGridView turnTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameT;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuesT;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tableHeader;
    }
}

