using System;
using System.Linq;

namespace GenericList
{
    public class GenericList<T>
        where T : IComparable<T>
    {
        public const int DefaultCapacity = 4;

        private T[] _elements;

        private int _count;

        private int _capacity;

        public int Count
        {
            get { return this._count; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Count should not be negative!");
                }
                this._count = value;
            }
        }

        public int Capacity
        {
            get { return this._capacity; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity should not be negative!");
                }
                this._capacity = value;
            }
        }

        public GenericList()
        {
            this.Count = 0;
            this.Capacity = DefaultCapacity;
        }

        public GenericList(int capacity)
            : this()
        {
            this._elements = new T[capacity];
            this.Capacity = capacity;
        }

        public void Add(T element)
        {
            if (this.Capacity == this.Count)
            {
                this.Resize();
            }
            this._elements[Count] = element;
            this.Count++;
        }

        public void InsertElementAtIndex(T element, int index)
        {
            if (index != this.Count)
            {
                CheckIndex(index);
            }
            var resultArr = new T[Count + 1];
            for (int i = 0; i < index; i++)
            {
                resultArr[i] = _elements[i];
            }
            resultArr[index] = element;
            for (int i = index; i < this.Count; i++)
            {
                resultArr[i + 1] = _elements[i];
            }
            this.Count++;
            if (this.Capacity == this.Count)
            {
                this.Resize();
            }
            Array.Copy(resultArr, this._elements, this.Count);
        }

        public void RemoveElementAtIndex(int index)
        {
            CheckIndex(index);
            _elements = _elements.Where((source, i) => i != index).ToArray();
            this.Count--;
        }

        public T this[int index]
        {
            get
            {
                CheckIndex(index);
                return this._elements[index];
            }
            set
            {
                CheckIndex(index);
                this._elements[index] = value;
            }
        }

        public T Min()
        {
            T min = this._elements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (this._elements[i].CompareTo(min) < 0)
                {
                    min = this._elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this._elements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (this._elements[i].CompareTo(max) > 0)
                {
                    max = this._elements[i];
                }
            }
            return max;
        }

        public int FindElement(T value)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this._elements[i].CompareTo(value) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        private void CheckIndex(int index)
        {
            if (index >= Count && index >= 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
        }

        public void Clear()
        {
            this._elements = new T[0];
            Count = 0;
        }

        public void Resize()
        {
            this.Capacity *= 2;
            var temp = this._elements;
            this._elements = new T[Capacity];
            Array.Copy(temp, this._elements, this.Count);
        }

        public override string ToString()
        {
            var resultArr = new T[Count];
            for (int i = 0; i < this.Count; i++)
            {
                resultArr[i] = this._elements[i];
            }
            if (Count == 0)
            {
                return "List is empty!";
            }
            return String.Join(", ", resultArr);
        }
    }
}
