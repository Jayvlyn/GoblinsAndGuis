using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GoblinsAndGuis
{
    public static class Assets
    {
        public static Move[] moveList =
        {
            new Move("Wack", 2, 0, 0, 0, 2),
            new Move("Clobber", 10, 0, 2, 0, 10),
            new Move("Lick Wounds", 0, 5, 0, 0, 7),
            new Move("Parry", 5, 0, 0, 5, 20),
            new Move("Guard", 0, 0, 0, 10, 2)
        };

        public static NonPlayer[] characterList;

        public static void Init()
        {
            characterList = new NonPlayer[] 
            {
                new NonPlayer("Bob Robert", 5, 20, 1),
                new NonPlayer("Chob Crobert", 10, 100, 5) 
            };



            // Bob Robert
            NonPlayer bob = characterList[0];
            bob.dialogueOptions.Add("I'm Bob Robert, what are you doin' on Bob Roberts terf..?");
            bob.dialogueOptions.Add("Well lets see I run this town with my brother Chob, maybe you'll get to meet him sometime.");
            bob.dialogueOptions.Add("You have some nerve... prepare to die!");

            Move[] copy1 = GetMoveListDeepCopy();
            bob.moves[0] = copy1[4];
            bob.moves[1] = copy1[1];
            bob.moves[2] = copy1[1];
            bob.moves[3] = copy1[0];

            bob.expValue = 10;



            // Chob Crobert
            NonPlayer chob = characterList[1];
            chob.dialogueOptions.Add("I'm the one and only Chob Crobert, have you seen Bobert Robert anywhere?");
            chob.dialogueOptions.Add("He sure is an interesting guy, kinda has a god complex though heh.");
            chob.dialogueOptions.Add("W-what do you mean he's dead!? BOB NOOOOOOO! You'll pay for this...");
            chob.dialogueOptions.Add("HEY! Nobody can talk bad on my bro but me.");

            Move[] copy2 = GetMoveListDeepCopy();
            chob.moves[0] = copy2[1];
            chob.moves[1] = copy2[1];
            chob.moves[2] = copy2[1];
            chob.moves[3] = copy2[3];

            chob.expValue = 25;
        }

        public static Move[] GetMoveListDeepCopy()
        {
            
            // Create a new array and copy elements from the static array
            Move[] copyOfMoveList = new Move[moveList.Length];
            for (int i = 0; i < moveList.Length; i++)
            {
                copyOfMoveList[i] = new Move(
                    moveList[i].name,
                    moveList[i].damage,
                    moveList[i].healing,
                    moveList[i].stun,
                    moveList[i].block,
                    moveList[i].cooldownTime
                );
            }
            return copyOfMoveList;
        }

    }
}
