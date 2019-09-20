using System;
using System.Timers;

public class Timer
{
    static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


    public Timer()
	{
        timer.Interval = 1;
	}
}
