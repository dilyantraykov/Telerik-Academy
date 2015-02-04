using System;

class Tribonacci
{
    static void Main()
    {
        long number1 = long.Parse(Console.ReadLine());
        long number2 = long.Parse(Console.ReadLine());
        long number3 = long.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());
        Console.WriteLine(number1);
        Console.WriteLine(number2 + " " + number3);
        int count = 3;
        for (int i = 0; i < lines - 2; i++)
        {
            for (int j = 0; j < count; j++)
            {
                Console.Write(number1 + number2 + number3 + (j == count - 1 ? "" : " "));
                long temp = number1 + number2 + number3;
                number1 = number2;
                number2 = number3;
                number3 = temp;
            }
            count++;
            Console.WriteLine();
        }
    }
}

