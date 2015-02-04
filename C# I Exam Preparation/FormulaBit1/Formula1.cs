using System;
using System.IO;

class Formula1
{
    static void Main()
    {
        //StreamReader reader = new StreamReader("..\\..\\sample-input.txt");
        //Console.SetIn(reader);

        string[] numbers = new string[8];
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = Convert.ToString(Convert.ToInt32(Console.ReadLine()), 2).PadLeft(8, '0');
        }
        int length = 0;
        int turnsCount = 0;
        int col = 7;
        int row = 0;
        string direction = "south";
        string lastDirection = "south";
        while (true)
        {
            if (numbers[0][7] == '1')
            {
                break;
            }
            if (col == 0 && row == 7)
            {
                length++;
                break;
            }
            else if (numbers[row][col] == '1')
            {
                break;
            }
            if (direction == "south")
            {
                if (numbers[row][col] == '0')
                {
                    if (row < 7)
                    {
                        if (numbers[row + 1][col] == '0')
                        {
                            row++;
                        }
                        else if (numbers[row + 1][col] == '1')
                        {
                            direction = "west";
                            if (col > 0)
                            {
                                turnsCount++;
                                col--;
                            }
                        }
                    }
                    else if (row == 7)
                    {
                        direction = "west";
                        if (col > 0)
                        {
                            turnsCount++;
                            col--;
                        }
                    }
                }
            }
            else if (direction == "west")
            {
                if (col > 0)
                {
                    if (numbers[row][col] == '0')
                    {
                        if (numbers[row][col - 1] == '0')
                        {
                            col--;
                        }
                        else if (numbers[row][col - 1] == '1')
                        {
                            if (lastDirection == "north")
                            {
                                direction = "south";
                                lastDirection = "south";
                                if (row < 7)
                                {
                                    row++;
                                }
                            }
                            else if (lastDirection == "south")
                            {
                                direction = "north";
                                lastDirection = "north";
                                if (row > 0)
                                {
                                    row--;
                                }
                            }
                            turnsCount++;
                        }
                    }
                }
                else if (col == 0)
                {
                    if (lastDirection == "north" )
                    {
                        direction = "south";
                        lastDirection = "south";
                        if (row < 7)
                        {
                            row++;
                        }
                    }
                    else if (lastDirection == "south")
                    {
                        direction = "north";
                        lastDirection = "north";
                        if (row > 0)
                        {
                            row--;
                        }
                    }
                    turnsCount++;
                }
            }
            else if (direction == "north")
            {
                if (numbers[row][col] == '0')
                {
                    if (row > 0)
                    {
                        if (numbers[row - 1][col] == '0')
                        {
                            row--;
                        }
                        else if (numbers[row - 1][col] == '1')
                        {
                            direction = "west";
                            turnsCount++;
                            if (col > 0)
                            {
                                col--;
                            }
                        }
                    }
                    else if (row == 0)
                    {
                        direction = "west";
                        turnsCount++;
                        if (col > 0)
                        {
                            col--;
                        }
                        else
                        {
                            length++;
                            break;
                        }
                    }
                }
            }
        length++;
        }
        if (col == 0 && row == 7)
        {
            Console.WriteLine("{0} {1}", length, turnsCount);
        }
        else
        {
            Console.WriteLine("{0} {1}", "No", length);
        }
    }
}
