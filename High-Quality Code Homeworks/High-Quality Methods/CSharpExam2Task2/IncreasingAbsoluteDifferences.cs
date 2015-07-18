namespace CSharpExam2Task2
{
    using System;
    using System.Linq;

    public class IncreasingAbsoluteDifferences
    {
        public static void Main()
        {
            int numberOfSequences = int.Parse(Console.ReadLine());
            var sequences = new string[numberOfSequences];

            for (int i = 0; i < numberOfSequences; i++)
            {
                sequences[i] = Console.ReadLine();
            }

            foreach (var sequence in sequences)
            {
                var sequenceAsArray = sequence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
                Console.WriteLine(IsAbsoluteSequence(sequenceAsArray));
            }
        }

        private static long FindAbsoluteDifference(long firstNumber, long secondNumber)
        {
            long larger = Math.Max(firstNumber, secondNumber);
            long smaller = Math.Min(firstNumber, secondNumber);
            return larger - smaller;
        }

        private static bool IsAbsoluteSequence(long[] sequence)
        {
            for (int i = 0; i < sequence.Length - 2; i++)
            {
                var firstAbsoluteDifference = FindAbsoluteDifference(sequence[i], sequence[i + 1]);
                var secondAbsoluteDifference = FindAbsoluteDifference(sequence[i + 1], sequence[i + 2]);

                if (firstAbsoluteDifference != secondAbsoluteDifference &&
                    firstAbsoluteDifference != secondAbsoluteDifference - 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
