namespace RTIPPOGIT
{
    partial class InputSettings
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
            this.confirmB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerAmount = new System.Windows.Forms.NumericUpDown();
            this.roundAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.playerAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmB
            // 
            this.confirmB.Location = new System.Drawing.Point(11, 64);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(289, 36);
            this.confirmB.TabIndex = 5;
            this.confirmB.Text = "Подтвердить";
            this.confirmB.UseVisualStyleBackColor = true;
            this.confirmB.Click += new System.EventHandler(this.confirmB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество игроков";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество раундов";
            // 
            // playerAmount
            // 
            this.playerAmount.Location = new System.Drawing.Point(15, 36);
            this.playerAmount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.playerAmount.Name = "playerAmount";
            this.playerAmount.Size = new System.Drawing.Size(138, 22);
            this.playerAmount.TabIndex = 8;
            this.playerAmount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // roundAmount
            // 
            this.roundAmount.Location = new System.Drawing.Point(162, 36);
            this.roundAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roundAmount.Name = "roundAmount";
            this.roundAmount.Size = new System.Drawing.Size(138, 22);
            this.roundAmount.TabIndex = 9;
            this.roundAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InputSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(315, 129);
            this.Controls.Add(this.roundAmount);
            this.Controls.Add(this.playerAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InputSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод игроков и раундов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputPlayers_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.playerAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown playerAmount;
        private System.Windows.Forms.NumericUpDown roundAmount;
    }
}