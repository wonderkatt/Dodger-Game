using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace WindowsFormsApp1
{
     
    public partial class GameWindow : Form
    {



        public Random random = new Random();
        public Timer masterTimer = new Timer();
        

        public GameWindow()
        {
            InitializeComponent();
            var enemy = new Enemy(this);
            var player = new Player();
            var gold = new Gold(this);
            var goldSpawner = new GoldSpawner(this, gold);
            this.MaximumSize = new Size(900, 900);
            masterTimer.Interval = 1;
            masterTimer.Enabled = true;
            var playerSprite = new PlayerSprite();
            Controls.Add(playerSprite);
            var PlayerController = new PlayerContoller(this, playerSprite);
            var enemyPicture = new EnemyPicture(this);
            var enemySpawner = new EnemySpawner(this, enemyPicture);
            var enemyController = new EnemyController(this);

            masterTimer.Tick += (sender, e) => SetRandomNumberEveryTick();
            masterTimer.Tick += (sender, e) => CheckIfGameShouldRun();
        }

        private void CheckIfGameShouldRun()
        {
            scorelabel.Text = Score.ToString();
            health.Text = Player.Health.ToString();
            if (Player.Health == 0)
            {
                masterTimer.Stop();
            }
        }

        public void SetRandomNumberEveryTick()
        {
            RandomNumber = random.Next(0,3);
            RandomCoordinateNumber = random.Next(0, 19);
            RandomGoldXCoordinate = random.Next(100, 800);
            RandomGoldYCoordinate = random.Next(100, 800);
        }

        public int RandomNumber { get; set; }
        public int RandomCoordinateNumber { get; set; }
        public int RandomGoldXCoordinate { get; set; }
        public int RandomGoldYCoordinate { get; set; }
        public int Score { get; set; }
    }
}
