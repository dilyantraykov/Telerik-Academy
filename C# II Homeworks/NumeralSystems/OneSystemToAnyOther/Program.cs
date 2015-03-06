/*
Condition
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number in any numeral system (>=2, <=16): ");
        string inputNumber = Console.ReadLine().ToUpper();
        Console.Write("Enter base system (>=2, <=16): ");
        int fromBase = int.Parse(Console.ReadLine());
        Console.Write("Enter target system (>=2, <=16): ");
        int targetBase = int.Parse(Console.ReadLine());

        long decimalNumber = ConvertToDecimal(inputNumber, fromBase);
        string result = ConvertFromDecimal(decimalNumber, targetBase);

        Console.WriteLine("{0} = {1}",
            inputNumber, result);
    }

    static long ConvertToDecimal(string number, int fromBase)
    {
        long result = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(number[i]))
            {
                result += int.Parse(number[i].ToString()) * (long)Math.Pow(fromBase, number.Length - i - 1);
            }
            else
            {
                result += (number[i] - 'A' + 10) * (long)Math.Pow(fromBase, number.Length - i - 1);
            }
        }
        return result;
    }

    static string ConvertFromDecimal(long number, int toBase)
    {
        string result = "";
        if (number == 0)
        {
            result = "0";
        }
        else
        {
            while (number > 0)
            {
                if (number % toBase < 10)
                {
                    result = number % toBase + result;
                }
                else
                {
                    result = (char)(number % toBase + 'A' - 10) + result;
                }
                number /= toBase;
            }
        }
        return result;
    }
}

