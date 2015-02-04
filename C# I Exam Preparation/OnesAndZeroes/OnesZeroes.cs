using System;

class OnesZeroes
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        char[,] matrix = new char[5, 63];
        string bits = Convert.ToString(N, 2).PadLeft(16, '0');
        int currentCol = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 63; j++)
            {
                matrix[i,j] = '.';
            }
        }
        for (int i = 16; i > 0; i--)
        {
            if (bits[bits.Length - i] == '0')
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (!(k == 1 && j > 0 && j < 4))
                        {
                            matrix[j, currentCol + k] = '#';
                        }
                    }
                }
            }
            else if (bits[bits.Length - i] == '1')
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (!(k == 0 && j < 4 && j != 1) && !(k == 2 && j < 4))
                        {
                            matrix[j, currentCol + k] = '#';
                        }
                    }
                }
            }
            currentCol += 4;
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 63; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

