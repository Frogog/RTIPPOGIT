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
    public partial class BetForm : Form
    {
        private Party thisGame;
        Player player;
        public int bet = 0;
        public BetForm(Player player, Party thisGame)
        {
            InitializeComponent();
            this.player = player;
            this.thisGame = thisGame;
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if ((chipsCount.Text.Trim().Length > 0) && (int.TryParse(chipsCount.Text, out int number) && (Convert.ToInt16(chipsCount.Text.Trim()) > 0)))
            {
                if (Convert.ToInt16(chipsCount.Text.Trim()) <= player.Chips)
                {
                    bet = int.Parse(chipsCount.Text);
                    //thisGame.Bank += int.Parse(chipsCount.Text);
                    //player.Chips -= Convert.ToInt16(chipsCount.Text.Trim());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("У вас не хватает фишек");
                }
            }
            else MessageBox.Show("Введите целое число больше единицы");
        }

        private void BetForm_Load(object sender, EventArgs e)
        {
            name.Text = player.Name;
            chips.Text = "Фишки: " + player.Chips.ToString();
        }
    }
}
