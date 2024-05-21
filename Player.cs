using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RTIPPOGIT
{
    public class Player
    {
        public int id { get; private set; }
        public string Name { get; private set; }
        public int Score { get;  set; } = 0;
        public int Chips { get; private set; } = 100;
        public override string ToString()
        {
            return $"Name: {Name}, Score: {Score}, Chips: {Chips}";
        }
        public void changeChips(int chipsCount) {
            if (chipsCount > 0) Chips += chipsCount;
            else Chips = Chips - (chipsCount*-1) < 0 ? Chips = 0:Chips-=(chipsCount)*-1;     
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
