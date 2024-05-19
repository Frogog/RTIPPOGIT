using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIPPOGIT
{
    public class Party
    {
        public Player CurrentPlayer { get; private set; }
        public Round[] RoundsList { get; private set; }
        public Round CurrentRound { get; private set; }
        public int Bank { get; private set; }
        public Player[] PlayersList { get; private set; }
        private Dice Dice = new Dice();
        public void StartGame()
        {
            CurrentPlayer = PlayersList[0];
            CurrentRound = RoundsList[0];
        }
        public void throwDice(int diceAmount)
        {
            Turn currentTurn = CurrentRound.TurnsList.FirstOrDefault(i => i.Player.id == CurrentPlayer.id);
            /*foreach (Turn turn in CurrentRound.TurnsList)
            {
                if (turn.Player.id == CurrentPlayer.id)
                {
                    currentTurn = turn;
                    break;
                }
            }*/
            //Turn currentTurn = changeCurrentTurn();
            int[] values;
            values = Dice.playDices(diceAmount);
            placeValues(values, currentTurn, CurrentPlayer);
        }
        /*private Turn changeCurrentTurn() { 
            return this.CurrentRound.TurnsList.FirstOrDefault(i => i.Player.id == CurrentPlayer.id);
        }*/
        private void placeValues(int[] values, Turn turn, Player player)
        {
            switch (values.Length)
            {
                case 3:
                    for (int i = 0; i < values.Length; i++)
                    {
                        turn.RollValues[i] = values[i];
                    }
                    break;
                case 2:
                    for (int i = 3; i < values.Length + 3; i++)
                    {
                        turn.RollValues[i] = values[i - 3];
                    }
                    break;
                case 1:
                    turn.RollValues[5] = values[0];
                    break;

            }
        }
        public void startBet()
        {
            foreach (Player player in PlayersList)
            {
                CurrentPlayer = player;
                BetForm bet = new BetForm(player, this);
                bet.ShowDialog();
                setChips(bet.bet);
            }
        }
        private void setChips(int chipsCount)
        {
            Bank += chipsCount;
            CurrentPlayer.Chips -= chipsCount;
        }
        public void SetPlayers(int amountPlayers)
        {
            PlayersList = Player.InitializeArray(amountPlayers);
            /*for (int i = 0; i < amountPlayers; ++i)
            {
                PlayersList[i] = new Player();
                PlayersList[i].Name += $" {i + 1}";
                PlayersList[i].id = i;
            }*/
        }
        public void SetRounds(int amountRounds)
        {
            RoundsList = new Round[amountRounds];
            for (int i = 0; i < amountRounds; ++i)
            {
                RoundsList[i] = new Round(PlayersList);
            }
            //roundsList = Round.InitializeArray(Convert.ToInt16(amountRounds), playersList);
        }
        public string ChangePlayer()
        {
            string answer = "";
            /*if ((Array.IndexOf(PlayersList, CurrentPlayer) == PlayersList.Length - 1) && (Array.IndexOf(RoundsList, CurrentRound) == RoundsList.Length - 1)) { 
                answer=endGame();
            }*/
            if (Array.IndexOf(PlayersList, CurrentPlayer) == PlayersList.Length - 1) answer = ChangeRound();
            nextPlayer();
            return answer;
        }
        private void nextPlayer()
        {
            if (Array.IndexOf(PlayersList, CurrentPlayer) + 1 >= PlayersList.Length)
            {
                CurrentPlayer = PlayersList[0];
            }
            else CurrentPlayer = PlayersList[Array.IndexOf(PlayersList, CurrentPlayer) + 1];
            if ((CurrentRound.Reroll == true) && (!CurrentRound.WinnersList.Contains(CurrentPlayer)))
            {
                ChangePlayer();
            }
            //MessageBox.Show(currentPlayer.ToString());
        }
        private string ChangeRound()
        {
            CurrentRound.UpdateWinners();
            string str;
            if (CurrentRound.WinnersList.Count > 1)
            {
                str = "Победители Раунда: \n";
                foreach (var player in CurrentRound.WinnersList) str += player.Name + " ";
            }
            else
            {
                str = "Победитель Раунда: \n" + CurrentRound.WinnersList[0].Name;
            }
            /*string str = "Победители Раунда: \n";
            foreach(var player in CurrentRound.WinnersList) str+= player.Name+" ";*/
            MessageBox.Show(str);
            if (!CurrentRound.MoreWinners())
            {
                if (Array.IndexOf(RoundsList, CurrentRound) + 1 >= RoundsList.Length)
                {
                    //CurrentRound = RoundsList[0];
                    CurrentRound.WinnersList.Clear();
                    int max = PlayersList.Max(i => i.Score);
                    foreach (Player player in PlayersList)
                    {
                        if (player.Score == max) CurrentRound.WinnersList.Add(player);
                    }
                    if (CurrentRound.WinnersList.Count > 1)
                    {
                        string str2 = "Победители игры: ";
                        foreach (Player player in CurrentRound.WinnersList) str2 += "\n" + player.Name;
                        str2 += "\nПоследний раунд будет переигран для определения окончательного победителя";
                        MessageBox.Show(str2);
                        CurrentRound.Reroll = true;
                        return "Бонусный раунд";
                    }
                    else
                    {
                        string str2 = "Победитель игры: " + CurrentRound.WinnersList[0].Name + "\n" + Bank.ToString();
                        MessageBox.Show(str2);
                        CurrentRound.WinnersList[0].Chips += Bank;
                        return "Конец";
                    }
                }
                else
                {
                    CurrentRound = RoundsList[Array.IndexOf(RoundsList, CurrentRound) + 1];
                }
            }
            return "";
            //return "Раунд: " + (Array.IndexOf(roundsList, currentRound) + 1);
        }
        public string ShowScore()
        {
            string str = "";
            foreach (Player player in PlayersList)
            {
                str += player.Name + " " + player.Score + "\n";
            }
            return str;
        }
    }
}
