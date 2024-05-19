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
        public Party thisParty;
        private int[] rolls = new int[6];
        private int diceToThrow = 3;
        private Random rnd = new Random();
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
        private void Field_Load(object sender, EventArgs e)
        {
            thisParty = new Party();
            InputPlayers inputP = new InputPlayers(thisParty);
            inputP.ShowDialog();
            InputRounds inputR = new InputRounds(thisParty);
            inputR.ShowDialog();
            //foreach (Player player in thisGame.players)
            //{
            //    BetForm bet = new BetForm(player, thisGame);                //Ставки
            //    bet.ShowDialog();
            //}

            thisParty.startBet();
            thisParty.StartGame();
            /*thisGame.currentPlayer = thisGame.playersList[0];
            thisGame.currentRound = thisGame.roundsList[0];*/
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
                    limitedDice1.Text = currentTurn.RollValues[0].ToString();
                    limitedDice2.Text = currentTurn.RollValues[1].ToString();
                    limitedDice3.Text = currentTurn.RollValues[2].ToString();
                    diceImage1.Image = diceSides[currentTurn.RollValues[0]];
                    diceImage2.Image = diceSides[currentTurn.RollValues[1]];
                    diceImage3.Image = diceSides[currentTurn.RollValues[2]];
                    int max = Math.Max(Math.Max(currentTurn.RollValues[0], currentTurn.RollValues[1]), currentTurn.RollValues[2]);
                    dice1.Text = max.ToString();
                    break;
                case 2:
                    limitedDice1.Text = currentTurn.RollValues[3].ToString();
                    limitedDice2.Text = currentTurn.RollValues[4].ToString();
                    diceImage1.Image = diceSides[currentTurn.RollValues[3]];
                    diceImage2.Image = diceSides[currentTurn.RollValues[4]];
                    limitedDice3.Visible = false;
                    diceImage3.Visible = false;
                    max = Math.Max(currentTurn.RollValues[3], currentTurn.RollValues[4]);
                    dice2.Text = max.ToString();
                    break;
                case 1:
                    limitedDice1.Text = currentTurn.RollValues[5].ToString();
                    diceImage1.Image = diceSides[currentTurn.RollValues[5]];
                    limitedDice2.Visible = false;
                    diceImage2.Visible = false;
                    dice3.Text = currentTurn.RollValues[5].ToString();
                    button1.Text = "Передать ход";
                    break;
                case 0:
                    string answer = thisParty.ChangePlayer();
                    if (answer == "Бонусный раунд") round.Text = answer;
                    else if (round.Text != "Бонусный раунд") round.Text = "Раунд: " + (Array.IndexOf(thisParty.RoundsList, thisParty.CurrentRound) + 1).ToString();
                    if (answer == "Конец")
                    {
                        this.Hide();
                        Statistic stat = new Statistic(thisParty);
                        //stat.Closed += (s, args) => this.Close();
                        stat.ShowDialog();
                    }
                    //thisParty.ChangePlayer();
                    name.Text = thisParty.CurrentPlayer.Name;
                    //round.Text = "Раунд: "+(Array.IndexOf(thisParty.RoundsList, thisParty.CurrentRound)+1).ToString();
                    button1.Text = "Разыграть";
                    diceToThrow = 4;
                    dice1.Text = "0";
                    dice2.Text = "0";
                    dice3.Text = "0";
                    limitedDice1.Text = "0";
                    limitedDice2.Text = "0";
                    limitedDice3.Text = "0";
                    diceImage1.Image = diceSides[0];
                    diceImage2.Image = diceSides[0];
                    diceImage3.Image = diceSides[0];
                    limitedDice2.Visible = true;
                    limitedDice3.Visible = true;
                    diceImage2.Visible = true;
                    diceImage3.Visible = true;
                    break;
            }
            diceToThrow--;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "Кости игроков ";
            foreach (Turn turn in thisParty.CurrentRound.TurnsList)
            {
                str += "\n" + turn.Player.Name + " ";
                foreach (int value in turn.RollValues)
                {
                    str += value + " ";
                }
            }
            MessageBox.Show(str);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Statistic stat = new Statistic(thisParty);
            stat.ShowDialog();
        }
    }
}
