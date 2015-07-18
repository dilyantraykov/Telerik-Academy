namespace Methods
{
    using System;

    public class Methods
    {
        internal static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        internal static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid number!");
            }
        }

        internal static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("No elements passed!");
            }

            int maxElement = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        internal static void PrintAsRoundedNumber(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        internal static void PrintAsPercent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        internal static void PrintRightAligned(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        internal static double CalcDistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            var deltaX = (x2 - x1) * (x2 - x1);
            var deltaY = (y2 - y1) * (y2 - y1);

            double distance = Math.Sqrt(deltaX + deltaY);

            return distance;
        }

        internal static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsRoundedNumber(1.3);
            PrintAsPercent(0.75);
            PrintRightAligned(2.30);

            Console.WriteLine(CalcDistanceBetweenPoints(3, -1, 3, 2.5));

            Student peter = new Student("Peter", "Ivanov", DateTime.Parse("17.03.1992"), "Sofia");
            Student stella = new Student("Stella", "Markova", DateTime.Parse("03.11.1993"), "Vidin");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
