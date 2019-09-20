using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Enemy
    {
        public PictureBox enemyPicture = new PictureBox();
        private Timer timer = new Timer();
        private int lifeCounter = 0;
        public Enemy(GameWindow gameWindow)
        {
            timer.Tick += (sender,e) => RemovePictureBox(gameWindow);
        }

        private void RemovePictureBox(GameWindow gameWindow)
        {
            lifeCounter++;
                if (lifeCounter > 450)
            {
                gameWindow.Controls.Remove(enemyPicture);
               
            }
        }

        public object Controls { get; private set; }
        public bool isMovingRight = false;
        public bool isMovingLeft = false;
        public bool isMovingDown = false;

        public void CreateEnemy(int size, Point spawnPoint)
        {
            enemyPicture.BackColor = Color.Black;
            enemyPicture.Size = new Size(size, size);
            enemyPicture.Location = spawnPoint;
            enemyPicture.Name = "enemySprite";
            timer.Interval = 1;
            timer.Enabled = true;

            

        }

       
    }
}
