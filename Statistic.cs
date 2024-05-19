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
        public Statistic(Party thisParty,string endStat)
        {
            InitializeComponent();
            this.thisParty = thisParty;
            this.endStat = endStat;
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            foreach (Player player in thisParty.PlayersList)
            {
                if ((endStat == "Конец") && 
                    (thisParty.RoundsList[thisParty.RoundsList.Length-1].WinnersList.Contains(player))) 
                table.Rows.Add(player.Name, player.Score, (player.Chips-thisParty.Bank-100)*-1);
                else table.Rows.Add(player.Name, player.Score, 100-player.Chips);
            }
        }
    }
}
