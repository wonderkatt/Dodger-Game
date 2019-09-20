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
        private List<EnemyPicture> listOfEnemies;
        private Timer timer;

        public EnemyController(GameWindow gameWindow, Enemy enemy, List<EnemyPicture> listOfEnemies)
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

            timer.Tick += (sender, e) => RemoveEnemy();
        }

        private void RemoveEnemy()
        {
            foreach (var enemy in listOfEnemies)
            {
                if (enemy.DisposeCounter == 200)
                {
                    enemy.Dispose();
                }
            }
        }

        private void MoveEnemy()
        {
           
            
           foreach (var enemy in listOfEnemies)
           {
                if (enemy.IsMovingRight == true && enemy.IsMovingDown != true && enemy.IsMovingLeft != true)
                {
                    enemy.Location = new Point(enemy.Location.X + 4, enemy.Location.Y);
                }
                else if (enemy.IsMovingRight != true && enemy.IsMovingDown != true && enemy.IsMovingLeft == true)
                {
                    enemy.Location = new Point(enemy.Location.X - 4, enemy.Location.Y);
                }
               else if (enemy.IsMovingRight != true && enemy.IsMovingDown == true && enemy.IsMovingLeft != true)
                {
                    enemy.Location = new Point(enemy.Location.X, enemy.Location.Y + 4);
                }
           }
        }
    }
}