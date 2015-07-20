namespace CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class CompareMethods
    {
        public static TimeSpan GetAverageTimeSpan(List<TimeSpan> timespans)
        {
            double doubleAverageTicks = timespans.Average(timeSpan => timeSpan.Ticks);
            long longAverageTicks = Convert.ToInt64(doubleAverageTicks);

            return new TimeSpan(longAverageTicks);
        }

        public static void DisplayExecutionTime(Action action)
        {
            var stopwatches = new List<TimeSpan>();

            // increase times to reduce variance (results in a slower execution)
            for (var times = 0; times < 10; times++)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (var i = 0; i < 100000; i++)
                {
                    action();
                }

                stopwatch.Stop();
                stopwatches.Add(stopwatch.Elapsed);
            }

            Console.WriteLine(GetAverageTimeSpan(stopwatches));
        }

        public static void CompareSimpleMathsForType<T>(string type, T param1, T param2)
        {
            dynamic result = 0;
            Console.Write((type + " addition:").PadRight(30));
            DisplayExecutionTime(() =>
            {
                result = (dynamic)param1 + param2;
            });

            Console.Write((type + " subtraction:").PadRight(30));
            DisplayExecutionTime(() =>
            {
                result = (dynamic)param1 - param2;
            });

            Console.Write((type + " multiplication:").PadRight(30));
            DisplayExecutionTime(() =>
            {
                result = (dynamic)param1 * param2;
            });

            Console.Write((type + " division:").PadRight(30));
            DisplayExecutionTime(() =>
            {
                result = (dynamic)param1 + param2;
            });

            Console.Write((type + " incrementation:").PadRight(30));
            DisplayExecutionTime(() =>
            {
                result = (dynamic)param1;
                result++;
            });
        }

        public static void CompareAdvancedMathsForType<T>(string type, T param)
        {
            dynamic result = 0;
            Console.Write((type + " square root:").PadRight(30));
            DisplayExecutionTime(() =>
            {
                result = Math.Sqrt((dynamic)param);
            });

            Console.Write((type + " natural logarithm:").PadRight(30));
            DisplayExecutionTime(() =>
            {
                result = Math.Log((dynamic)param);
            });

            Console.Write((type + " sinus:").PadRight(30));
            DisplayExecutionTime(() =>
            {
                result = Math.Sin((dynamic)param);
            });
        }

        public static void CompareSortingAlgorithms<T>(string type, T[] arr) 
            where T : IComparable
        {
            Console.Write((type + " insertion sort:").PadRight(45));
            DisplayExecutionTime(() =>
            {
                SortingAlgorithms.PerformInsertionSort(arr);
            });

            Console.Write((type + " selection sort:").PadRight(45));
            DisplayExecutionTime(() =>
            {
                SortingAlgorithms.PerformSelectionSort(arr);
            });

            Console.Write((type + " quicksort:").PadRight(45));
            DisplayExecutionTime(() =>
            {
                SortingAlgorithms.PerformQuickSort(arr, 0, arr.Length - 1);
            });
        }

        public static void Main()
        {
            // Simple Math Tests
            Console.WriteLine("Simple Math Tests");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine();

            CompareSimpleMathsForType("Int", 2, 1);
            Console.WriteLine();

            CompareSimpleMathsForType("Long", 2L, 5L);
            Console.WriteLine();

            CompareSimpleMathsForType("Float", 2.4f, 1.3f);
            Console.WriteLine();

            CompareSimpleMathsForType("Double", 2.4, 1.3);
            Console.WriteLine();

            CompareSimpleMathsForType("Decimal", 2.4m, 1.3m);
            Console.WriteLine();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine();

            // Advanced Math Tests
            Console.WriteLine("Advanced Math Tests");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine();

            CompareAdvancedMathsForType("Long", 2L);
            Console.WriteLine();

            CompareAdvancedMathsForType("Float", 2.4f);
            Console.WriteLine();

            CompareAdvancedMathsForType("Double", 2.4);
            Console.WriteLine();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine();

            // Sorting Algorithms
            Console.WriteLine("Sort Algorithms Tests:");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine();

            int[] intRandom = { 5, 8, 1, 2, 16, -5, 2 };
            int[] intSorted = { -5, 1, 2, 2, 5, 8, 16 };
            int[] intSortedReverse = { 16, 8, 5, 2, 2, 1, -5 };

            CompareSortingAlgorithms("Int random values", intRandom);
            Console.WriteLine(new string('-', 50));
            CompareSortingAlgorithms("Int sorted values", intSorted);
            Console.WriteLine(new string('-', 50));
            CompareSortingAlgorithms("Int sorted values reverse", intSortedReverse);

            Console.WriteLine();
            Console.WriteLine();

            double[] doubleRandom = { 5, 8, 1, 2, 16, -5, 2 };
            double[] doubleSorted = { -5, 1, 2, 2, 5, 8, 16 };
            double[] doubleSoredReverse = { 16, 8, 5, 2, 2, 1, -5 };

            CompareSortingAlgorithms("Double random values", doubleRandom);
            Console.WriteLine(new string('-', 50));
            CompareSortingAlgorithms("Double sorted values", doubleSorted);
            Console.WriteLine(new string('-', 50));
            CompareSortingAlgorithms("Double sorted values reverse", doubleSoredReverse);

            Console.WriteLine();
            Console.WriteLine();

            char[] stringRandom = "fdebca".ToCharArray();
            char[] stringSorted = "abcdef".ToCharArray();
            char[] stringSoredReverse = "fedcba".ToCharArray();

            CompareSortingAlgorithms("String random values", stringRandom);
            Console.WriteLine(new string('-', 50));
            CompareSortingAlgorithms("String sorted values", stringSorted);
            Console.WriteLine(new string('-', 50));
            CompareSortingAlgorithms("String sorted values reverse", stringSoredReverse);
        }
    }
}
