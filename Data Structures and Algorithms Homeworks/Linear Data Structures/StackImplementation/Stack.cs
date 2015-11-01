namespace StackImplementation
{
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable
    {
        private const int InitialSize = 4;

        private T[] items;
        private int size;

        public Stack()
        {
            this.items = new T[InitialSize];
            this.size = 0;
        }

        public int Count
        {
            get { return this.size; }
        }

        public int Capacity
        {
            get { return this.items.Length; }
        }

        public void Push(T item)
        {
            if (this.Capacity == this.Count)
            {
                this.Resize();
            }

            this.items[this.size] = item;
            this.size++;
        }

        public T Pop()
        {
            if (this.size == 0)
            {
                return default(T);
            }

            T itemToReturn = this.items[this.size - 1];
            this.size--;

            return itemToReturn;
        }

        public T Peek()
        {
            if (this.size == 0)
            {
                return default(T);
            }

            return this.items[this.size - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < this.size; i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void Resize()
        {
            var newArr = new T[this.Capacity * 2];

            for (int i = 0; i < this.Capacity; i++)
            {
                newArr[i] = this.items[i];
            }

            this.items = newArr;
        }
    }
}
