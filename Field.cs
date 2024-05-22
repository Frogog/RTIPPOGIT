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
            BetForm bet = new BetForm(thisParty);
            bet.ShowDialog();
            if (bet.bet[this.thisParty.PlayersList.Length - 1] == 0) {
                MessageBox.Show("Игрок отказался делать ставку\nБудет произведен выход из игры", "Выход из игры");
                Environment.Exit(0);
            } 
            thisParty.StartGame();
            name.Text = thisParty.CurrentPlayer.Name;
            bank.Text = "Банк: " + thisParty.Bank.ToString();
        }

        private void playB_Click(object sender, EventArgs e)
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
                    int answer2 = thisParty.changePlayer();
                    if (message[answer2] == "Бонусный раунд")
                    {
                        round.Text = message[answer2];
                    }
                    if (round.Text != "Бонусный раунд") round.Text = "Раунд: " + (Array.IndexOf(thisParty.RoundsList, thisParty.CurrentRound) + 1).ToString();
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
            if (this.Visible != false) UpdateTurnTable();
            scoreLabel.Text = diceToThrow != 4 ? "Счет " + currentTurn.GetScoreMax() : "Счет 0";
            diceToThrow--;
        }
        private void statB_Click(object sender, EventArgs e)
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
        private void UpdateTurnTable()
        {
            turnTable.Rows.Clear();
            foreach (Turn turn in thisParty.CurrentRound.TurnsList)
            {
                if (!thisParty.CurrentRound.Reroll)
                {
                    turnTable.Rows.Add(
                        turn.Player.id.ToString(),
                        turn.Player.Name,
                        diceSides[Math.Max(Math.Max(turn.RollValues[0], turn.RollValues[1]), turn.RollValues[2])],
                        diceSides[Math.Max(turn.RollValues[3], turn.RollValues[4])],
                        diceSides[turn.RollValues[5]],
                        turn.GetScoreMax());
                }
                else
                {
                    if (thisParty.CurrentRound.WinnersList.Contains(turn.Player))
                    {
                        turnTable.Rows.Add(
                            turn.Player.id.ToString(),
                            turn.Player.Name,
                            diceSides[Math.Max(Math.Max(turn.RollValues[0], turn.RollValues[1]), turn.RollValues[2])],
                            diceSides[Math.Max(turn.RollValues[3], turn.RollValues[4])],
                            diceSides[turn.RollValues[5]],
                            turn.GetScoreMax());
                    }
                }
            }
            turnTable.ClearSelection();

        }
    }
}
