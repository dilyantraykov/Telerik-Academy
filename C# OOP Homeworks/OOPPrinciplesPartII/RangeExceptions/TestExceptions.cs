using System;

namespace RangeExceptions
{
    class TestExceptions
    {
        public const int startNumber = 1;
        public const int endNumber = 100;
        public const string startDate = "01.01.1980";
        public const string endDate = "31.12.2013";

        public static void Main()
        {
            Console.Write("Enter number between {0} and {1}: ", startNumber, endNumber);
            var inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber < startNumber || inputNumber > endNumber)
            {
                throw new InvalidRangeException<int>(startNumber, endNumber);
            }

            Console.Write("Enter date between {0} and {1}: ", startDate, endDate);
            var inputDate = DateTime.Parse(Console.ReadLine());
            if (inputDate.CompareTo(DateTime.Parse(startDate)) < 0 || inputDate.CompareTo(DateTime.Parse(endDate)) > 0)
            {
                throw new InvalidRangeException<DateTime>(DateTime.Parse(startDate), (DateTime.Parse(endDate)));
            }
        }
    }
}
