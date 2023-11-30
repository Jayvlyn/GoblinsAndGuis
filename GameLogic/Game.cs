using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public static class Game
    {
        public static bool fin = false;

        public static Player player = new Player();
        public static NonPlayer nonPlayer = new NonPlayer();
        public static bool combatActive = false;

        public static void Init()
        {
            // Move out of Game logic
            //Application.Run(UI.formManager.characterCreation);
        }

        public static bool checkCombatVictory()
        {
            bool result = (nonPlayer.health <= 0);
            if (result)
            {
                player.GainExperience(nonPlayer.expValue);
                for (int i = 0; i < 4; i++)
                {
                    player.moves[i].ReadyMove();
                }
            }
            return result;
        }

        public static bool checkDeath()
        {
            bool result = player.health <= 0;
            if(result) {
                player.dead = true;
                // move out of game logic
                //UI.formManager.ChangeForm(FormManager.FormState.Victory); // end screen either way, not actual victory
            }
            return result;
        }

    }
}
