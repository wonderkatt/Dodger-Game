using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
     
    public partial class GameWindow : Form
    {



        private List<Enemy> listOfEnemies = new List<Enemy>;






        public GameWindow()
        {

            InitializeComponent();
            this.MaximumSize = new Size(900, 900);
            
            var player = new Player();
            var enemy = new Enemy(this);
            var PlayerController = new PlayerContoller(this, player, PlayerSprite);
            var enemyController = new EnemyController(this, enemy, listOfEnemies);
            var EnemySpawner = new EnemySpawner(this, enemy);
            
        }


    }
}
