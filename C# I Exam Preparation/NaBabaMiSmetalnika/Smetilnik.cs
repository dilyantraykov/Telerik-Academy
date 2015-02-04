using System;
using System.Numerics;

class Smetilnik
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        string[] line = new string[8];
        int[,] matrix = new int[8, width];
        for (int i = 0; i < 8; i++)
        {
            line[i] = Convert.ToString(long.Parse(Console.ReadLine()), 2).PadLeft(width, '0');
        }
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < width; j++)
            {
                matrix[i, j] = int.Parse(line[i][j].ToString());
            }
        }
        while (true)
        {
            string action = Console.ReadLine();
            if (action == "reset")
            {
                for (int i = 0; i < 8; i++)
                {
                    int count = 0;
                    for (int j = 0; j < width; j++)
                    {
                        if (matrix[i, j] == 1)
                        {
                            count++;
                        }
                    }
                    for (int j = 0; j < width; j++)
                    {
                        if (j < count)
                        {
                            matrix[i, j] = 1;
                        }
                        else
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }
            }
            else if (action == "left")
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    x = 0;
                }
                if (y < 0)
                {
                    y = 0;
                }
                if (x > 7)
                {
                    x = 7;
                }
                if (y > width - 1)
                {
                    y = width - 1;
                }
                int count = 0;
                for (int j = y; j >= 0; j--)
                {
                    if (matrix[x, j] == 1)
                    {
                        count++;
                    }
                }
                for (int j = 0; j <= y; j++)
                {
                    if (j < count)
                    {
                        matrix[x, j] = 1;
                    }
                    else
                    {
                        matrix[x, j] = 0;
                    }
                }
            }
            else if (action == "right")
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int count = 0;
                if (x < 0)
                {
                    x = 0;
                }
                if (y < 0)
                {
                    y = 0;
                }
                if (x > 7)
                {
                    x = 7;
                }
                if (y > width - 1)
                {
                    y =  width - 1;
                }
                for (int j = y; j < width; j++)
                {
                    if (matrix[x, j] == 1)
                    {
                        count++;
                    }
                }
                for (int j = width-1; j >= y; j--)
                {
                    if (j > width - 1 - count)
                    {
                        matrix[x, j] = 1;
                    }
                    else
                    {
                        matrix[x, j] = 0;
                    }
                }
            }
            else if (action == "stop")
            {
                BigInteger sum = 0;
                int multiplier = 0;
                string[] nums = new string[8];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        nums[i] += (matrix[i, j]);
                    }
                    sum += Convert.ToInt64(nums[i], 2);
                }
                for (int j = 0; j < width; j++)
                {
                    int columnSum = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        if (matrix[i, j] != 0)
                        {
                            columnSum++;
                        }
                    }
                    if (columnSum == 0)
                    {
                        multiplier++;
                    }
                }
                Console.WriteLine(sum*multiplier);
                break;
            }
        }
        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 0; j < width; j++)
        //    {
        //        Console.Write(matrix[i, j]);
        //    }
        //    Console.WriteLine();
        //}
    }
}

