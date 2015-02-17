using System;
using System.IO;

class Program
{
    static void Main()
    {
        //StreamReader reader = new StreamReader("..\\..\\sample-input.txt");
        //Console.SetIn(reader);

        char[] split = { ' ' };
        string[] input = Console.ReadLine().Split(split, StringSplitOptions.RemoveEmptyEntries);
        int L = int.Parse(Console.ReadLine());
        string[,] codeTable = new string[L,2];
        for (int i = 0; i < L; i++)
        {
            string temp = Console.ReadLine();
            codeTable[i, 0] = temp[0].ToString();
            for (int j = 1; j < temp.Length; j++)
            {
                codeTable[i, 1] += temp[j];
            }
        }

        string encodedText = "";
        for (int i = 0; i < input.Length; i++)
        {
            string tempNumber = Convert.ToString(int.Parse(input[i]), 2);
            int length = 0;
            if (tempNumber.Length % 8 == 0)
            {
                length = (tempNumber.Length / 8) * 8;
            }
            else
            {
                length = ((tempNumber.Length / 8) + 1) * 8;
            }
            encodedText += tempNumber.PadLeft(length, '0');
        }

        string[] finalText = encodedText.Split('0');

        for (int i = 0; i < L; i++)
        {
            string currentString = "";
            for (int j = int.Parse(codeTable[i, 1]); j > 0; j--)
			{
                currentString += "1";
			}
            for (int k = 0; k < finalText.Length; k++)
            {
                if (finalText[k] == currentString)
                {
                    finalText[k] = codeTable[i, 0];
                }
            }
        }

        foreach (var item in finalText)
        {
            Console.Write(item);
        }
    }
}
