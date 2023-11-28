using GoblinsAndGuis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGuis
{
    public class Player : Character
    {
        public int encounterCount;
        public bool dead = false;

        public Player(string name, int speed, int health, int power) : base(name, speed, health, power)
        {
            encounterCount = 0;
            fillMoves();
            
        }

        public Player()
        {
            encounterCount = 0;
            fillMoves();
        }

        public override void Update(double dt)
        {
            base.Update(dt); // update for 'Character'
        }

        public override void UseMove(Character target, int moveNum)
        {
            if (moves[moveNum].ready)
            {
                float cooldownValue = moves[moveNum].cooldownTime - speed; // speed lowers cooldowns
                if (cooldownValue < 1) moves[moveNum].cooldownTimer = 1;
                else moves[moveNum].cooldownTimer = cooldownValue;
            }

            base.UseMove(target, moveNum);
        }

        public void fillMoves()
        {
            moves[0] = Assets.GetMoveCopy(Assets.moveList[0]);
            moves[1] = Assets.GetMoveCopy(Assets.moveList[2]);
            moves[2] = Assets.GetMoveCopy(Assets.moveList[4]);
            moves[3] = Assets.GetMoveCopy(Assets.moveList[5]);
        }
    }
}
