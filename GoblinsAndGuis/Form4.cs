using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinsAndGuis
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void Init()
        {
            if (Game.player.dead)
            {
                subtitleLabel.Text = "You died to " + Assets.characterList[Game.player.encounterCount - 1].name + "!!";
                resultLabel.Text = "YOU LOSE!!!";
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            UI.formManager.ChangeForm(FormManager.FormState.CharacterCreation);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
