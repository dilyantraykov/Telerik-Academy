namespace RefactoredLoop
{
    using System;

    public class Loop
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            var expectedValue = 9;

            int i = 0;
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                if (array[i] == expectedValue)
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }

            if (i == array.Length)
            {
                Console.WriteLine("Value not found!");
            }
        }
    }
}
