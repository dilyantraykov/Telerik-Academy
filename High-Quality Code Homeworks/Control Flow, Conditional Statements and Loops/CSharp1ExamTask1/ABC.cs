namespace CSharp1ExamTask1
{
    using System;

    class ABC
    {
        static void Main()
        {
            long A = long.Parse(Console.ReadLine());
            long B = long.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());

            long bigger = Math.Max(A, B);
            long biggest = Math.Max(bigger, C);

            long smaller = Math.Min(A, B);
            long smallest = Math.Min(smaller, C);

            double mean = (double)(A + B + C) / 3;

            Console.WriteLine("{0}", biggest);
            Console.WriteLine("{0}", smallest);
            Console.WriteLine("{0:F3}", mean);
        }
    }
}
