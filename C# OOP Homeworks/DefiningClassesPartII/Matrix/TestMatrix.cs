namespace Matrix
{
    using System;

    class TestMatrix
    {
        static void Main()
        {
            var matrix1 = new Matrix<int>(2, 2, new[] { 122, 12, 3333, 54 });
            Console.WriteLine("Matrix 1: ");
            Console.WriteLine(matrix1);

            Console.WriteLine();

            var matrix2 = new Matrix<int>(2, 2, new[] { 2, 3, 4, 5 });
            Console.WriteLine("Matrix 2: ");
            Console.WriteLine(matrix2);

            Console.WriteLine();

            Console.WriteLine("Addition: ");
            var addition = matrix1 + matrix2;
            Console.WriteLine(addition);

            Console.WriteLine();

            Console.WriteLine("Substraction: ");
            var substraction = matrix1 - matrix2;
            Console.WriteLine(substraction);

            Console.WriteLine();

            Console.WriteLine("Multiplication: ");
            var multiplication = matrix1 * matrix2;
            Console.WriteLine(multiplication);
        }
    }
}
