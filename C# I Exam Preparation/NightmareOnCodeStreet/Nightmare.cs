using System;

class Nightmare
{
    static void Main()
    {
        string str = Console.ReadLine();
        int sum = 0;
        int count = 0;
        int digit;
        for (int i = 1; i < str.Length; i+=2)
        {
            if (int.TryParse(str[i].ToString(), out digit))
            {
                count++;
                sum += digit;
            }
        }
        Console.WriteLine(count + " " + sum);
    }
}
