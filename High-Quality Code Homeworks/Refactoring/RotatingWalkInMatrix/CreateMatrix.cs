namespace Matrix
{
    using System;

    internal class CreateMatrix
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert number of rows for the matrix: ");
            var n = int.Parse(Console.ReadLine());
            var matrix = new Matrix(n);
            Console.WriteLine(matrix);
        }
    }
}