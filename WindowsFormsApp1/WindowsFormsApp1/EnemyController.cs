using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp1
{
    class EnemyController
    {
        private readonly GameWindow gameWindow;

        public EnemyController(GameWindow gameWindow)
        {
            this.gameWindow = gameWindow ?? throw new ArgumentNullException(nameof(gameWindow));

            EnemyEventHandler(gameWindow.masterTimer);
        }

        private void EnemyEventHandler(Timer timer)
        {
            timer.Tick += (sender, e) => MoveEnemy();
            timer.Tick += (sender, e) => TimeToLive();
        }

        private void TimeToLive()
        {
            List<EnemyPicture> listOfEnemies = EnemySpawner.GetListOfEnemies();
            foreach (var enemy in listOfEnemies)
            {
                if (enemy.LifeCounter > 450)
                {
                    enemy.Dispose();
                }
            }
        }

        private void MoveEnemy()
        {
            
            List<EnemyPicture> listOfEnemiesMovingRight = EnemySpawner.GetListOfEnemiesMovingRight();
            List<EnemyPicture> listOfEnemiesMovingLeft = EnemySpawner.GetListOfEnemiesMovingLeft();
            List<EnemyPicture> listOfEnemiesMovingDown = EnemySpawner.GetListOfEnemiesMovingDown();

            for (int i = 0; i < listOfEnemiesMovingRight.Count; i++)
            {
                listOfEnemiesMovingRight[i].Location = new Point(listOfEnemiesMovingRight[i].Location.X + Enemy.MoveSpeed, listOfEnemiesMovingRight[i].Location.Y);
            }
            // foreach (var enemy in listOfEnemiesMovingRight)
            // {
            //     enemy.Location = new Point(enemy.Location.X + Enemy.MoveSpeed, enemy.Location.Y);
            // }
            for (int i = 0; i < listOfEnemiesMovingLeft.Count; i++)
            {
                listOfEnemiesMovingLeft[i].Location = new Point(listOfEnemiesMovingLeft[i].Location.X + Enemy.MoveSpeed * -1, listOfEnemiesMovingLeft[i].Location.Y);
            }
            // foreach (var enemy in listOfEnemiesMovingLeft)
            // {
            //     enemy.Location = new Point(enemy.Location.X + Enemy.MoveSpeed * -1, enemy.Location.Y);
            // }
            for (int i = 0; i < listOfEnemiesMovingDown.Count; i++)
            {
                listOfEnemiesMovingDown[i].Location = new Point(listOfEnemiesMovingDown[i].Location.X, listOfEnemiesMovingDown[i].Location.Y + Enemy.MoveSpeed);
            }
           // foreach (var enemy in listOfEnemiesMovingDown)
           // {
           //     enemy.Location = new Point(enemy.Location.X, enemy.Location.Y + Enemy.MoveSpeed);
           // }
        }
    }
}