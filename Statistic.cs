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
        public Statistic(Party thisParty)
        {
            InitializeComponent();
            this.thisParty = thisParty;
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            foreach (Player player in thisParty.PlayersList)
            {
                table.Rows.Add(player.Name, player.Score, 100 - player.Chips);
            }
        }
    }
}
