using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGuis
{
    public static class Game
    {

        public static Player player = new Player();
        public static NonPlayer nonPlayer = new NonPlayer();
        public static FormManager formManager = new FormManager();

        public static void Init()
        {
            Application.Run(formManager.characterCreation);
        }

    }
}
