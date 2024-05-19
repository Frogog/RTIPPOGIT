using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIPPOGIT
{
    public class Player
    {
        public int id { get; private set; }
        public string Name { get; private set; }
        public int Score { get; private set; } = 0;
        public int Chips { get; set; } = 100;
        public override string ToString()
        {
            return $"Name: {Name}, Score: {Score}, Chips: {Chips}";
        }
        public void UpScore()
        {
            Score++;
        }
        public static Player[] InitializeArray(int length)
        {
            Player[] array = new Player[length];
            for (int i = 0; i < length; ++i)
            {
                array[i] = new Player();
                array[i].Name = $"Игрок: {i + 1}";
                array[i].id = i;
                //MessageBox.Show(array[i].ToString());
            }
            return array;
        }
    }
}
