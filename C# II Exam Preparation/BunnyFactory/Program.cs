using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class Program
{
    static void Main()
    {
        //StreamReader reader = new StreamReader("..\\..\\sample-input.txt");
        //Console.SetIn(reader);


        List<int> cages = new List<int>();
        while(true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            else
            {
                cages.Add(int.Parse(input));
            }
        }
        int i = 1;
        while (true)
        {
            if (cages.Count < i)
            {
                break;
            }

            int sum1 = 0;
            int sum2 = 0;
            BigInteger product1 = 1;

            for (int j = 0; j < i; j++)
            {
                sum1 += cages[j];
            }

            if (cages.Count - sum1 < i)
            {
                break;
            }

            for (int j = i; j < i+sum1; j++)
            {
                sum2 += cages[j];
                product1 *= cages[j];
            }

            string next = sum2.ToString() + product1.ToString();
            for (int j = sum1 + i; j < cages.Count; j++)
            {
                next += cages[j].ToString();
            }

            cages.Clear();
            foreach (var letter in next)
            {
                int digit = int.Parse(letter.ToString());
                if (digit != 0 && digit != 1)
                {
                    cages.Add(digit);
                }
            }
            i++;
        }
        foreach (var item in cages)
        {
            Console.Write(item + " ");
        }
    }
}
