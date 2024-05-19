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
            int[] values;
            values = Dice.playDices(diceAmount);
            placeValues(values, currentTurn, CurrentPlayer);
        }
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
                BetForm bet = new BetForm(player);
                bet.ShowDialog();
                if (bet.bet==0) Environment.Exit(0);
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
            PlayersList = new Player[amountPlayers];
            for (int i = 0; i < PlayersList.Length; ++i)
            {
                PlayersList[i] = new Player();
                PlayersList[i].SetPlayerInfo(i);
            }
        }
        public void SetRounds(int amountRounds)
        {
            RoundsList = new Round[amountRounds];
            for (int i = 0; i < amountRounds; ++i)
            {
                RoundsList[i] = new Round(PlayersList);
            }
        }
        public string ChangePlayer()
        {
            string answer = "";
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
        }
        private string ChangeRound()
        {
            CurrentRound.UpdateWinners();
            string roundWinMes = CurrentRound.CreateRoundWinMes();
            MessageBox.Show(roundWinMes);
            if (!CurrentRound.MoreWinners())
            {
                if (Array.IndexOf(RoundsList, CurrentRound) + 1 >= RoundsList.Length)
                {
                    CurrentRound.WinnersList.Clear();
                    int max = PlayersList.Max(i => i.Score);
                    foreach (Player player in PlayersList)
                    {
                        if (player.Score == max) CurrentRound.WinnersList.Add(player);
                    }
                    string gameWinMes = CurrentRound.CreateGameWinMes();
                    if (CurrentRound.WinnersList.Count > 1)
                    {
                        MessageBox.Show(gameWinMes);
                        return "Бонусный раунд";
                    }
                    else
                    {
                        gameWinMes += "\nБанк: " + Bank.ToString();
                        MessageBox.Show(gameWinMes);
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
        }
        
    }
}
