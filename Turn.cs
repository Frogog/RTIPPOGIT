using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIPPOGIT
{
    public class Turn
    {
        public Player Player = null;
        public int[] RollValues { get; private set; } = new int[6] { 0, 0, 0, 0, 0, 0 };
        public Turn(Player player)
        {
            this.Player = player;
        }
        public int GetScore()
        {
            return Math.Max(Math.Max(RollValues[0], RollValues[1]), RollValues[2]) + Math.Max(RollValues[3], RollValues[4]) + RollValues[5];
        }
    }
}
