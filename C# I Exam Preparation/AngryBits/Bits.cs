using System;
using System.IO;

class Bits
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\sample-input.txt");
        Console.SetIn(reader);

        string[] numbers = new string[8];
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = Convert.ToString(Convert.ToInt64(Console.ReadLine()), 2).PadLeft(16, '0');
        }
        int[,] field = new int[8, 16];
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 16; j++)
            {
                field[i, j] = int.Parse(numbers[i][j].ToString());
            }
        }
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 16; j++)
            {
                Console.Write(field[i, j]);
            }
            Console.WriteLine();
        }
        long score = 0;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (field[i, j] == 1)
                {
                    //Console.WriteLine(i + " " + j);
                    int flightLength = 0;
                    int pigsKilled = 0;
                    int currentRow = i;
                    int currentCol = j;
                    string direction = "up";
                    while (true)
                    {
                        if (currentRow == 0)
                        {
                            direction = "down";
                        }

                        //Console.WriteLine(currentRow + " " + currentCol);

                        if (currentCol > 7 && field[currentRow, currentCol] == 1)
                        {
                            if (currentCol == 15 && currentRow == 7)
                            {
                                for (int k = currentRow - 1; k < currentRow + 1; k++)
                                {
                                    for (int l = currentCol - 1; l < currentCol + 1; l++)
                                    {
                                        if (field[k, l] == 1)
                                        {
                                            pigsKilled++;
                                            field[k, l] = 0;
                                        }
                                    }
                                }
                            }
                            else if (currentCol == 15)
                            {
                                for (int k = currentRow - 1; k < currentRow + 2; k++)
                                {
                                    for (int l = currentCol - 1; l < currentCol + 1; l++)
                                    {
                                        if (field[k, l] == 1)
                                        {
                                            pigsKilled++;
                                            field[k, l] = 0;
                                        }
                                    }
                                }
                            }
                            else if (currentRow == 0 && currentCol == 8)
                            {
                                for (int k = currentRow; k < currentRow + 2; k++)
                                {
                                    for (int l = currentCol; l < currentCol + 2; l++)
                                    {
                                        if (field[k, l] == 1)
                                        {
                                            pigsKilled++;
                                            field[k, l] = 0;
                                        }
                                    }
                                }
                            }
                            else if (currentRow == 7 && currentCol == 8)
                            {
                                for (int k = currentRow - 1; k < currentRow + 1; k++)
                                {
                                    for (int l = currentCol; l < currentCol + 2; l++)
                                    {
                                        if (field[k, l] == 1)
                                        {
                                            pigsKilled++;
                                            field[k, l] = 0;
                                        }
                                    }
                                }
                            }
                            else if (currentRow == 7)
                            {
                                for (int k = currentRow - 1; k < currentRow + 1; k++)
                                {
                                    for (int l = currentCol - 1; l < currentCol + 2; l++)
                                    {
                                        if (field[k, l] == 1)
                                        {
                                            pigsKilled++;
                                            field[k, l] = 0;
                                        }
                                    }
                                }
                            }
                            else if (currentRow == 0)
                            {
                                for (int k = currentRow; k < currentRow + 2; k++)
                                {
                                    for (int l = currentCol - 1; l < currentCol + 2; l++)
                                    {
                                        if (field[k, l] == 1)
                                        {
                                            pigsKilled++;
                                            field[k, l] = 0;
                                        }
                                    }
                                }
                            }
                            else if (currentCol == 8)
                            {
                                for (int k = currentRow - 1; k < currentRow + 2; k++)
                                {
                                    for (int l = currentCol; l < currentCol + 2; l++)
                                    {
                                        if (field[k, l] == 1)
                                        {
                                            pigsKilled++;
                                            field[k, l] = 0;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                for (int k = currentRow - 1; k < currentRow + 2; k++)
                                {
                                    for (int l = currentCol - 1; l < currentCol + 2; l++)
                                    {
                                        if (field[k, l] == 1)
                                        {
                                            pigsKilled++;
                                            field[k, l] = 0;
                                        }
                                    }
                                }
                            }
                            //flightLength++;
                            score += flightLength * pigsKilled;
                            field[i, j] = 0;
                            //Console.WriteLine(flightLength + " " + score);
                            break;
                        }

                        if (currentCol == 15)
                        {

                            break;
                        }


                        if (currentCol >= 7 && currentRow == 7 && i != 7 && j != 7)
                        {

                            field[i, j] = 0;
                            break;
                        }

                        if (direction == "up")
                        {

                            flightLength++;
                            currentCol++;
                            currentRow--;
                        }
                        else if (direction == "down")
                        {

                            flightLength++;
                            currentRow++;
                            currentCol++;
                        }
                    }
                }
            }
        }
        Console.WriteLine();
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 16; j++)
            {
                Console.Write(field[i, j]);
            }
            Console.WriteLine();
        }
        bool allPigsKilled = true;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 8; j < 16; j++)
            {
                if (field[i, j] == 1)
                {
                    allPigsKilled = false;
                }
            }
        }
        Console.WriteLine(score + " " + (allPigsKilled ? "Yes" : "No"));
    }
}
