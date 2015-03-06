/*
Condition
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var S = Console.ReadLine();
        var lines = new List<string>();
        for (int i = 0; i < N; i++)
        {
            var line = Console.ReadLine().Trim();
            line = Regex.Replace(line, "[ ]+", " ");
            if (line != "")
            {
                lines.Add(line);
            }
        }
        int indentCount = 0;
        var outputString = "";
        foreach (var line in lines)
        {
            outputString += line;
        }
        outputString = Regex.Replace(outputString.ToString(), "{", "\n{");
        outputString = Regex.Replace(outputString.ToString(), "}", "\n}");
        Console.WriteLine(outputString.Trim());
    }
}
