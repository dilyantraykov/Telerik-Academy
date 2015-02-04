using System;

class Numbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int beersM = 0;
        int beersV = 0;
        for (int i = 0; i < N; i++)
        {
            string startNumber = Console.ReadLine();
            startNumber = int.Parse(startNumber).ToString();
            string number = "";
            for (int j = 0; j < startNumber.Length; j++)
            {
                if (startNumber[j] >= '0' && startNumber[j] <= '9')
                {
                    number += startNumber[j].ToString();
                }
            }
            for (int j = 0; j < number.Length; j++)
            {
                if (number.Length % 2 == 0)
                {
                    if (j < number.Length / 2)
                    {
                        beersM += int.Parse(number[j].ToString());
                    }
                    else
                    {
                        beersV += int.Parse(number[j].ToString());
                    }
                }
                else
                {
                    if (j < number.Length / 2)
                    {
                        beersM += int.Parse(number[j].ToString());
                    }
                    else if (j > number.Length / 2)
                    {
                        beersV += int.Parse(number[j].ToString());
                    }
                    else
                    {
                        beersM += int.Parse(number[j].ToString());
                        beersV += int.Parse(number[j].ToString());
                    }
                }
            }
        }
        if (beersV > beersM)
        {
            Console.WriteLine("V {0}", beersV - beersM);
        }
        else if (beersM > beersV )
        {
            Console.WriteLine("M {0}", beersM - beersV);
        }
        else
        {
            Console.WriteLine("No {0}", beersV + beersM);
        }
    }
}

