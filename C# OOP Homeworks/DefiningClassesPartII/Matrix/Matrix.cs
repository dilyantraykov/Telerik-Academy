using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Matrix
{
    public class Matrix<T>
        where T : IComparable
    {
        private int _rows;
        private int _cols;
        private T[,] _matrix;

        public int Rows
        {
            get { return this._rows; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rows should not be negative!");
                }
                this._rows = value;
            }
        }

        public int Cols
        {
            get { return this._cols; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cols should not be negative!");
                }
                this._cols = value;
            }
        }

        public Matrix(int rows = 0, int cols = 0, params T[] numbers)
        {
            this.Rows = rows;
            this.Cols = cols;
            this._matrix = new T[rows,cols];
            if (numbers.Length > 0 && numbers.Length != this.Rows * this.Cols)
            {
                throw new ArgumentException("Number of elements should equal the number of cells in the matrix!");
            }
            var number = 0;
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    this._matrix[i, j] = (numbers.Length > 0 ? numbers[number] : default(T));
                    number++;
                }
            }
        }

        public Matrix(int rows, int cols, T[,] numbers)
        {
            this.Rows = rows;
            this.Cols = cols;
            this._matrix = new T[rows, cols];
            if (numbers.GetLength(0) != this.Rows || numbers.GetLength(1) != this.Cols)
            {
                throw new ArgumentException("Number of elements should equal the number of cells in the matrix!");
            }
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    this._matrix[i, j] = numbers[i, j];
                }
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Rows) ||
                    (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                return this._matrix[row, col];
            }
            set
            {
                if ((row < 0 || row >= this.Rows) ||
                    (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                this._matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new InvalidOperationException("Matrices must have the same dimensions.");
            }

            var result = new Matrix<T>(matrix1.Rows, matrix2.Cols);
            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = (dynamic)matrix1[row, col] + (dynamic)matrix2[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new InvalidOperationException("Matrices must have the same dimensions.");
            }

            var result = new Matrix<T>(matrix1.Rows, matrix2.Cols);
            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = (dynamic)matrix1[row, col] - (dynamic)matrix2[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Cols || matrix1.Cols != matrix2.Rows)
            {
                throw new InvalidOperationException("The number of columns in the first matrice should equal the number of rows in the second.");
            }

            var result = new Matrix<T>(matrix1.Rows, matrix2.Cols);
            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    for (int index = 0; index < matrix1.Cols; index++)
                    {
                        result[row, col] += (dynamic)matrix1[row, index] * (dynamic)matrix2[index, col];
                    }
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return ContainsNonZeroElement(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return ContainsNonZeroElement(matrix);
        }

        private static bool ContainsNonZeroElement(Matrix<T> matrix)
        {
            foreach (var element in matrix._matrix)
            {
                if (!element.Equals(default(T)))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    result.Append(String.Format("{0,-5}", this._matrix[row, col]) + " ");
                }
                result.AppendLine();
            }

            return result.ToString().Trim();
        }

    }
}
