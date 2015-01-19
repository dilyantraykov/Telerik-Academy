// Problem 2. Gravitation on the Moon

// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class MoonGravitation
{
    static void Main()
    {
        Console.WriteLine("Insert weight: ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine(weight * 17/100);
    }
}
