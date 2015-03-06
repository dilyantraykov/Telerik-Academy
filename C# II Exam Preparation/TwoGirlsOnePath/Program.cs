/*
Condition
*/

using System;
using System.Numerics;

class Program
{
    struct Girl {
        public BigInteger x;
        public BigInteger totalFlowers;
        public int direction;
        public bool stopped;
    }
    static void Main()
    {
        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int N = input.Length;
        BigInteger[] F = new BigInteger[N + 1];
        for (int i = 1; i <= N; i++)
        {
            F[i] = BigInteger.Parse(input[i-1]);
        }
        Girl Molly = new Girl();
        Molly.x = 1;
        Molly.totalFlowers = 0;
        Molly.direction = 1;
        Molly.stopped = false;
        Girl Dolly = new Girl();
        Dolly.x = N;
        Dolly.totalFlowers = 0;
        Molly.stopped = false;
        Dolly.direction = -1;
        while (!Molly.stopped && !Dolly.stopped)
        {
            BigInteger moveMolly = F[(int)Molly.x];
            BigInteger moveDolly = F[(int)Dolly.x];

            if (F[(int)Molly.x] == 0)
            {
                Molly.stopped = true;
            }
            if (F[(int)Dolly.x] == 0)
            {
                Dolly.stopped = true;
            }

            if (Molly.x == Dolly.x)
            {
                Molly.totalFlowers += F[(int)Molly.x] / 2;
                Dolly.totalFlowers += F[(int)Dolly.x] / 2;
                F[(int)Molly.x] = 1;
            }
            else
            {
                Molly.totalFlowers += F[(int)Molly.x];
                Dolly.totalFlowers += F[(int)Dolly.x];
                F[(int)Molly.x] = 0;
                F[(int)Dolly.x] = 0;
            }

            if (Molly.stopped || Dolly.stopped)
            {
                break;
            }


            Molly.x += (Molly.direction * moveMolly);
            Dolly.x += Dolly.direction * moveDolly;
            if (Molly.x > N)
            {
                Molly.x = Molly.x % N;
            }
            if (Dolly.x < 1)
            {
                Dolly.x = (Dolly.x % N) + N;
            }
        }
        if (Molly.stopped && !Dolly.stopped)
        {
            Console.WriteLine("Dolly");
        }
        else if (Dolly.stopped && !Molly.stopped)
        {
            Console.WriteLine("Molly");
        }
        else
        {
            Console.WriteLine("Draw");
        }
        Console.WriteLine("{0} {1}", Molly.totalFlowers, Dolly.totalFlowers);
    }
}
