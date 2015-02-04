using System;

class Page
{
    static void Main()
    {
        int[,] tray = new int[16,16];
        for (int i = 0; i < 16; i++)
        {
            string str = Console.ReadLine();
            for (int j = 0; j < 16; j++)
            {
                tray[i, j] = int.Parse(str[j].ToString());
            }
        }
        double totalSum = 0;
        while(true)
        {
            string action = Console.ReadLine();
            if (action == "what is" || action == "buy")
            {
                byte x = byte.Parse(Console.ReadLine());
                byte y = byte.Parse(Console.ReadLine());
                if (tray[x, y] != 1)
                {
                    Console.WriteLine("smile");
                }
                else if (tray[x, y] == 1)
                {
                    int count = 0;
                    if (x > 0 && x < 15 && y > 0 && y < 15)
                    {
                        for (int i = -1; i < 2; i++)
                        {
                            for (int j = -1; j < 2; j++)
                            {
                                if (tray[x + i, y + j] == 1)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                    else if (x == 0 && y == 0)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (tray[x + i, y + j] == 1)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                    else if (x == 15 && y == 15)
                    {
                        for (int i = -1; i < 1; i++)
                        {
                            for (int j = -1; j < 1; j++)
                            {
                                if (tray[x + i, y + j] == 1)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                    else if (x == 0 && y == 15)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = -1; j < 1; j++)
                            {
                                if (tray[x + i, y + j] == 1)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                    else if (x == 15 && y == 0)
                    {
                        for (int i = -1; i < 1; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (tray[x + i, y + j] == 1)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                    else if (x==0)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = -1; j < 2; j++)
                            {
                                if (tray[x + i, y + j] == 1)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                    else if (y == 0)
                    {
                        for (int i = -1; i < 2; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (tray[x + i, y + j] == 1)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                    else if (x == 15)
                    {
                        for (int i = -1; i < 1; i++)
                        {
                            for (int j = -1; j < 2; j++)
                            {
                                if (tray[x + i, y + j] == 1)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                    else if (y == 15)
                    {
                        for (int i = -1; i < 2; i++)
                        {
                            for (int j = -1; j < 1; j++)
                            {
                                if (tray[x + i, y + j] == 1)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                    if (count == 9)
                    {
                        if (action == "what is")
                        {
                            Console.WriteLine("cookie");
                        }
                        else
                        {
                            for (int i = -1; i < 2; i++)
                            {
                                for (int j = -1; j < 2; j++)
                                {
                                    tray[x + i, y + j] = 0;
                                }
                            }
                            totalSum += 1.79;
                        }
                    }
                    else if (count == 1)
                    {
                        if (action == "buy")
                        {
                            Console.WriteLine("page");
                        }
                        else
                        {
                            Console.WriteLine("cookie crumb");
                        }
                    }
                    else
                    {
                        if (action == "buy")
                        {
                            Console.WriteLine("page");
                        }
                        else
                        {
                            Console.WriteLine("broken cookie");
                        }
                    }
                }
            }
            else if (action == "paypal")
            {
                break;
            }
        }
        Console.WriteLine("{0:F2}", totalSum);
    }
}
