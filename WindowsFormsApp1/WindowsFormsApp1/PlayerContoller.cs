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
        private Player player;
        private Timer playerTimer;
        private PictureBox playerSprite;
        private static int setxAxisDirection = 0;
        private static int setYAxisDirection = 0;
        private static int upMove = 0;
        private static int downMove = 0;
        private static int rightMove = 0;
        private static int leftMove = 0;


        public PlayerContoller(GameWindow gameWindow, Player player, PictureBox playerSprite)
        {


            playerTimer = new Timer();
            playerTimer.Interval = 1;
            playerTimer.Enabled = true;
            this.gameWindow = gameWindow ?? throw new ArgumentNullException(nameof(gameWindow));
            this.player = player ?? throw new ArgumentNullException(nameof(player));
            this.playerSprite = playerSprite ?? throw new ArgumentNullException(nameof(playerSprite));
            ConfigureEventHandler(playerTimer);
        }


        private void ConfigureEventHandler(Timer timer)
        {
            playerTimer.Tick += (sender, e) => MovePlayer();
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
                rightMove = Player.moveMentSpeed;
            }
            else if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                leftMove = Player.moveMentSpeed * -1;
            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                upMove = Player.moveMentSpeed * -1;
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                downMove = Player.moveMentSpeed;
            }


        }

        private void MovePlayer()
        {
            setxAxisDirection = rightMove + leftMove;
            setYAxisDirection = upMove + downMove;
            playerSprite.Location = new Point(playerSprite.Location.X + setxAxisDirection, playerSprite.Location.Y + setYAxisDirection);

        }


    }
}
