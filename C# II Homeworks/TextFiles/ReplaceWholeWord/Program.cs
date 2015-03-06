/*
Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words (not strings).
*/

using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var writer = new StreamWriter("../../input.txt");
        for (int i = 0; i < 10000000; i++) // makes a ~230 MB file - ensure you have enough space
        {
            writer.Write("From start to finish...");
        }
        writer.Close();

        var reader = new StreamReader("../../input.txt");
        string text = reader.ReadToEnd();
        text = Regex.Replace(text, @"\bstart\b", "finish");
        reader.Close();

        var rewriter = new StreamWriter("../../input.txt");
        rewriter.Write(text);
        rewriter.Close();
    }
}
