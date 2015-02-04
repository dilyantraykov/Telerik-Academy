using System;

class Sheet
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] A = new int[11];
        for (int i = 10; i >= 0; i--)
        {
            A[10 - i] = (int)Math.Pow(2, i);
        }
        int min = A[0];
        for (int i = 0; i < 11; i++)
        {
            if (N / A[i] <= min && N / A[i] >= 1)
            {
                min = N / A[i];
                N -= A[i];
            }
            else
            {
                Console.WriteLine("A{0}", i);
            }
        }
    }
}

