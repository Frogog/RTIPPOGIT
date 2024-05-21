using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            currentTurn.placeValues(values);
        }
        public void startBet(int[] bet)
        {
            for (int i = 0; i < PlayersList.Length; i++) {
                CurrentPlayer = PlayersList[i];
                setChips(bet[i]);
            }
        }
        private void setChips(int chipsCount)
        {
            Bank += chipsCount;
            CurrentPlayer.changeChips((chipsCount)*-1);
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
        public int ChangePlayer()
        {
            int answerRound = 3;
            if (Array.IndexOf(PlayersList, CurrentPlayer) == PlayersList.Length - 1) {
                answerRound = ChangeRound();
            }
            int answerPlayer = nextPlayer();
            if ((answerPlayer < 3)) return answerPlayer;
            return answerRound;
        }
        private int nextPlayer()
        {
            if (Array.IndexOf(PlayersList, CurrentPlayer) + 1 >= PlayersList.Length)
            {
                CurrentPlayer = PlayersList[0];
            }
            else CurrentPlayer = PlayersList[Array.IndexOf(PlayersList, CurrentPlayer) + 1];
            if ((CurrentRound.Reroll == true) && (!CurrentRound.WinnersList.Contains(CurrentPlayer)))
            {
                int answer;
                if (Array.IndexOf(PlayersList, CurrentPlayer) == PlayersList.Length - 1)
                {
                    answer = ChangeRound();
                    nextPlayer();
                    return answer;
                }
                else answer = nextPlayer();
                return answer;
            }
            return 3;
        }
        private int ChangeRound()
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
                        CurrentRound.clearRoundValues();
                        MessageBox.Show(gameWinMes);
                        return 1;
                    }
                    else
                    {
                        gameWinMes += "\nБанк: " + Bank.ToString();
                        MessageBox.Show(gameWinMes);
                        CurrentRound.WinnersList[0].changeChips(Bank);
                        return 0;
                    }
                }
                else
                {
                    CurrentRound = RoundsList[Array.IndexOf(RoundsList, CurrentRound) + 1];
                }
            }
            return 2;
        }
    }
}
