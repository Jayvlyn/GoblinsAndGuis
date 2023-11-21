using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGuis
{
    public static class UI
    {
        public static FormManager formManager = new FormManager();

        public static void updateLabels(Label playerLabel, Label nonPlayerLabel)
        {
            playerLabel.Text = Game.player.name + "\nSpeed: " + Game.player.speed + "\nHealth: " + Game.player.health + "\nPower: " + Game.player.power;
            nonPlayerLabel.Text = Game.nonPlayer.name + "\nSpeed: " + Game.nonPlayer.speed + "\nHealth: " + Game.nonPlayer.health + "\nPower: " + Game.nonPlayer.power;
        }

        public static void populatePlayerResponses(ComboBox playerComboBox) 
        { 
            for(int i = 0; i < Game.player.dialogueOptions.Count; i++)
            {
                playerComboBox.Items.Add(Game.player.dialogueOptions[i]);
            }        
        }

        public static void onCombatVictory()
        {
            formManager.ChangeForm(FormManager.FormState.Adventure);
        }
    }
}
