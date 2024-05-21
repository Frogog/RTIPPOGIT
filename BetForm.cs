using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIPPOGIT
{
    public partial class BetForm : Form
    {
        Party thisParty;
        public int[] bet;
        private int playerID = 0;
        public BetForm(Party thisParty)
        {
            InitializeComponent();
            this.thisParty = thisParty;
            this.bet = new int[thisParty.PlayersList.Length];
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if ((chipsCount.Text.Trim().Length > 0) && (int.TryParse(chipsCount.Text, out int number) && (Convert.ToInt16(chipsCount.Text.Trim()) > 0)))
            {
                if (Convert.ToInt16(chipsCount.Text.Trim()) <= thisParty.PlayersList[playerID].Chips)
                {
                    bet[playerID]= int.Parse(chipsCount.Text);
                    if (playerID >= thisParty.PlayersList.Length-1) this.Close();
                    else {
                        playerID++;
                        changeHeader();
                    }
                }
                else
                {
                    MessageBox.Show("У игрока не хватает фишек");
                }
            }
            else MessageBox.Show("Введите целое число больше единицы");
        }

        private void BetForm_Load(object sender, EventArgs e)
        {
            changeHeader();
        }
        private void changeHeader() {
            name.Text = thisParty.PlayersList[playerID].Name;
            chips.Text = "Баланс: " + thisParty.PlayersList[playerID].Chips.ToString();
            chipsCount.Value = 1;
            chipsCount.Maximum = thisParty.PlayersList[playerID].Chips;
        }
        private void BetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult exitResult = MessageBox.Show(
            //    "Вы уверены, что хотите закончить ввод ставки?",
            //    "Подтвердите выход",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question,
            //    MessageBoxDefaultButton.Button2);
            //if (exitResult == DialogResult.No) e.Cancel = true;
        }
    }
}
