using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIPPOGIT
{
    public  class Round
    {
        public List<Player> WinnersList { get; private set; } = new List<Player>();
        public bool Reroll { get; set; }
        public Turn[] TurnsList { get; private set; }

        public Round(Player[] playersList)
        {
            this.TurnsList = new Turn[playersList.Length];
            for (int i = 0; i < playersList.Length; ++i)
            {
                TurnsList[i] = new Turn(playersList[i]);
            }
            this.Reroll = false;
            WinnersList.Select(i => i.Name == "Имя");
        }
        public bool MoreWinners()
        {
            Reroll = WinnersList.Count > 1;
            return (WinnersList.Count > 1);
        }
        public void UpdateWinners()
        {
            if (!Reroll)
            {
                int max = TurnsList.Max(i => i.GetScore());
                foreach (Turn turn in TurnsList) if (turn.GetScore() == max) WinnersList.Add(turn.Player);
            }
            else
            {
                int max = TurnsList.Where(i => WinnersList.Contains(i.Player)).Max(i => i.GetScore());
                foreach (Turn turn in TurnsList) if (turn.GetScore() != max) WinnersList.Remove(turn.Player);
            }
            Reroll = WinnersList.Count > 1;
            if (WinnersList.Count == 1) WinnersList[0].UpScore();
        }
        /*public static Round[] InitializeArray(int length, Player[] playersList)
        {
            Round[] array = new Round[length];
            for (int i = 0; i < length; ++i)
            {
                array[i] = new Round(playersList);
            }
            return array;
        }
        public string ShowTurns() {
            string turnStr = "";
            foreach (Turn turn in TurnsList) { 
                turnStr+= "" + turn.ToString();
            }
            return turnStr;
        }*/
    }
}
