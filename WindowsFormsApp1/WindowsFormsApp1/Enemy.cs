using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Enemy
    {
        private GameWindow gameWindow;

        public Enemy(GameWindow gameWindow)
        {
            this.gameWindow = gameWindow ?? throw new ArgumentNullException(nameof(gameWindow));
            MoveSpeed = 2;
            Damage = 1;
        }

        public static int MoveSpeed { get; set; }
        public static int Damage { get; set; }
    }
}
