/*
Problem 7. Timer

Using delegates write a class Timer that can execute certain method at each t seconds.
*/

using System;

namespace Timer
{
    public class DelegateTimer
    {
        private static void Main()
        {
            Console.Write("Enter timer period in seconds: ");
            int period = int.Parse(Console.ReadLine());
            var timerDelegate = new TimerDelegate(Timer.Start);
            timerDelegate(period);
        }
    }
}
