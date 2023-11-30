using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameLogic
{
    public static class Assets
    {
        public static Move[] moveList =
        {
            new Move("Wack", 2, 0, 0, 0, 2),
            new Move("Clobber", 5, 0, 2, 0, 10),
            new Move("Patch up", 0, 5, 0, 0, 7),
            new Move("Parry", 3, 0, 0, 3, 20),
            new Move("Guard", 0, 0, 0, 5, 20),
            new Move("Discombobulate", 10, 0, 10, 0, 20),
            new Move("Blood Transfusion", 20, 20, 0, 0, 30)
        };

        public static NonPlayer[] characterList;

        public static void Init()
        {
            characterList = new NonPlayer[]
            {
                new NonPlayer("Bob Roberts", 6, 20, 1),
                new NonPlayer("Chob Roberts", 10, 60, 3),
            };

            // Bob Roberts
            NonPlayer bob = characterList[0];
            bob.dialogueOptions.Add("I'm Bob Roberts, what are you doin' on Bob Roberts' terf..?");
            bob.dialogueOptions.Add("Well lets see I run this town with my brother Chob, maybe you'll get to meet him sometime.");
            bob.dialogueOptions.Add("You have some nerve... prepare to die!");

            bob.moves[0] = GetMoveCopy(moveList[0]);
            bob.moves[1] = GetMoveCopy(moveList[3]);
            bob.moves[2] = GetMoveCopy(moveList[0]);
            bob.moves[3] = GetMoveCopy(moveList[4]);

            bob.expValue = 10;

            // Chob Roberts
            NonPlayer chob = characterList[1];
            chob.dialogueOptions.Add("I'm the one and only Chob Roberts, have you seen Robert S. Roberts anywhere?");
            chob.dialogueOptions.Add("He sure is an interesting guy, kinda has a god complex though heh.");
            chob.dialogueOptions.Add("W-what do you mean he's dead!? BOB NOOOOOOO! You'll pay for this...");
            chob.dialogueOptions.Add("HEY! Nobody can talk bad on my bro but me.");

            chob.moves[0] = GetMoveCopy(moveList[1]);
            chob.moves[1] = GetMoveCopy(moveList[2]);
            chob.moves[2] = GetMoveCopy(moveList[4]);
            chob.moves[3] = GetMoveCopy(moveList[5]);

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

        public static Move GetMoveCopy(Move move)
        {
            Move moveCopy = new Move(
                    move.name,
                    move.damage,
                    move.healing,
                    move.stun,
                    move.block,
                    move.cooldownTime
                );
            return moveCopy;
        }

    }
}
