using GoblinsAndGuis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGuis
{
    public class Move
    {
        string name; // Name of move

        // Generic effects a move can have
        int damage = 0; // How much damage the opponent takes
        int healing = 0; // How much the move user heals
        int stun = 0; // How many seconds the move stuns the opponent
        int block = 0; // How much damage the move blocks on opponent's next attack

        float cooldownTime = 0;
        float cooldownTimer = 0;


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
            this.cooldownTimer = cooldownTime;
        }

        public void Use(Character opponent)
        {

        }
    }
}
