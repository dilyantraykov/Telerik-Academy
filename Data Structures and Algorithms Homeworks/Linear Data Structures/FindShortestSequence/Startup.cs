namespace FindShortestSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 10. We are given numbers N and M and the following operations:
    /// N = N+1
    /// N = N+2
    /// N = N*2
    /// Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
    /// Hint: use a queue.
    /// Example: N = 5, M = 16
    /// Sequence: 5 → 7 → 8 → 16
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            Console.Write("Input start number: ");
            var start = int.Parse(Console.ReadLine());

            Console.Write("Input end number: ");
            var end = int.Parse(Console.ReadLine());

            var sequence = new Queue<int>();

            while (start <= end)
            {
                sequence.Enqueue(end);

                if (end / 2 >= start)
                {
                    if (end % 2 == 0)
                    {
                        end /= 2;
                    }
                    else
                    {
                        end -= 1;
                    }
                }
                else
                {
                    if (end - 2 >= start)
                    {
                        end -= 2;
                    }
                    else
                    {
                        end -= 1;
                    }
                }
            }

            Console.WriteLine("Minimal number of steps: {0}", sequence.Count - 1);
            Console.WriteLine("Sequence: {0}", string.Join(" -> ", sequence.Reverse()));
        }
    }
}
