using GoblinsAndGuis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGuis
{
    public class Player : Character
    {
        public int encounterCount;

        public Player(string name, int speed, int health, int power) : base(name, speed, health, power)
        {
            encounterCount = 0;
        }

        public Player()
        {
            encounterCount = 0;
        }
    }
}
