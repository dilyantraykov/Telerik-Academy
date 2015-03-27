using System;

namespace BitArray
{
    class TestBitArray
    {
        public static void Main()
        {
            var number1 = new BitArray(22L);
            var number2 = new BitArray(33L);

            number2[62] = 1;

            Console.WriteLine("number2[62] = {0}", number2[62]);
            Console.WriteLine();

            foreach (var bit in number1)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            Console.WriteLine(number2);

            Console.WriteLine();

            Console.WriteLine(number1.GetHashCode());
            Console.WriteLine(number2.GetHashCode());

            Console.WriteLine();

            Console.WriteLine("number1 == number2 : {0}", number1 == number2);
            Console.WriteLine("number1 != number2 : {0}", number1 != number2);
            Console.WriteLine("number1.Equals(number1) : {0}", number1.Equals(number1));
            Console.WriteLine("number1.Equals(number2) : {0}", number1.Equals(number2));
        }
    }
}
