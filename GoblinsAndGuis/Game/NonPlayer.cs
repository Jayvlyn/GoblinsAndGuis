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
        
        public const float moveTime = 40;
        public float moveTimer = moveTime;
        bool ready = false;


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

        public override void Update(double dt)
        {
            base.Update(dt); // update for 'Character'

            if (ready)
            {
                ready = false;
                int moveSelection = random.Next(0, Game.nonPlayer.moves.Length);
                UseMove(Game.player, moveSelection);
                Game.checkDeath(); // checks for player death
                moveTimer = moveTime;
            }
        }

        public override void UseMove(Character target, int moveNum)
        {
            if (moves[moveNum].ready)
            {
                moves[moveNum].cooldownTimer = moves[moveNum].cooldownTime;
            }
            base.UseMove(target, moveNum);
        }

        public void MoveTimer(double dt)
        {
            if (!stunned)
            {
                if (moveTimer > 0)
                {
                    // Move timer does not decrease by seconds, it is a base 'moveTime' seconds between each move, which is sped up by the characters speed
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
}
