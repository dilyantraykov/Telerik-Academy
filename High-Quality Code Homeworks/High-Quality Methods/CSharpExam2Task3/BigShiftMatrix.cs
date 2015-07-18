namespace CSharpExam2Task3
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class BigShiftMatrix
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int numberOfMoves = int.Parse(Console.ReadLine());
            int[] codes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var matrix = new BigInteger[rows, cols];

            var targetRow = new int[numberOfMoves];
            var targetCol = new int[numberOfMoves];

            FillMatrix(matrix);

            BigInteger totalSum = 1;
            int currentRow = rows - 1;
            int currentCol = 0;
            matrix[currentRow, currentCol] = 0;

            for (int i = 0; i < numberOfMoves; i++)
            {
                int coeff = Math.Max(rows, cols);
                targetRow[i] = codes[i] / coeff;
                targetCol[i] = codes[i] % coeff;

                totalSum += GetRouteSum(matrix, currentRow, currentCol, targetRow[i], targetCol[i]);

                currentRow = targetRow[i];
                currentCol = targetCol[i];
            }

            Console.WriteLine(totalSum);
        }

        private static void FillMatrix(BigInteger[,] matrix)
        {
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);

            matrix[rows - 1, 0] = 1;

            for (int i = rows - 2; i >= 0; i--)
            {
                matrix[i, 0] = matrix[i + 1, 0] * 2;
            }

            for (int i = 1; i < cols; i++)
            {
                matrix[rows - 1, i] = matrix[rows - 1, i - 1] * 2;
            }

            for (int row = rows - 2; row >= 0; row--)
            {
                for (int col = 1; col < cols; col++)
                {
                    matrix[row, col] = matrix[row + 1, col] + matrix[row, col - 1];
                }
            }
        }

        private static BigInteger GetRouteSum(BigInteger[,] matrix, int currentRow, int currentCol, int targetRow, int targetCol)
        {
            BigInteger totalSum = 0;

            while (currentRow != targetRow || currentCol != targetCol)
            {
                if (targetCol > currentCol)
                {
                    currentCol++;
                }
                else if (targetCol < currentCol)
                {
                    currentCol--;
                }
                else if (targetRow > currentRow)
                {
                    currentRow++;
                }
                else if (targetRow < currentRow)
                {
                    currentRow--;
                }

                totalSum += matrix[currentRow, currentCol];
                matrix[currentRow, currentCol] = 0;
            }

            return totalSum;
        }
    }
}
