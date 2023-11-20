using GoblinsAndGuis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGuis
{
    public class NonPlayer : Character
    {
        public enum Disposition
        {
            Friendly, Neutral, Hostile
        }

        public Disposition playerDisposition = Disposition.Neutral;

        public NonPlayer(string name, int speed, int health, int power) : base(name, speed, health, power)
        {
        }

        public NonPlayer()
        {

        }
    }
}
