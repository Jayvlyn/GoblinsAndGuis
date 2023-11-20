
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGuis
{
    public class Character : GameObject
    {

        public Move[] moves = new Move[4];
        public List<string> dialogueOptions = new List<string>();

        // Attributes
        public string name { get; set; }
        public int speed { get; set; }
        public int health { get; set; }
        public int power { get; set; }

        public Character(string name = "Unnamed", int speed = 1, int health = 1, int power = 1)
        {
            this.name = name;
            this.speed = speed;
            this.health = health;
            this.power = power;
        }

    }
}
