// Problem 12.** Falling Rocks

// Implement the "Falling Rocks" game in the text console.
// A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
// A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
// Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
// Ensure a constant game speed by Thread.Sleep(150).
// Implement collision detection and scoring system.

using System;
using System.Collections.Generic;
using System.Threading;

struct Object
{
    public int x;
    public int y;
    public int length;
    public char c;
    public ConsoleColor color;
}

class Rocks
{
    // some constants
    const int HEIGHT = 20;
    const int WIDTH = 50;
    const int FIELDWIDTH = WIDTH / 2;
    const int LIFES = 3;
    const int STARTSPEED = 150;

    // how to print an object on the console
    static void PrintOnPosition(int x, int y, char c, int length, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        for (int i = 0; i < length; i++)
        {
            Console.Write(c);
        }
    }

    // how to print text on the console
    static void PrintStringOnPosition(int x, int y, string str,
        ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(str);
    }
    static void Main()
    {
        Console.Title = "Falling Rocks by Dilyan Traykov";
        Console.BufferHeight = Console.WindowHeight = HEIGHT;
        Console.BufferWidth = Console.WindowWidth = WIDTH;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to the Falling Rocks game\nmade by Dilyan Traykov.\n");
        Console.WriteLine("You are the little white dwarf (0)\nat the bottom of the screen");
        Console.WriteLine("and your goal is not to get hit by\nany of the falling rocks (symbols).\n");
        Console.WriteLine("You can move your dwarf left or right with the\narrow keys and you can press enter at any time\nto exit the game.");
        Console.WriteLine("\nAre you ready? Press any key to start...\n\nGood luck!");
        Console.ReadLine();

        // some useful variables
        int fieldWidth = FIELDWIDTH;
        int livesCount = LIFES;
        double score = 0;
        double speed = 150;
        bool quit = false;
        Random randomGenerator = new Random();
        char[] symbols = new char[] {'^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-'};
        ConsoleColor[] colors = { ConsoleColor.Cyan, ConsoleColor.Magenta, ConsoleColor.Green, ConsoleColor.Yellow };
        List<Object> rocks = new List<Object>();

        // dwarf initialization
        Object userDwarf = new Object();
        userDwarf.x = randomGenerator.Next(0, fieldWidth-1);
        userDwarf.y = Console.WindowHeight - 1;
        userDwarf.length = 1; 
        userDwarf.c = '0';
        userDwarf.color = ConsoleColor.White;

        // start the main loop
        while (true)
        {
            // make sure game doesn't become too fast
            if (speed >= 300)
            {
                speed = 300;
            }
            bool hit = false;

            // create brand new rocks and add them to to rock list
            Object brandNewRock = new Object();
            brandNewRock.color = colors[randomGenerator.Next(0, 4)];
            brandNewRock.x = randomGenerator.Next(0, fieldWidth);
            brandNewRock.y = 0;
            brandNewRock.length = randomGenerator.Next(1,4);
            brandNewRock.c = symbols[randomGenerator.Next(1, 12)];
            rocks.Add(brandNewRock);

            // constantly check for a keypress
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.Enter)
                {
                    quit = true;
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userDwarf.x - 1 >= 0)
                    {
                        userDwarf.x = userDwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (userDwarf.x < fieldWidth)
                    {
                        userDwarf.x = userDwarf.x + 1;
                    }
                }
            }

            // get all the rocks and check for collision
            List<Object> newList = new List<Object>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Object oldRock = rocks[i];
                Object newRock = new Object();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.length = oldRock.length;
                newRock.c = oldRock.c;
                newRock.color = oldRock.color;
                if (newRock.y == userDwarf.y && (newRock.x <= userDwarf.x) && ((newRock.x + newRock.length - 1) >= userDwarf.x))
                {
                    livesCount--;
                    score -= score / 10;
                    hit = true;
                    speed -= speed / 10;
                }
                // check if game's over
                if (livesCount <= 0 || quit)
                {
                    Console.Clear();
                    PrintStringOnPosition(WIDTH - 22, 6, "Thanks for playing!");
                    PrintStringOnPosition(WIDTH - 22, 8, "You scored " + Math.Round(score, 0));
                    PrintStringOnPosition(WIDTH - 22, 10, "Well done!");
                    PrintStringOnPosition(WIDTH - 22, HEIGHT - 4, "GAME OVER", ConsoleColor.Red);
                    PrintStringOnPosition(WIDTH - 22, HEIGHT - 2, "Press [enter] to exit", ConsoleColor.Red);
                    Console.ReadLine();
                    return;
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
            }
            rocks = newList;
            // refresh the screen
            Console.Clear();
            // restart game if hit
            if (hit)
            {
                rocks.Clear();
                PrintOnPosition(userDwarf.x, userDwarf.y, 'X', 1, ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(userDwarf.x, userDwarf.y, userDwarf.c, userDwarf.length, userDwarf.color);
                score += speed / 100;
                speed += 0.2;
            }
            // print all the rocks
            foreach (Object obj in rocks)
            {
                PrintOnPosition(obj.x, obj.y, obj.c, obj.length, obj.color);
            }
            // the info screen
            PrintStringOnPosition(WIDTH - 22, 1, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(WIDTH - 22, 3, "Score: " + Math.Round(score, 0), ConsoleColor.White);
            PrintStringOnPosition(WIDTH - 22, 5, "Speed: " + Math.Round(speed, 0), ConsoleColor.White);
            PrintStringOnPosition(WIDTH - 22, HEIGHT - 2, "Press [enter] to exit", ConsoleColor.Gray);
            // control game speed
            Thread.Sleep(350 - (int)speed);
        }
    }
}

