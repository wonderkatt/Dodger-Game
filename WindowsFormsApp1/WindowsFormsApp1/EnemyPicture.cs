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
        
        Timer timer = new Timer();
        private int disposeCounter;

        public EnemyPicture(Enemy enemy)
        {

            IsMovingDown = false;
            IsMovingLeft = false;
            isMovingRight = false;
            Point spawnPoint = enemy.SpawnPoint;
            int size = EnemySpawner.Size;
            BackColor = Color.Black;
            Size = new Size(size, size);
            Location = spawnPoint;
            timer.Interval = 1;
            timer.Enabled = true;

            timer.Tick += (sender, e) => IncrementCounter(this);

        }

        public int DisposeCounter { get { return disposeCounter; } set { disposeCounter = value; } }

        private void IncrementCounter(EnemyPicture enemyPicture)
        {
            DisposeCounter = DisposeCounter + 1;
        }
        private bool isMovingRight;
        private bool isMovingLeft;
        private bool isMovingDown;

        public bool IsMovingRight { get { return isMovingRight; } set { isMovingRight = value; } }
        public bool IsMovingLeft { get { return isMovingLeft; } set { isMovingLeft = value; } }
        public bool IsMovingDown { get { return isMovingDown; } set { isMovingDown = value; } }
    }
}
