using System;

namespace RangeExceptions
{
    class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(T start, T end, Exception e)
            : base(String.Format("{0} should be in range [{1}...{2}]", start.GetType().Name, start, end), e)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(T start, T end)
            : this(start, end, null) { }


        public T Start { get; set; }

        public T End { get; set; }
    }
}
