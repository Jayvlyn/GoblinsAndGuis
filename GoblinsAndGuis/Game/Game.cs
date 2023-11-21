using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGuis
{
    public static class Game
    {
        public static bool fin = false;

        public static Player player = new Player();
        public static NonPlayer nonPlayer = new NonPlayer();

        public static void Init()
        {



            Application.Run(UI.formManager.characterCreation);
        }

        public static bool checkCombatVictory()
        {
            bool result = (nonPlayer.health <= 0);
            if (result)
            {
                player.GainExperience(Game.nonPlayer.expValue);
            }
            return result;
        }

    }
}
