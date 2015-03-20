namespace Timer
{
    using System;
    using System.Threading;

    public delegate void TimerDelegate(int time);

    public static class Timer
    {
        public static void Start(int seconds)
        {
            while (true)
            {
                Thread.Sleep(seconds * 1000);
                Console.WriteLine("{0}", DateTime.Now);
            }
        }
    }
}
