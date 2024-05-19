using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIPPOGIT
{
    public class Dice
    {
        private int[] EdgeValues = new int[6] { 1, 2, 3, 4, 5, 6 };
        //private Random rnd = new Random();
        public int[] playDices(int diceAmount)
        {
            int[] rollValues = new int[diceAmount];
            Random rnd = new Random();
            for (int i = 0; i < diceAmount; i++)
            {
                rollValues[i] = Roll(rnd);
            }
            return rollValues;
        }
        private int Roll(Random rnd)
        {
            lock (rnd)
            {
                return EdgeValues[rnd.Next(0, EdgeValues.Length)];
            }
        }
    }
}
