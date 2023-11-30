
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Move
    {
        public string name; // Name of move

        // Generic effects a move can have
        public int damage = 0; // How much damage the opponent takes
        public int healing = 0; // How much the move user heals
        public int stun = 0; // How many seconds the move stuns the opponent
        public int block = 0; // How many seconds you become invulnerable to damage

        public float cooldownTime = 0;
        public float cooldownTimer = 0;
        public bool ready = true;


        public Move(string name)
        {
            this.name = name;
        }

        public Move(string name, int damage, int healing, int stun, int block, float cooldownTime)
        {
            this.name = name;
            this.damage = damage;
            this.healing = healing;
            this.stun = stun;
            this.block = block;
            this.cooldownTime = cooldownTime;
        }

        public void CountCooldown(double dt)
        {
            if (cooldownTimer > 0)
            {
                cooldownTimer -= (float)dt;
                ready = false;
            }
            else
            {
                cooldownTimer = 0;
                ready = true;
            }
        }

        public void ReadyMove()
        {
            cooldownTimer = 0;
            ready = true;
        }

    }
}
