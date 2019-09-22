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
    
    public class Player
    {
        public Player()
        {
            MoveSpeed = 4;
            Health = 3;
        }
        public static int MoveSpeed { get; set; }
        public static int Health { get; set; }
    }
}