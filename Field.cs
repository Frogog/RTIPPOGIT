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
    public partial class Field : Form
    {
        private Party thisParty;
        private int diceToThrow = 3;
        public Field()
        {
            InitializeComponent();
        }
        private Dictionary<int, Bitmap> diceSides = new Dictionary<int, Bitmap>()
        {
            [0] = Properties.Resources.Side_0,
            [1] = Properties.Resources.Side_1,
            [2] = Properties.Resources.Side_2,
            [3] = Properties.Resources.Side_3,
            [4] = Properties.Resources.Side_4,
            [5] = Properties.Resources.Side_5,
            [6] = Properties.Resources.Side_6,
        };
        private Dictionary<int, string> message = new Dictionary<int, string>()
        {
            [0] = "Конец",
            [1] = "Бонусный раунд",
            [2] = "Смена раунда",
            [3] = "Смена игрока"
        };
        private void Field_Load(object sender, EventArgs e)
        {
            thisParty = new Party();
            InputSettings inputSettingsForm = new InputSettings(thisParty);
            inputSettingsForm.ShowDialog();
            if ((thisParty.PlayersList == null) || (thisParty.RoundsList == null)) {
                MessageBox.Show("Настройка игры не завершена\nБудет произведен выход из игры","Выход из игры");
                Environment.Exit(0);
            } 
            //thisParty.startBet();
            thisParty.StartGame();
            name.Text = thisParty.CurrentPlayer.Name;
            bank.Text = "Банк: " + thisParty.Bank.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turn currentTurn = thisParty.CurrentRound.TurnsList.FirstOrDefault(i => i.Player.id == thisParty.CurrentPlayer.id);
            thisParty.throwDice(diceToThrow);
            switch (diceToThrow)
            {
                case 3:
                    int max = Math.Max(Math.Max(currentTurn.RollValues[0], currentTurn.RollValues[1]), currentTurn.RollValues[2]);
                    diceImage1.Image = diceSides[currentTurn.RollValues[0]];
                    diceImage2.Image = diceSides[currentTurn.RollValues[1]];
                    diceImage3.Image = diceSides[currentTurn.RollValues[2]];
                    scoreDiceImage1.Image = diceSides[max];
                    diceImage1.Visible = true;
                    diceImage2.Visible = true;
                    diceImage3.Visible = true;
                    break;
                case 2:
                    max = Math.Max(currentTurn.RollValues[3], currentTurn.RollValues[4]);
                    diceImage1.Image = diceSides[currentTurn.RollValues[3]];
                    diceImage2.Image = diceSides[currentTurn.RollValues[4]];
                    scoreDiceImage2.Image = diceSides[max];
                    diceImage3.Visible = false;
                    break;
                case 1:
                    playB.Text = "Передать ход";
                    diceImage1.Image = diceSides[currentTurn.RollValues[5]];
                    scoreDiceImage3.Image = diceSides[currentTurn.RollValues[5]];
                    diceImage2.Visible = false;
                    break;
                case 0:
                    int answer2 = thisParty.ChangePlayer();
                    //Console.WriteLine(answer2);
                    answerTest.Text = message[answer2];
                    if (message[answer2] == "Бонусный раунд") round.Text = message[answer2];
                    if (round.Text != "Бонусный раунд") round.Text = "Раунд: " + (Array.IndexOf(thisParty.RoundsList, thisParty.CurrentRound) + 1).ToString();
                    if ((message[answer2] == "Смена раунда") || (message[answer2] == "Бонусный раунд")) {
                        //if (thisParty.CurrentRound.Reroll != true) 
                        turnTable.Rows.Clear();
                        UpdateTurnTable(answer2);
                    } 
                    if (message[answer2] == "Конец")
                    {
                        this.Hide();
                        Statistic stat = new Statistic(thisParty, "Конец", this);
                        stat.ShowDialog();
                    }
                    name.Text = thisParty.CurrentPlayer.Name;
                    playB.Text = "Разыграть";
                    diceToThrow = 4;
                    scoreDiceImage1.Image = diceSides[0];
                    scoreDiceImage2.Image = diceSides[0];
                    scoreDiceImage3.Image = diceSides[0];
                    diceImage1.Image = diceSides[0];
                    diceImage2.Image = diceSides[0];
                    diceImage3.Image = diceSides[0];
                    diceImage1.Visible = false;
                    diceImage2.Visible = false;
                    diceImage3.Visible = false;
                    break;
            }
            if (scoreLabel.Visible==false) scoreLabel.Visible = true;
            if (diceToThrow!=4) UpdateTurnTable(3);
            scoreLabel.Text = diceToThrow != 4 ? "Счет " + currentTurn.GetScoreMax() : "Счет 0";
            diceToThrow--;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "Кости игроков\n";
            str += thisParty.CurrentRound.ShowScore();
            MessageBox.Show(str);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Statistic(thisParty, "Промежуточная статистика", this).ShowDialog();
        }

        private void Field_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible) {
                DialogResult exitResult = MessageBox.Show(
                "Вы уверены, что хотите выйти из игры?",
                "Подтвердите выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
                if (exitResult == DialogResult.No) e.Cancel = true;
            }
            
        }
        private void UpdateTurnTable(int mode)
        {
            Turn currentTurn = thisParty.CurrentRound.TurnsList.FirstOrDefault(i => i.Player.id == thisParty.CurrentPlayer.id);
            //if ((thisParty.CurrentRound.Reroll)&&(mode!=3)) { 
            //    ClearTurnTable();
            //}
            bool updated = false;

            foreach (DataGridViewRow row in turnTable.Rows)
            {
                if (row.Cells["idT"].Value.ToString() == thisParty.CurrentPlayer.id.ToString())
                {
                    row.Cells["valuesT"].Value = currentTurn.RollValues[0]+", "+currentTurn.RollValues[1] + ", " + currentTurn.RollValues[2] + ", " + currentTurn.RollValues[3] + ", " + currentTurn.RollValues[4] + ", " + currentTurn.RollValues[5];
                    row.Cells["scoreT"].Value = currentTurn.GetScoreMax();
                    updated = true;
                    break; 
                }
            }
            if (!updated)
            {
                turnTable.Rows.Add(thisParty.CurrentPlayer.id.ToString(), thisParty.CurrentPlayer.Name, currentTurn.RollValues[0] + ", " + currentTurn.RollValues[1] + ", " + currentTurn.RollValues[2] + ", " + currentTurn.RollValues[3] + ", " + currentTurn.RollValues[4] + ", " + currentTurn.RollValues[5],currentTurn.GetScoreMax());
            }
        }
        //private void ClearTurnTable() {
        //    foreach (DataGridViewRow row in turnTable.Rows)
        //    {
        //        if (!thisParty.CurrentRound.WinnersList.Any(i => i.id == Convert.ToInt32(row.Cells["idT"].Value)))
        //        {
        //            turnTable.Rows.Remove(row);
        //        }
        //        else row.SetValues(row.Cells["idT"].Value.ToString(), row.Cells["nameT"].Value.ToString(), "0, 0, 0, 0, 0, 0", "0");
        //    }
        //}
        private void button2_Click(object sender, EventArgs e)
        {
            thisParty.CurrentRound.TurnsList[0].Test();
            thisParty.CurrentRound.TurnsList[1].Test();
            thisParty.CurrentRound.TurnsList[2].Test();
        }
    }
}
