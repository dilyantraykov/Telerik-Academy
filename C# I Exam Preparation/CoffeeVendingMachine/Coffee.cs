using System;

class Coffee
{
    static void Main()
    {
        double[] N = new double[5];
        for (int i = 0; i < 5; i++)
        {
            N[i] = Convert.ToDouble(Console.ReadLine());
        }
        double A = Convert.ToDouble(Console.ReadLine());
        double P = Convert.ToDouble(Console.ReadLine());
        double machineTray = N[0] * 0.05 + N[1] * 0.1 + N[2] * 0.2 + N[3] * 0.5 + N[4] * 1;
        if (machineTray >= A - P && A >= P)
        {
            Console.Write("Yes {0:F2}", machineTray - A + P);
        }
        else if (A < P)
        {
            Console.Write("More {0:F2}", P - A);
        }
        else if (A > P && A - P > machineTray)
        {
            Console.Write("No {0:F2}", A - P - machineTray);
        }
    }
}

