﻿using System;
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
        Point spawnPoint;
        public Enemy(GameWindow gameWindow)
        {
            
        }

        public Point SpawnPoint { get { return spawnPoint; } set { spawnPoint = value; } }
    

       
    }
}
