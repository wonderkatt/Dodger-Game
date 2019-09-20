using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class EnemySpawner
    {
        private GameWindow gameWindow;
        private Enemy enemy;
       // private  List<Enemy> listOfEnemies;
        private Timer spawnTimer; 
        Random random = new Random();
      



        public EnemySpawner(GameWindow gameWindow, Enemy enemy)
        {
            this.gameWindow = gameWindow ?? throw new ArgumentNullException(nameof(gameWindow));
            this.enemy = enemy ?? throw new ArgumentNullException(nameof(enemy));
           // listOfEnemies = new List<Enemy>();
            spawnTimer = new Timer();
            spawnTimer.Interval = 50;
            spawnTimer.Enabled = true;

            SpawnEventHandler();  
        }

        private void SpawnEventHandler()
        {
            
            spawnTimer.Tick += (sender, e) => SpawnEnemy();
        }

        private void SpawnEnemy()
        {
            int size = random.Next(20, 41);
            

            

            enemy = new Enemy(gameWindow);
            enemy.CreateEnemy(size, DecideSpawnPoint());
            gameWindow.Controls.Add(enemy.enemyPicture);
            listOfEnemies.Add(enemy);
        }

        private Point DecideSpawnPoint()
        {
            
            
            int spawnSide = random.Next(0,900);
            int xCoordForSpawn = 0;
            int yCoordForSpawn = 0;

            if (spawnSide < 300)
            {
                yCoordForSpawn = random.Next(0, 450);
                enemy.isMovingRight = true;
                Point spawnPoint = new Point(xCoordForSpawn, yCoordForSpawn);
                return spawnPoint;
            }
            else if (spawnSide > 599)
            {
                xCoordForSpawn = random.Next(0, 900);
                enemy.isMovingDown = true;
                Point spawnPoint = new Point(xCoordForSpawn, yCoordForSpawn);
                return spawnPoint;
            }
            else 
            {
                yCoordForSpawn = random.Next(0, 450);
                xCoordForSpawn = 900;
                enemy.isMovingLeft = true;
                Point spawnPoint = new Point(xCoordForSpawn, yCoordForSpawn);
                return spawnPoint;
            }
            
            
        }
    }
}
