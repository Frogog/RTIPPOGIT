using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIPPOGIT
{
    public class Turn
    {
        public Player Player { get; private set; } = null;
        public int[] RollValues { get; private set; } = new int[6] { 0, 0, 0, 0, 0, 0 };
        public Turn(Player player)
        {
            this.Player = player;
        }
        public int GetScoreMax()
        {
            return Math.Max(Math.Max(RollValues[0], RollValues[1]), RollValues[2]) + Math.Max(RollValues[3], RollValues[4]) + RollValues[5];
        }
        public void placeValues(int[] values)
        {
            switch (values.Length)
            {
                case 3:
                    for (int i = 0; i < values.Length; i++)
                    {
                        RollValues[i] = values[i];
                    }
                    break;
                case 2:
                    for (int i = 3; i < values.Length + 3; i++)
                    {
                        RollValues[i] = values[i - 3];
                    }
                    break;
                case 1:
                    RollValues[5] = values[0];
                    break;

            }
        }
        public void ClearTurnValues() {
            for (int i = 0; i < RollValues.Length; i++) RollValues[i] = 0;
        }
        public void Test() {
            for (int i = 0; i < RollValues.Length; i++) RollValues[i] = 6;
        }
    }
}
