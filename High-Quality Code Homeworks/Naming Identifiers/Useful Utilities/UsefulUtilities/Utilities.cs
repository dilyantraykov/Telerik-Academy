namespace UsefulUtilities
{
    using System;

    public class Utilities
    {
        public const int MaxCount = 6;

        public class PrintMethods
        {
            public static void PrintBoolAsString(bool boolVariable)
            {
                string boolToString = boolVariable.ToString();
                Console.WriteLine(boolToString);
            }
        }

        public static void Main()
        {
            Utilities.PrintMethods.PrintBoolAsString(true);
        }
    }
}
