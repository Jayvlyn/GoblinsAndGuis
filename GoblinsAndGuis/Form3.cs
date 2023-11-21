﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinsAndGuis
{
    public partial class Form3 : Form
    {
        private Time t = new Time();
        public bool cooldowns = false;

        public Form3()
        {
            InitializeComponent();


            // Timer for Update()
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 50;   // milliseconds
            tmr.Tick += Update;  // set handler
            tmr.Start();
        }

        private void Update(object sender, EventArgs e)  //run this logic each timer tick
        {
            t.Update();

            if (cooldowns)
            {
                for (int i = 0; i < Game.player.moves.Length; i++)
                {
                    if (Game.player.moves[i].ready != true) Game.player.moves[i].CountCooldown(t.dt);
                }

                for (int i = 0; i < Game.nonPlayer.moves.Length; i++)
                {
                    if (Game.nonPlayer.moves[i].ready != true) Game.nonPlayer.moves[i].CountCooldown(t.dt);
                }


                Game.nonPlayer.MoveTimer(t.dt);

                // Update player buttons
                if (Game.player.moves[0].ready) playerMove1Button.Text = Game.player.moves[0].name;
                else playerMove1Button.Text = Game.player.moves[0].name + "\n" + (int)Game.player.moves[0].cooldownTimer;

                if (Game.player.moves[1].ready) playerMove2Button.Text = Game.player.moves[1].name;
                else playerMove2Button.Text = Game.player.moves[1].name + "\n" + (int)Game.player.moves[1].cooldownTimer;

                if (Game.player.moves[2].ready) playerMove3Button.Text = Game.player.moves[2].name;
                else playerMove3Button.Text = Game.player.moves[2].name + "\n" + (int)Game.player.moves[2].cooldownTimer;

                if (Game.player.moves[3].ready) playerMove4Button.Text = Game.player.moves[3].name;
                else playerMove4Button.Text = Game.player.moves[3].name + "\n" + (int)Game.player.moves[3].cooldownTimer;

                // Update enemy buttons
                if (Game.nonPlayer.moves[0].ready) nonPlayerMove1Button.Text = Game.nonPlayer.moves[0].name;
                else nonPlayerMove1Button.Text = Game.nonPlayer.moves[0].name + "\n" + (int)Game.nonPlayer.moves[0].cooldownTimer;

                if (Game.nonPlayer.moves[1].ready) nonPlayerMove2Button.Text = Game.nonPlayer.moves[1].name;
                else nonPlayerMove2Button.Text = Game.nonPlayer.moves[1].name + "\n" + (int)Game.nonPlayer.moves[1].cooldownTimer;

                if (Game.nonPlayer.moves[2].ready) nonPlayerMove3Button.Text = Game.nonPlayer.moves[2].name;
                else nonPlayerMove3Button.Text = Game.nonPlayer.moves[2].name + "\n" + (int)Game.nonPlayer.moves[2].cooldownTimer;

                if (Game.nonPlayer.moves[3].ready) nonPlayerMove4Button.Text = Game.nonPlayer.moves[3].name;
                else nonPlayerMove4Button.Text = Game.nonPlayer.moves[3].name + "\n" + (int)Game.nonPlayer.moves[3].cooldownTimer;

            }

        }

        public void Init()
        {
            if (Game.nonPlayer == (NonPlayer)Assets.characterList[0])
            {
                npcPictureBox.Image = Properties.Resources.BobRobert;
            }
            else if (Game.nonPlayer == (NonPlayer)Assets.characterList[1])
            {
                npcPictureBox.Image = Properties.Resources.ChobCrobert;
            }

            UI.updateLabels(playerLabel, nonPlayerLabel);

            cooldowns = true;
        }

        #region PLAYER MOVES
        private void playerMove1Button_Click(object sender, EventArgs e)
        {
            Game.player.UseMove(Game.nonPlayer, 0);
            UI.updateLabels(playerLabel, nonPlayerLabel);
            if (Game.checkCombatVictory()) UI.onCombatVictory();
        }

        private void playerMove2Button_Click_1(object sender, EventArgs e)
        {
            Game.player.UseMove(Game.nonPlayer, 1);
            UI.updateLabels(playerLabel, nonPlayerLabel);
            if (Game.checkCombatVictory()) UI.onCombatVictory();
        }

        private void playerMove3Button_Click(object sender, EventArgs e)
        {
            Game.player.UseMove(Game.nonPlayer, 2);
            UI.updateLabels(playerLabel, nonPlayerLabel);
            if (Game.checkCombatVictory()) UI.onCombatVictory();
        }

        private void playerMove4Button_Click(object sender, EventArgs e)
        {
            Game.player.UseMove(Game.nonPlayer, 3);
            UI.updateLabels(playerLabel, nonPlayerLabel);
            if (Game.checkCombatVictory()) UI.onCombatVictory();
        }
        #endregion

        #region trash
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void playerLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void nonPlayerLabel_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}