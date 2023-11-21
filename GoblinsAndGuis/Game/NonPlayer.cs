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
        private Random random = new Random();
        
        public int expValue = 100;

        public float moveTimer;
        bool ready = false;


        public enum Disposition
        {
            Friendly, Neutral, Hostile
        }

        public Disposition playerDisposition = Disposition.Neutral;

        public NonPlayer(string name, int speed, int health, int power) : base(name, speed, health, power)
        {
            moveTimer = 10;
        }

        public NonPlayer()
        {
            moveTimer = 10;
        }

        public void Update()
        {
            if (ready)
            {
                int moveSelection = random.Next(0, Game.nonPlayer.moves.Length);
                UseMove(Game.player, moveSelection);
                ready = false;
            }
        }

        public void MoveTimer(double dt)
        {
            if (moveTimer > 0)
            {
                moveTimer -= (float)dt * speed;
                ready = false;
            }
            else
            {
                moveTimer = 0;
                ready = true;
            }
        }
    }
}
