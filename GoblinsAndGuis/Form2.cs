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

        public void updateLabels()
        {
            playerLabel.Text = Game.player.name + "\nSpeed: " + Game.player.speed + "\nHealth: " + Game.player.health + "\nPower: " + Game.player.power;
            nonPlayerLabel.Text = Game.nonPlayer.name + "\nSpeed: " + Game.nonPlayer.speed + "\nHealth: " + Game.nonPlayer.health + "\nPower: " + Game.nonPlayer.power;
        }

        public void Init()
        {
            branchesDeep = 0;
            Game.player.dialogueOptions.Clear();
            nonPlayerDialogue.Text = Game.nonPlayer.dialogueOptions[0];

            switch (Game.player.encounterCount)
            {
                case 0:
                    Game.player.dialogueOptions.Add("I'm just passing along, tell me about yourself!");
                    Game.player.dialogueOptions.Add("I'm here to make this my terf.");
                    break;
                case 1:
                    Game.player.dialogueOptions.Add("HEEELP HELP ME PLEASE");
                    Game.player.dialogueOptions.Add("test text");
                    break;
            }

            responseComboBox.Items.Add(Game.player.dialogueOptions[0]);
            responseComboBox.Items.Add(Game.player.dialogueOptions[1]);

            updateLabels();
        }

        private void responseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game.player.dialogueOptions.Clear();
            switch (branchesDeep)
            {
                case 0:
                    if (responseComboBox.SelectedIndex == 0) // just passing along
                    {
                        // NPC response
                        Game.nonPlayer.playerDisposition = NonPlayer.Disposition.Neutral;
                        nonPlayerDialogue.Text = Game.nonPlayer.dialogueOptions[1];

                        // Player response options
                        responseComboBox.Items.Clear();
                        Game.player.dialogueOptions.Add("Is that him over there? I'll go say hi");
                        Game.player.dialogueOptions.Add("Well it was nice to meet you, have a good day! :)");
                        responseComboBox.Items.Add(Game.player.dialogueOptions[0]);
                        responseComboBox.Items.Add(Game.player.dialogueOptions[1]);


                    }
                    else if (responseComboBox.SelectedIndex == 1) // threat
                    {
                        // NPC response
                        Game.nonPlayer.playerDisposition = NonPlayer.Disposition.Hostile;
                        nonPlayerDialogue.Text = Game.nonPlayer.dialogueOptions[2];

                        // Player response options
                        responseComboBox.Items.Clear();
                        Game.player.dialogueOptions.Add("Try me >:/");
                        Game.player.dialogueOptions.Add("Uh oh (I wasn't being serious)");
                        responseComboBox.Items.Add(Game.player.dialogueOptions[0]);
                        responseComboBox.Items.Add(Game.player.dialogueOptions[1]);
                    }
                    break;

                case 1: // Either start of fight or continue to next encounter
                    if (Game.nonPlayer.playerDisposition == NonPlayer.Disposition.Friendly || Game.nonPlayer.playerDisposition == NonPlayer.Disposition.Neutral)
                    {
                        Game.player.encounterCount++;

                    }
                    else if (Game.nonPlayer.playerDisposition == NonPlayer.Disposition.Hostile)
                    {

                    }
                    break;

            }
            branchesDeep++;




            responseComboBox.Text = "Your Response:";
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

    }
}
