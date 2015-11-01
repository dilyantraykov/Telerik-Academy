namespace FindFirstMembersOfSequence
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 9. We are given the following sequence:
    /// S1 = N; 2
    /// S2 = S1 + 1; 3
    /// S3 = 2* S1 + 1; 5
    /// S4 = S1 + 2; 4
    /// S5 = S2 + 1; 4
    /// S6 = 2* S2 + 1; 7
    /// S7 = S2 + 2; 5
    /// ...
    /// Using the Queue<T> class write a program to print its first 50 members for given N.
    /// Example: N= 2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var queue = new Queue<int>();
            var result = new List<int>();

            var s1 = int.Parse(input);
            queue.Enqueue(s1);
            
            for (int i = 0; i < 50; i++)
            {
                var mainNumber = queue.Dequeue();
                result.Add(mainNumber);

                queue.Enqueue(mainNumber + 1);
                queue.Enqueue((mainNumber * 2) + 1);
                queue.Enqueue(mainNumber + 2);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
