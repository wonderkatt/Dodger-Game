using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Gold : PictureBox
    {
        private GameWindow gameWindow;

        private int lifeCounter = 0;

        public Gold(GameWindow gameWindow)
        {
            this.gameWindow = gameWindow ?? throw new ArgumentNullException(nameof(gameWindow));
            BackColor = Color.Gold;
            Size = new Size(40, 40);
            Location = GoldSpawner.SpawnPoint;
            gameWindow.masterTimer.Tick += (sender, e) => IncrementLifeCounter();
            gameWindow.masterTimer.Tick += (sender, e) => CheckForCollision();
        }

        private void CheckForCollision()
        {
            List<Gold> listOfGold = GoldSpawner.GetListOfGold();
            List<PlayerSprite> listOfPlayers = PlayerSprite.GetPlayerSprites();
            var player = listOfPlayers.First<PlayerSprite>();
            foreach (var gold in listOfGold)
            {
                if(gold.Bounds.IntersectsWith(player.Bounds) && gold.Visible)
                {
                    gold.Dispose();
                    gameWindow.Score += 1;
                }
            }
        }

        private void IncrementLifeCounter()
        {
            lifeCounter++;
        }

        public int LifeCounter { get { return lifeCounter; } private set { lifeCounter = value; } }
    }
}
