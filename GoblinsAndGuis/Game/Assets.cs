using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGuis
{
    public class Assets
    {
        public Move[] moveList =
        {
            new Move("Wack", 2, 0, 0, 0, 1),
            new Move("Clobber", 10, 0, 2, 0, 10),
            new Move("Lick Wounds", 0, 5, 0, 0, 7),
            new Move("Parry", 5, 0, 0, 5, 20),
            new Move("Guard", 0, 0, 0, 10, 2)
        };

        public NonPlayer[] characterList =
        {
            new NonPlayer("Bob Robert", 5, 20, 3),
            new NonPlayer("Chob Crobert", 4, 19, 2)
        };

        public Assets()
        {
            // Bob Robert
            characterList[0].dialogueOptions.Add("I'm Bob Robert, what are you doin' on Bob Roberts terf..?");
            characterList[0].dialogueOptions.Add("Well lets see I run this town with my brother Chob, maybe you'll get to meet him sometime.");
            characterList[0].dialogueOptions.Add("You have some nerve... prepare to die!");

            // Chob Crobert
            characterList[1].dialogueOptions.Add("I'm the one and only Chob Crobert, have you seen Bobert Robert anywhere?");
            characterList[1].dialogueOptions.Add("W-what do you mean he's dead!? BOB NOOOOOOO! You'll pay for this...");
        }


    }
}
