using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;




namespace WindowsFormsApp1
{
    class PlayerContoller
    {
        private GameWindow gameWindow;
        private static int setxAxisDirection = 0;
        private static int setYAxisDirection = 0;
        private static int upMove = 0;
        private static int downMove = 0;
        private static int rightMove = 0;
        private static int leftMove = 0;
        private readonly PictureBox playerSprite;

        public PlayerContoller(GameWindow gameWindow, PictureBox playerSprite)
        {
            this.gameWindow = gameWindow ?? throw new ArgumentNullException(nameof(gameWindow));
            this.playerSprite = playerSprite ?? throw new ArgumentNullException(nameof(playerSprite));


            ConfigureEventHandler(gameWindow.masterTimer);
            
        }


        private void ConfigureEventHandler(Timer timer)
        {
            timer.Tick += (sender, e) => MovePlayer();
           gameWindow.KeyDown += (sender, e) => PlayerInputKey(e);
           gameWindow.KeyUp += (sender, e) => PlayerReleaseKey(e);   
        }

        private void PlayerReleaseKey(KeyEventArgs e)
      {
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                rightMove = 0;
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                leftMove = 0;
            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                upMove = 0;
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                downMove = 0;
            }

        }

        private void PlayerInputKey(KeyEventArgs e)
        {

            if(e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                rightMove = Player.MoveSpeed;
            }
            else if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                leftMove = Player.MoveSpeed * -1;
            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                upMove = Player.MoveSpeed * -1;
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                downMove = Player.MoveSpeed;
            }


        }

        private void MovePlayer()
        {
            if(playerSprite.Location.X < 0)
            {
                leftMove = 0;
            }
            else if(playerSprite.Right > 883)
            {
                rightMove = 0;
            }
            else if(playerSprite.Location.Y < 0)
            {
                upMove = 0;
            }
            else if(playerSprite.Bottom > 860)
            {
                downMove = 0;
            }
            setxAxisDirection = rightMove + leftMove;
            setYAxisDirection = upMove + downMove;
            playerSprite.Location = new Point(playerSprite.Location.X + setxAxisDirection, playerSprite.Location.Y + setYAxisDirection);

        }


    }
}
