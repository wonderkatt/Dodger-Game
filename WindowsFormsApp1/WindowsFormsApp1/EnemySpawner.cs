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
        private EnemyPicture enemyPicture;
        private static List<EnemyPicture> listOfEnemies = new List<EnemyPicture>();
        private static List<EnemyPicture> listOfEnemiesMovingRight = new List<EnemyPicture>();
        private static List<EnemyPicture> listOfEnemiesMovingLeft = new List<EnemyPicture>();
        private static List<EnemyPicture> listOfEnemiesMovingDown = new List<EnemyPicture>();
        private int spawnCounter = 0;
        

        public EnemySpawner(GameWindow gameWindow, EnemyPicture enemyPicture)
        {
            this.gameWindow = gameWindow ?? throw new ArgumentNullException(nameof(gameWindow));
            this.enemyPicture = enemyPicture ?? throw new ArgumentNullException(nameof(enemyPicture));

            gameWindow.masterTimer.Tick += (sender, e) => SpawnEnemyEvent();
        }

        public static Point SpawnPoint { get; set; }

        static public List<EnemyPicture> GetListOfEnemies()
        {
            return listOfEnemies;
        }

        static public List<EnemyPicture> GetListOfEnemiesMovingRight()
        {
            return listOfEnemiesMovingRight;
        }

        static public List<EnemyPicture> GetListOfEnemiesMovingLeft()
        {
            return listOfEnemiesMovingLeft;
        }

        static public List<EnemyPicture> GetListOfEnemiesMovingDown()
        {
            return listOfEnemiesMovingDown;
        }

        private void SpawnEnemyEvent()
        {
            
            if (spawnCounter > 10)
            {
                int spawnSide = gameWindow.RandomNumber;
                if (spawnSide == 0) 
                {
                    SpawnPoint = new Point(1, gameWindow.RandomCoordinateNumber * 50);
                    var newEnemy = new EnemyPicture(gameWindow);
                    

                    gameWindow.Controls.Add(newEnemy);
                    listOfEnemies.Add(newEnemy);
                    listOfEnemiesMovingRight.Add(newEnemy);
                    spawnCounter = 0;
                }
                else if (spawnSide == 1)
                {
                   
                    SpawnPoint = new Point(gameWindow.RandomCoordinateNumber * 50, 1);
                    var newEnemy = new EnemyPicture(gameWindow);
                    

                    gameWindow.Controls.Add(newEnemy);
                    listOfEnemies.Add(newEnemy);
                    listOfEnemiesMovingDown.Add(newEnemy);
                    spawnCounter = 0;
                }
                else if (spawnSide == 2)
                {
                    
                    SpawnPoint = new Point(899, gameWindow.RandomCoordinateNumber * 50);
                    var newEnemy = new EnemyPicture(gameWindow);
                    

                    gameWindow.Controls.Add(newEnemy);
                    listOfEnemies.Add(newEnemy);
                    listOfEnemiesMovingLeft.Add(newEnemy);
                    spawnCounter = 0;
                }
            }
            else
            {
                spawnCounter++;
            }


        }
    }
}
