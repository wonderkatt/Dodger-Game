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
        private EnemyPicture enemyPicture;
        private static int size;

        
        private Timer spawnTimer; 
        Random random = new Random();
        private List<EnemyPicture> listOfEnemies;

        public EnemySpawner(GameWindow gameWindow, Enemy enemy, EnemyPicture enemyPicture, List<EnemyPicture> listOfEnemies)
        {
            this.gameWindow = gameWindow ?? throw new ArgumentNullException(nameof(gameWindow));
            this.enemy = enemy ?? throw new ArgumentNullException(nameof(enemy));
            this.enemyPicture = enemyPicture ?? throw new ArgumentNullException(nameof(enemyPicture));
            this.listOfEnemies = listOfEnemies ?? throw new ArgumentNullException(nameof(listOfEnemies));
            spawnTimer = new Timer();
            spawnTimer.Interval = 50;
            spawnTimer.Enabled = true;

            SpawnEventHandler();  
        }

        public static int Size { get { return size; } set { size = value; } }
      

        private void SpawnEventHandler()
        {
            
            spawnTimer.Tick += (sender, e) => SpawnEnemy();
        }

        private void SpawnEnemy()
        {
            enemyPicture = new EnemyPicture(enemy);

            SetSize();
            enemy.SpawnPoint = SetSpawnpointAndDirection();

           

            gameWindow.Controls.Add(enemyPicture);
            listOfEnemies.Add(enemyPicture);
           

        }


        private void SetSize()
        {
            int size = random.Next(20, 41);
            Size = size;
        }

        private Point SetSpawnpointAndDirection()
        {


            int spawnSide = random.Next(0,3);
            int xCoordForSpawn = 0;
            int yCoordForSpawn = 0;

            if (spawnSide == 0)
            {
                enemyPicture.IsMovingRight = true;
                yCoordForSpawn = random.Next(0, 900);
                Point spawnPoint = new Point(xCoordForSpawn, yCoordForSpawn);
                return spawnPoint;
            }
            else if (spawnSide == 1)
            {
                enemyPicture.IsMovingDown = true;
                xCoordForSpawn = random.Next(0, 900);
                Point spawnPoint = new Point(xCoordForSpawn, yCoordForSpawn);
                return spawnPoint;
            }
            else 
            {
                enemyPicture.IsMovingLeft = true;
                yCoordForSpawn = random.Next(0, 900);
                xCoordForSpawn = 900;
                Point spawnPoint = new Point(xCoordForSpawn, yCoordForSpawn);
                return spawnPoint;
            }
            
            
        }
    }
}
