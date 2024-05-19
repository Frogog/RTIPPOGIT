using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;

namespace RTIPPOGIT
{
    public  class Round
    {
        public List<Player> WinnersList { get; private set; } = new List<Player>();
        public bool Reroll { get; private set; }
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
                int max = TurnsList.Max(i => i.GetScoreMax());
                foreach (Turn turn in TurnsList) if (turn.GetScoreMax() == max) WinnersList.Add(turn.Player);
            }
            else
            {
                int max = TurnsList.Where(i => WinnersList.Contains(i.Player)).Max(i => i.GetScoreMax());
                foreach (Turn turn in TurnsList) if (turn.GetScoreMax() != max) WinnersList.Remove(turn.Player);
            }
            Reroll = WinnersList.Count > 1;
            if (WinnersList.Count == 1) WinnersList[0].UpScore();
        }
        public string CreateRoundWinMes() {
            string roundWinMes = "";
            if (WinnersList.Count > 1)
            {
                roundWinMes = "Победители Раунда: \n";
                foreach (var player in WinnersList) roundWinMes += player.Name + " ";
            }
            else roundWinMes = "Победитель Раунда: \n" + WinnersList[0].Name;
            return roundWinMes;
        }
        public string CreateGameWinMes()
        {
            string gameWinMes = "";
            if (WinnersList.Count > 1)
            {
                gameWinMes = "Победители игры: ";
                foreach (Player player in WinnersList) gameWinMes += "\n" + player.Name;
                gameWinMes += "\nПоследний раунд будет переигран для определения окончательного победителя";
                Reroll = true;
            }
            else gameWinMes = "Победитель игры: " + WinnersList[0].Name;
            return gameWinMes;
        }
        public string ShowScore()
        {
            string playersScore = "";
            foreach (Turn turn in TurnsList)
            {
                playersScore += turn.Player.Name + " Кости: " + turn.Player.Score + " Счет:  " + turn.GetScoreMax() + "\n";
            }
            return playersScore;
        }
    }
}
