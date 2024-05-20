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
            form.Close();
        }
    }
}
