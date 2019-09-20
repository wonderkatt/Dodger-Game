using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp1
{
    internal class EnemyController
    {
        private GameWindow gameWindow;
        private Enemy enemy;
        private List<Enemy> listOfEnemies;
        private Timer timer;

        public EnemyController(GameWindow gameWindow, Enemy enemy, List<Enemy> listOfEnemies)
        {
            this.gameWindow = gameWindow ?? throw new System.ArgumentNullException(nameof(gameWindow));
            this.enemy = enemy ?? throw new System.ArgumentNullException(nameof(enemy));
            this.listOfEnemies = listOfEnemies ?? throw new ArgumentNullException(nameof(listOfEnemies));
            timer = new Timer();
            timer.Interval = 1;
            timer.Enabled = true;
            

            MoveEnemyEventHandler();
        }

        private void MoveEnemyEventHandler()
        {
            timer.Tick += (sender, e) => MoveEnemy();
        }

        private void MoveEnemy()
        {
           
            
            foreach (var enemy in listOfEnemies)
            {
                if (enemy.isMovingRight)
                {
                enemy.enemyPicture.Location = new Point(enemy.enemyPicture.Location.X + 2, enemy.enemyPicture.Location.Y);
                }
                else if (enemy.isMovingDown)
                {
                    enemy.enemyPicture.Location = new Point(enemy.enemyPicture.Location.X , enemy.enemyPicture.Location.Y + 2);
                }
                else if (enemy.isMovingLeft)
                {
                    enemy.enemyPicture.Location = new Point(enemy.enemyPicture.Location.X - 2, enemy.enemyPicture.Location.Y );
                }
            }
        }
    }
}