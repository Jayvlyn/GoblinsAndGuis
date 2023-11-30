using GameLogic;
using GoblinsAndGuis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGuis
{
    public class FormManager : ApplicationContext
    {
        public enum FormState
        {
            CharacterCreation,
            Adventure,
            Combat,
            Victory
        }

        private FormState currentForm = FormState.CharacterCreation;
        public Form1 characterCreation;
        public Form2 adventure;
        public Form3 combat;
        public Form4 victory;

        public FormManager()
        {
            characterCreation = new Form1(20);
            Init();
        }

        public void Init()
        {
            adventure = new Form2();
            combat = new Form3();
            victory = new Form4();
            Game.player = new Player();
        }

        public void ChangeForm(FormState form)
        {
            currentForm = form;
            if (form == FormState.CharacterCreation)
            {
                victory.Hide();
                adventure.Hide();
                combat.Hide();
                Game.combatActive = false; 

                characterCreation.Init();
                characterCreation.Show();
            }
            else if (form == FormState.Adventure)
            {
                adventure.Hide();
                combat.Hide();
                characterCreation.Hide();
                Game.combatActive = false;

                if (Assets.characterList.Length > Game.player.encounterCount) 
                {
                    Game.nonPlayer = Assets.characterList[Game.player.encounterCount];
                    adventure.Init();
                    adventure.Show();
                }
                else
                {
                    ChangeForm(FormState.Victory);
                }
            }
            else if (form == FormState.Combat)
            {
                adventure.Hide();

                combat.Init();
                combat.Show();
            }
            else if (form == FormState.Victory)
            {
                adventure.Hide();
                combat.Hide();
                Game.combatActive = false;

                victory.Init();
                victory.Show();
            }
        }
    }

}
