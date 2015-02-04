using System;

class Neuron
{
    static void Main()
    {
        string[] matrix = new string[32];
        int count = 0;
        for (int i = 0; i < 32; i++)
        {
            matrix[i] = Console.ReadLine();
            if (matrix[i] == "-1")
            {
                break;
            }
            matrix[i] = Convert.ToString(long.Parse(matrix[i]), 2).PadLeft(32, '0');
            count++;
        }
        int[,] neurons = new int[count,32];
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < 32; j++)
            {
            neurons[i, j] = int.Parse(matrix[i][j].ToString());
            }
        }
        int[] start = new int[count];
        int[] end = new int[count];
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                if (neurons[i, j] == 1)
                {
                    start[i] = j;
                    break;
                }
            }
            for (int j = 31; j >= 0; j--)
            {
                if (neurons[i, j] == 1)
                {
                    end[i] = j;
                    break;
                }
            }
        }
        for (int i = 0; i < count; i++)
        {
            for (int j = start[i]; j <= end[i]; j++)
            {
                if (start[i] != end[i])
                { 
                    if (neurons[i, j] == 1)
                    {
                        neurons[i, j] = 0;
                    }
                    else if (neurons[i, j] == 0)
                    {
                        neurons[i, j] = 1;
                    }
                }
            }
        }
        for (int i = 0; i < count; i++)
        {
            string sum = "";
            for (int j = 0; j < 32; j++)
            {
                sum += Convert.ToString(neurons[i, j]);
            }
            Console.WriteLine(Convert.ToInt32(sum, 2));
        }
    }
}
