using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIPPOGIT
{
    public partial class Statistic : Form
    {
        private Party thisParty;
        private string endStat;
        private Field form;
        public Statistic(Party thisParty,string endStat,Field form)
        {
            InitializeComponent();
            this.thisParty = thisParty;
            this.endStat = endStat;
            this.form = form;
            
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            if (endStat == "Конец") { 
                winnerLabel.Visible = true;
                bankLabel.Visible = true;
                winnerLabel.Text = "Победитель: " + thisParty.RoundsList[thisParty.RoundsList.Length - 1].WinnersList[0].Name;
                bankLabel.Text = "Банк: " + thisParty.Bank;
            }
            foreach (Player player in thisParty.PlayersList)
            {
                if ((endStat == "Конец") && 
                    (thisParty.RoundsList[thisParty.RoundsList.Length-1].WinnersList.Contains(player))) 
                table.Rows.Add(player.Name, player.Score, (player.Chips-thisParty.Bank-100)*-1,player.Chips);
                else table.Rows.Add(player.Name, player.Score, 100-player.Chips,player.Chips);
            }
        }

        private void Statistic_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (endStat == "Конец") {
                DialogResult exitResult = MessageBox.Show(
                "Вы уверены, что хотите выйти из игры?",
                "Подтвердите выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
                if (exitResult == DialogResult.No) e.Cancel = true;
                else form.Close();
            }
                
        }
    }
}
