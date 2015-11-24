namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;
        private static Random RandomInstance = new Random();

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (items[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            return Search(this.items, item, 0, this.items.Count - 1);
        }

        private bool Search(IList<T> items, T key, int from, int to)
        {
            if (to < from)
            {
                return false;
            }

            int middle = (from + to) / 2;

            if (items[middle].CompareTo(key) > 0)
            {
                return Search(items, key, from, middle - 1);
            }
            else if (items[middle].CompareTo(key) < 0)
            {
                return Search(items, key, middle + 1, to);
            }
            else
            {
                return true;
            }
        }

        public void Shuffle()
        {
            var n = this.items.Count;
            for (var i = 0; i < n; i++) // O(n)
            {
                int r = i + RandomInstance.Next(0, n - i);
                var temp = this.items[i];
                this.items[i] = this.items[r];
                this.items[r] = temp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
