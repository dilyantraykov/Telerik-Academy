using System;

class EncryptedSMS
{
    static void Main()
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string input3 = Console.ReadLine();
        uint A, B, C;
        uint R = 0;
        if ((uint.TryParse(input1, out A)) && (uint.TryParse(input2, out B)) && (uint.TryParse(input3, out C)))
        {
            if (B == 2)
            {
                R = A % C;
            }
            else if (B == 4)
            {
                R = A + C;
            }
            else if (B == 6)
            {
                R = A * C;
            }
            else
            {
                return;
            }
            Console.WriteLine((R % 4 == 0) ? (R / 4) : (R % 4));
            Console.WriteLine(R);
        }
    }
}