using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RTIPPOGIT
{
    public partial class InputSettings : Form
    {
        private Party thisParty;
        public InputSettings(Party thisGame)
        {
            InitializeComponent();
            this.thisParty = thisGame;
        }

        private void InputPlayers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult exitResult = MessageBox.Show(
            //    "Вы уверены, что хотите закончить настройку игры?",
            //    "Подтвердите выход", 
            //    MessageBoxButtons.YesNo, 
            //    MessageBoxIcon.Question, 
            //    MessageBoxDefaultButton.Button2);
            //if (exitResult == DialogResult.No) e.Cancel = true;
        }

        private void confirmB_Click(object sender, EventArgs e)
        {
            if ((playerAmount.Text.Trim().Length > 0) && (int.TryParse(playerAmount.Text, out int number) && (Convert.ToInt16(playerAmount.Text.Trim()) > 1)))
            {
                if ((roundAmount.Text.Trim().Length > 0) && (int.TryParse(roundAmount.Text, out int number2) && (Convert.ToInt16(roundAmount.Text.Trim()) > 0)))
                {
                    thisParty.SetPlayers(Convert.ToInt16(playerAmount.Text.Trim()));
                    thisParty.SetRounds(Convert.ToInt16(roundAmount.Text.Trim()));
                    this.Close();
                }
                else MessageBox.Show("Количество раундов должно быть целым числом больше 0");
            }
            else MessageBox.Show("Количество игроков должно быть целым числом больше 1");
        }
    }
}
