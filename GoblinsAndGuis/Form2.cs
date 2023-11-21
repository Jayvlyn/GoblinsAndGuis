using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GoblinsAndGuis
{
    public partial class Form2 : Form
    {
        int branchesDeep;

        public Form2()
        {
            InitializeComponent();
        }


        public void Init()
        {
            Game.player.dialogueOptions.Clear();
            responseComboBox.Items.Clear();
            branchesDeep = 0;

            if (Game.nonPlayer == (NonPlayer)Assets.characterList[0])
            {
                npcPictureBox.Image = Properties.Resources.BobRobert;
            }
            else if (Game.nonPlayer == (NonPlayer)Assets.characterList[1])
            {
                npcPictureBox.Image = Properties.Resources.ChobCrobert;
            }

            // Sets npc text to their first dialogue option, aka their intro
            nonPlayerDialogue.Text = Game.nonPlayer.dialogueOptions[0];

            switch (Game.player.encounterCount)
            {
                case 0:
                    Game.player.dialogueOptions.Add("I'm just passing along, tell me about yourself!");
                    Game.player.dialogueOptions.Add("I'm here to make this my terf.");
                    break;
                case 1:
                    Game.player.dialogueOptions.Add("Yeah I just talked to him back there, seems like an interesting guy.");
                    Game.player.dialogueOptions.Add("He's dead, I killed him, and now it's your turn. This will be my town.");
                    break;
            }

            UI.populatePlayerResponses(responseComboBox);
            UI.updateLabels(playerLabel, nonPlayerLabel);
        }

        private void responseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Go into combat if npc turns hostile, no more talking
            if (Game.nonPlayer.playerDisposition == NonPlayer.Disposition.Hostile)
            {
                Game.player.encounterCount++;
                UI.formManager.ChangeForm(FormManager.FormState.Combat);
                branchesDeep = 0;
            }

            Game.player.dialogueOptions.Clear();
            switch (branchesDeep)
            {
                case 0: // 0 BRANCHES DEEP
                    if (responseComboBox.SelectedIndex == 0)
                    {
                        switch (Game.player.encounterCount)
                        {
                            case 0: // ENCOUNTER 0 BRANCH 0 SELECTED INDEX 0
                                // NPC response
                                Game.nonPlayer.playerDisposition = NonPlayer.Disposition.Neutral;
                                nonPlayerDialogue.Text = Game.nonPlayer.dialogueOptions[1];

                                // Player response options
                                responseComboBox.Items.Clear();
                                Game.player.dialogueOptions.Add("Is that him over there? I'll go say hi");
                                Game.player.dialogueOptions.Add("Well it was nice to meet you, have a good day! :)");
                                break;
                            case 1: // ENCOUNTER 1 BRANCH 0 SELECTETD INDEX 0
                                // NPC response
                                Game.nonPlayer.playerDisposition = NonPlayer.Disposition.Friendly;
                                nonPlayerDialogue.Text = Game.nonPlayer.dialogueOptions[1];

                                // Player response options
                                responseComboBox.Items.Clear();
                                Game.player.dialogueOptions.Add("I thought he was kinda weird");
                                Game.player.dialogueOptions.Add("Yeah, he has a little bit of an ego...");
                                break;

                        }
                        UI.populatePlayerResponses(responseComboBox);
                        branchesDeep++;
                    }
                    else if (responseComboBox.SelectedIndex == 1)
                    {
                        switch (Game.player.encounterCount)
                        {
                            case 0: // ENCOUNTER 0 BRANCH 0 SELECTED INDEX 1
                                // NPC response
                                Game.nonPlayer.playerDisposition = NonPlayer.Disposition.Hostile;
                                nonPlayerDialogue.Text = Game.nonPlayer.dialogueOptions[2];

                                // Player response options
                                responseComboBox.Items.Clear();
                                Game.player.dialogueOptions.Add("Try me >:/");
                                Game.player.dialogueOptions.Add("Uh oh (I wasn't being serious)");
                                UI.populatePlayerResponses(responseComboBox);
                                branchesDeep++;
                                break;

                            case 1: // ENCOUNTER 1 BRANCH 0 SELECTED INDEX 1
                                // NPC response
                                Game.nonPlayer.playerDisposition = NonPlayer.Disposition.Hostile;
                                nonPlayerDialogue.Text = Game.nonPlayer.dialogueOptions[2];

                                // Player response options
                                responseComboBox.Items.Clear();
                                Game.player.dialogueOptions.Add("You're gonna lay dead with your brother.");
                                Game.player.dialogueOptions.Add("Here we go again.");
                                UI.populatePlayerResponses(responseComboBox);
                                branchesDeep++;
                                break;
                        }

                    }
                    break;

                case 1: // ONE BRANCH DEEP
                    switch (Game.player.encounterCount)
                    {
                        case 0: // ENCOUNTER 0 BRANCH 1 INDEX N/A
                            if (Game.nonPlayer.playerDisposition == NonPlayer.Disposition.Friendly || Game.nonPlayer.playerDisposition == NonPlayer.Disposition.Neutral)
                            {
                                Game.player.encounterCount++;
                                UI.formManager.ChangeForm(FormManager.FormState.Adventure);
                                branchesDeep = 0;
                            }

                            break;

                        case 1: // ENCOUNTER 1 BRANCH 1
                            Game.nonPlayer.playerDisposition = NonPlayer.Disposition.Hostile;
                            nonPlayerDialogue.Text = Game.nonPlayer.dialogueOptions[3];

                            // Player response options
                            responseComboBox.Items.Clear();
                            Game.player.dialogueOptions.Add("Woah I thought we were chill!");
                            Game.player.dialogueOptions.Add("Please don't.");
                            Game.player.dialogueOptions.Add("I was just agreeing with you!!");
                            Game.player.dialogueOptions.Add("SOMEONE HELP THIS GUY IS SCARING ME");
                            UI.populatePlayerResponses(responseComboBox);
                            branchesDeep++;
                            break;
                    }
                    break;
            }
        }

        // Trash

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void npcPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void playerPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
