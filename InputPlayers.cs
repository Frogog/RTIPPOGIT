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

namespace RTIPPOGIT
{
    public partial class InputPlayers : Form
    {
        private Party thisGame;
        public InputPlayers(Party thisGame)
        {
            InitializeComponent();
            this.thisGame = thisGame;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Trim().Length > 0) && (int.TryParse(textBox1.Text, out int number) && (Convert.ToInt16(textBox1.Text.Trim()) > 1)))
            {
                thisGame.SetPlayers(Convert.ToInt16(textBox1.Text.Trim()));
                this.Close();
            }
            else MessageBox.Show("Введите целое число больше единицы");
        }

        private void InputPlayers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult exitResult = MessageBox.Show(
            //    "Вы уверены, что хотите закончить ввод количества игроков?",
            //    "Подтвердите выход", 
            //    MessageBoxButtons.YesNo, 
            //    MessageBoxIcon.Question, 
            //    MessageBoxDefaultButton.Button2);
            //if (exitResult == DialogResult.No) e.Cancel = true;
        }
    }
}
