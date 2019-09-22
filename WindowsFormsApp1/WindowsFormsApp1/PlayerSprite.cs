using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public class PlayerSprite : PictureBox
    {
        private static List<PlayerSprite> playerSprites = new List<PlayerSprite>();
        public PlayerSprite()
        {

            Location = new Point(450, 450);
            Size = new Size(40,40);
            BackColor = Color.Red;
            BorderStyle = BorderStyle.FixedSingle;
            playerSprites.Add(this);
        }
       
        static public List<PlayerSprite> GetPlayerSprites()
        {
            return playerSprites;
        }
    }
}
