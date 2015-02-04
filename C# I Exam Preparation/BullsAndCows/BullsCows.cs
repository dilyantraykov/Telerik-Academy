using System;

class BullsCows
{
    static void Main()
    {
        string N = Console.ReadLine();
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1000; i <= 9999; i++)
        {
            int bullCounter = 0;
            int cowCounter = 0;
            char[] number = new char[4];
            char[] digits = new char[4];
            bool flag = false;
            for (int k = 0; k < 4; k++)
            {
                if (i.ToString()[k] != '0')
                {
                    digits[k] = i.ToString()[k];
                }
                else
                {
                    flag = true;
                }
                number[k] = N.ToString()[k];
            }
            if (flag)
            {
                continue;
            }
            for (int j = 0; j < 4; j++)
            {
                if (number[j] == digits[j])
                {
                    bullCounter++;
                    number[j] = 'x';
                    digits[j] = 'y';
                }
            }
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (number[j] == digits[k])
                    {
                        cowCounter++;
                        number[j] = 'x';
                        digits[k] = 'y';
                        //found = true;
                    }
                }
            }

            if (bullCounter == bulls && cowCounter == cows)
            {
                Console.Write(i + " ");
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}

