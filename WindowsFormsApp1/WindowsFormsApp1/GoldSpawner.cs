using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class GoldSpawner
    {
        private readonly GameWindow gameWindow;
        private readonly PictureBox gold;
        private static List<Gold> listOfGold = new List<Gold>();
        private int spawnCounter = 0;

        public GoldSpawner(GameWindow gameWindow, PictureBox gold)
        {

            this.gameWindow = gameWindow ?? throw new ArgumentNullException(nameof(gameWindow));
            this.gold = gold ?? throw new ArgumentNullException(nameof(gold));
            gameWindow.masterTimer.Tick += (sender, e) => SpawnGoal();
            gameWindow.masterTimer.Tick += (sender, e) => RemoveGold();


        }

        private void RemoveGold()
        {
            foreach (var gold in listOfGold)
            {
                if(gold.LifeCounter > 300)
                {
                    gold.Dispose();
                }
            }
        }

        public static List<Gold> GetListOfGold()
        {
            return listOfGold;
        }

        private void SpawnGoal()
        {
            if(spawnCounter > 100)
            {

            SpawnPoint = new Point(gameWindow.RandomGoldXCoordinate, gameWindow.RandomGoldYCoordinate);
            var newGold = new Gold(gameWindow);

            gameWindow.Controls.Add(newGold);
            listOfGold.Add(newGold);
                spawnCounter = 0;
            }
            else
            {
                spawnCounter++;
            }
        }

        public static Point SpawnPoint { get; set; }
    }
}
