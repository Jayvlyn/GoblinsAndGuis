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
            Combat
        }

        private FormState currentForm = FormState.CharacterCreation;
        public Form1 characterCreation;
        public Form2 adventure;
        private Form combat;

        public FormManager()
        {
            characterCreation = new Form1(20);
            adventure = new Form2();
            //combat = new Form3(player);

        }

        public void ChangeForm(FormState form)
        {
            currentForm = form;
            if (form == FormState.CharacterCreation)
            {
                adventure.Hide();
                combat.Hide();

                characterCreation.Show();
            }
            else if (form == FormState.Adventure)
            {
                characterCreation.Hide();

                Assets assets = new Assets();
                Game.nonPlayer = assets.characterList[Game.player.encounterCount];
                adventure.Init();
                adventure.Show();
            }
            else if (form == FormState.Combat)
            {
                adventure.Hide();

                combat.Show();
            }
        }
    }

}
