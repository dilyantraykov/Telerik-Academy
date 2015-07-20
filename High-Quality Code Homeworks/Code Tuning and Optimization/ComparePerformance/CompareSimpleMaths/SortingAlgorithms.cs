using System;
using System.Collections.Generic;

namespace CompareSimpleMaths
{
    public static class SortingAlgorithms
    {
        public static T[] PerformInsertionSort<T>(T[] inputarray, Comparer<T> comparer = null)
        {
            var equalityComparer = comparer ?? Comparer<T>.Default;
            for (var counter = 0; counter < inputarray.Length - 1; counter++)
            {
                var index = counter + 1;
                while (index > 0)
                {
                    if (equalityComparer.Compare(inputarray[index - 1], inputarray[index]) > 0)
                    {
                        var temp = inputarray[index - 1];
                        inputarray[index - 1] = inputarray[index];
                        inputarray[index] = temp;
                    }
                    index--;
                }
            }
            return inputarray;
        }

        public static void PerformSelectionSort<T>(T[] arr)
        {
            int i, j;
            int len = arr.Length;
            for (i = 0; i < len; i++)
            {
                int min = i;
                for (j = i + 1; j < len; j++)
                {
                    if ((dynamic)arr[j] < arr[min]) min = j;
                }

                T temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        public static void PerformQuickSort<T>(T[] arr, int left, int right)
            where T : IComparable
        {
            int i = left, j = right;
            T pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (arr[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    T tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                PerformQuickSort(arr, left, j);
            }

            if (i < right)
            {
                PerformQuickSort(arr, i, right);
            }
        }
    }
}
