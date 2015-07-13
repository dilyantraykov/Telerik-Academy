namespace CSharp1ExamTask4
{
    using System;

    public class ExRugs
    {
        public static void Main()
        {
            int heightAndWidthOfTheRug = int.Parse(Console.ReadLine());
            int sharpSymbolsWidth = int.Parse(Console.ReadLine());
            int width = (2 * heightAndWidthOfTheRug) + 1;
            int numberOfOutsideDots = 0;
            int numberOfSharpSymbols = 1 + (sharpSymbolsWidth / 2);
            int numberOfInsideDots = width - (numberOfSharpSymbols * 2) - 2;

            if (sharpSymbolsWidth == width - 2)
            {
                for (int i = 0; i < width; i++)
                {
                    if (i == width / 2)
                    {
                        Console.Write('X');
                        Console.Write(new string('#', width - 2));
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write(new string('#', width / 2));

                        if (i == 0 || i == width - 1)
                        {
                            Console.Write('X');
                        }
                        else
                        {
                            Console.Write('#');
                        }

                        Console.Write(new string('#', width / 2));
                    }

                    Console.WriteLine();
                }
            }
            else if (sharpSymbolsWidth < width - 2)
            {
                for (int i = 0; i < width / 2; i++)
                {
                    if (numberOfOutsideDots > 0)
                    {
                        Console.Write(new string('.', numberOfOutsideDots - 1));
                        Console.Write('\\');
                    }

                    if (numberOfInsideDots > 0)
                    {
                        Console.Write(new string('#', numberOfSharpSymbols));
                        Console.Write('\\');
                        Console.Write(new string('.', numberOfInsideDots));
                        Console.Write('/');
                        Console.Write(new string('#', numberOfSharpSymbols));
                    }
                    else if (numberOfInsideDots == -1)
                    {
                        Console.Write(new string('#', numberOfSharpSymbols));
                        Console.Write(new string('X', Math.Abs(numberOfInsideDots)));
                        Console.Write(new string('#', numberOfSharpSymbols));
                    }
                    else
                    {
                        Console.Write(new string('#', numberOfSharpSymbols + numberOfInsideDots + 1));
                        Console.Write(new string('#', Math.Abs(numberOfInsideDots)));
                        Console.Write(new string('#', numberOfSharpSymbols + numberOfInsideDots + 1));
                    }

                    if (numberOfOutsideDots > 0)
                    {
                        Console.Write('/');
                        Console.Write(new string('.', numberOfOutsideDots - 1));
                    }

                    if (numberOfSharpSymbols < sharpSymbolsWidth)
                    {
                        numberOfSharpSymbols++;
                    }
                    else if (numberOfSharpSymbols >= sharpSymbolsWidth)
                    {
                        numberOfOutsideDots++;
                    }

                    numberOfInsideDots -= 2;
                    Console.WriteLine();
                }

                numberOfOutsideDots = (width - sharpSymbolsWidth - 2) / 2;
                Console.Write(new string('.', numberOfOutsideDots));
                Console.Write('X');
                Console.Write(new string('#', sharpSymbolsWidth));
                Console.Write('X');
                Console.WriteLine(new string('.', numberOfOutsideDots));

                numberOfOutsideDots = (width - sharpSymbolsWidth - 2) / 2;
                numberOfInsideDots = -sharpSymbolsWidth;
                numberOfSharpSymbols = sharpSymbolsWidth;
                for (int i = 0; i < width / 2; i++)
                {
                    if (numberOfOutsideDots > 0)
                    {
                        Console.Write(new string('.', numberOfOutsideDots - 1));
                        Console.Write('/');
                    }

                    if (numberOfInsideDots > 0)
                    {
                        if (numberOfOutsideDots < 0)
                        {
                            Console.Write(new string('#', numberOfSharpSymbols + numberOfOutsideDots));
                            Console.Write('/');
                            Console.Write(new string('.', numberOfInsideDots));
                            Console.Write('\\');
                            Console.Write(new string('#', numberOfSharpSymbols + numberOfOutsideDots));
                        }
                        else
                        {
                            Console.Write(new string('#', numberOfSharpSymbols));
                            Console.Write('/');
                            Console.Write(new string('.', numberOfInsideDots));
                            Console.Write('\\');
                            Console.Write(new string('#', numberOfSharpSymbols));
                        }
                    }
                    else if (numberOfInsideDots == -1 || numberOfInsideDots == -2)
                    {
                        if (numberOfOutsideDots >= 0)
                        {
                            Console.Write(new string('#', numberOfSharpSymbols));
                            Console.Write(new string('X', Math.Abs(numberOfInsideDots)));
                            Console.Write(new string('#', numberOfSharpSymbols));
                        }
                        else
                        {
                            Console.Write(new string('#', width / 2));
                            Console.Write('X');
                            Console.Write(new string('#', width / 2));
                        }
                    }
                    else
                    {
                        if (numberOfOutsideDots < 0)
                        {
                            Console.Write(new string('#', width));
                        }
                        else
                        {
                            Console.Write(new string('#', numberOfSharpSymbols + numberOfInsideDots + 1));
                            Console.Write(new string('#', Math.Abs(numberOfInsideDots)));
                            Console.Write(new string('#', numberOfSharpSymbols + numberOfInsideDots + 1));
                        }
                    }

                    if (numberOfOutsideDots > 0)
                    {
                        Console.Write('\\');
                        Console.Write(new string('.', numberOfOutsideDots - 1));
                    }

                    if (numberOfSharpSymbols < sharpSymbolsWidth)
                    {
                        numberOfSharpSymbols++;
                    }
                    else if (numberOfSharpSymbols >= sharpSymbolsWidth)
                    {
                        numberOfOutsideDots--;
                    }

                    numberOfInsideDots += 2;
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < width; i++)
                {
                    if (sharpSymbolsWidth == width - 2 && i == heightAndWidthOfTheRug)
                    {
                        Console.Write('X');
                        Console.Write(new string('#', width - 2));
                        Console.WriteLine('X');
                    }
                    else
                    {
                        Console.WriteLine(new string('#', width));
                    }
                }
            }
        }
    }
}
