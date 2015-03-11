namespace DefiningClasses
{
    using System;

    public class Display
    {
        private double _size;

        public Display(double size)
        {
            this.Size = size;
        }

        public Display(double size, uint numberOfColors)
            : this(size)
        {
            this.NumberOfColors = numberOfColors;
        }

        public override string ToString()
        {
            return Size.ToString() + "\", " + NumberOfColors.ToString() + " colors";
        }

        public double Size
        {
            get { return this._size; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Size should be positive!");
                }
                this._size = value;
            }
        }

        public uint NumberOfColors { get; private set; }
    }
}
