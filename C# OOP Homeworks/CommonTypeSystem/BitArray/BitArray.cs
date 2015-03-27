using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BitArray
{
    public class BitArray : IEnumerable<int>, IComparable
    {
        public BitArray(ulong number)
        {
            this.Number = number;
        }

        public ulong Number { get; set; }

        public int this[int position]
        {
            get
            {
                if (position < 0 || position >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                return ((int) (this.Number >> position) & 1);
            }
            set
            {
                if (position < 0 || position >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("Invalid bit value.");
                }

                if (((int) (this.Number >> position) & 1) != value)
                {
                    this.Number ^= (1ul << position);
                }
            }
        }

        public static bool operator ==(BitArray bitArray1, BitArray bitArray2)
        {
            return (bitArray1.Equals(bitArray2));
        }

        public static bool operator !=(BitArray bitArray1, BitArray bitArray2)
        {
            return !(bitArray1.Equals(bitArray2));
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int position = 63; position >= 0; position--)
            {
                result.Append((this.Number >> position) & 1);
            }

            return result.ToString();
        }

        public override int GetHashCode()
        {
            return 251 * this.Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray).Number);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int position = 63; position >= 0; position--)
            {
                yield return this[position];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            return this.Number.CompareTo((obj as BitArray).Number);
        }
    }
}
