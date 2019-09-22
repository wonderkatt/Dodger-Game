using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class EnemyPicture : PictureBox
    {
        private readonly GameWindow gameWindow;
        private int lifeCounter = 0;

        public EnemyPicture(GameWindow gameWindow)
        {
            this.gameWindow = gameWindow ?? throw new ArgumentNullException(nameof(gameWindow));
            gameWindow.masterTimer.Tick += (sender, e) => CheckForCollision();
            gameWindow.masterTimer.Tick += (sender, e) => IncrementLifeCounter();

            BackColor = Color.Black;
            Size = new Size(40, 40);
            lifeCounter = 0;
            Location = EnemySpawner.SpawnPoint;

        }

        public int LifeCounter { get { return lifeCounter; } private set { lifeCounter = value; } }

     private void IncrementLifeCounter()
     {
            lifeCounter++;
     }

        private void CheckForCollision()
        {
            var listOfEnemies = EnemySpawner.GetListOfEnemies();
            var listOfPlayers = PlayerSprite.GetPlayerSprites();
            var player = listOfPlayers.First<PlayerSprite>();
            foreach (var enemyPicture in listOfEnemies)
            {
                if(enemyPicture.Bounds.IntersectsWith(player.Bounds) && enemyPicture.Visible)
                {
                   
                    enemyPicture.Dispose();
                    Player.Health = Player.Health - 1;
                    
                }
                
              
            }
        }
    }
}
