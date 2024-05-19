namespace RTIPPOGIT
{
    partial class BetForm
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
            this.chips = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.chipsCount = new System.Windows.Forms.NumericUpDown();
            this.chipsCountL = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chipsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // chips
            // 
            this.chips.AutoSize = true;
            this.chips.Location = new System.Drawing.Point(72, 9);
            this.chips.Name = "chips";
            this.chips.Size = new System.Drawing.Size(53, 16);
            this.chips.TabIndex = 10;
            this.chips.Text = "Фишки:";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(29, 56);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(105, 23);
            this.betButton.TabIndex = 9;
            this.betButton.Text = "Поставить";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // chipsCount
            // 
            this.chipsCount.Location = new System.Drawing.Point(75, 28);
            this.chipsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chipsCount.Name = "chipsCount";
            this.chipsCount.Size = new System.Drawing.Size(78, 22);
            this.chipsCount.TabIndex = 8;
            this.chipsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chipsCountL
            // 
            this.chipsCountL.AutoSize = true;
            this.chipsCountL.Location = new System.Drawing.Point(12, 30);
            this.chipsCountL.Name = "chipsCountL";
            this.chipsCountL.Size = new System.Drawing.Size(57, 16);
            this.chipsCountL.TabIndex = 7;
            this.chipsCountL.Text = "Ставка:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(17, 16);
            this.name.TabIndex = 6;
            this.name.Text = "И";
            // 
            // BetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 106);
            this.Controls.Add(this.chips);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.chipsCount);
            this.Controls.Add(this.chipsCountL);
            this.Controls.Add(this.name);
            this.Name = "BetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод ставки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BetForm_FormClosing);
            this.Load += new System.EventHandler(this.BetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chipsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chips;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.NumericUpDown chipsCount;
        private System.Windows.Forms.Label chipsCountL;
        private System.Windows.Forms.Label name;
    }
}