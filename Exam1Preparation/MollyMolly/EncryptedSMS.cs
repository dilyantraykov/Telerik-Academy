using System;

class EncryptedSMS
{
    static void Main()
    {
        long A = long.Parse(Console.ReadLine());
        long B = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine());
        long R = 0;
        if (B == 2)
        {
            R = A % C;
        }
        else if (B == 4)
        {
            R = A + C;
        }
        else if (B == 8)
        {
            R = A * C;
        }
        Console.WriteLine((R % 4 == 0) ? (R / 4) : (R % 4));
        Console.WriteLine(R);
    }
}