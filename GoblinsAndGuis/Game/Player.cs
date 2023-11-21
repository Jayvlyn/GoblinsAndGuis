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

        public Player(string name, int speed, int health, int power) : base(name, speed, health, power)
        {
            encounterCount = 0;
            moves[0] = Assets.moveList[0];
            moves[1] = Assets.moveList[1];
            moves[2] = Assets.moveList[2];
            moves[3] = Assets.moveList[3];
        }

        public Player()
        {
            encounterCount = 0;
            moves[0] = Assets.moveList[0];
            moves[1] = Assets.moveList[1];
            moves[2] = Assets.moveList[2];
            moves[3] = Assets.moveList[3];
        }
    }
}
