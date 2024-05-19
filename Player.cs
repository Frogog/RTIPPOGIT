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
        public void SetPlayerInfo(int id)
        {
            Name = $"Игрок: {id + 1}";
            this.id = id;
        }
    }
}
