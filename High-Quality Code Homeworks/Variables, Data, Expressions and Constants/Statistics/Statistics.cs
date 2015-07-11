namespace Statistics
{
    using System;

    public class Statistics
    {
        public void PrintStatistics(double[] array, int count)
        {
            if (count <= 0)
            {
                throw new ArgumentOutOfRangeException("Array Length");
            }

            var totalSum = array[0];
            var maxNumber = array[0];
            var minNumber = array[0];

            for (int i = 1; i < count; i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }

                if (array[i] < minNumber)
                {
                    minNumber = array[i];
                }

                totalSum += array[i];
            }

            var averageNumber = totalSum / count;

            this.PrintMax(maxNumber);
            this.PrintMin(minNumber);
            this.PrintAverage(averageNumber);
        }

        private void PrintAverage(double averageNumber)
        {
            Console.WriteLine("Average number: {0}", averageNumber);
        }

        private void PrintMin(double minNumber)
        {
            Console.WriteLine("Min number: {0}", minNumber);
        }

        private void PrintMax(double maxNumber)
        {
            Console.WriteLine("Max number: {0}", maxNumber);
        }
    }
}
