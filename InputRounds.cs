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
    public partial class InputRounds : Form
    {
        private Party thisGame;
        public InputRounds(Party thisGame)
        {
            InitializeComponent();
            this.thisGame = thisGame;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Trim().Length > 0) && (int.TryParse(textBox1.Text, out int number) && (Convert.ToInt16(textBox1.Text.Trim()) > 0)))
            {
                thisGame.SetRounds(Convert.ToInt16(textBox1.Text.Trim()));
                this.Close();
            }
            else MessageBox.Show("Введите целое число больше нуля");
        }

        private void InputRounds_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exitResult = MessageBox.Show(
                "Вы уверены, что хотите закончить ввод количества раундов?",
                "Подтвердите выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (exitResult == DialogResult.No) e.Cancel = true;
        }
    }
}
