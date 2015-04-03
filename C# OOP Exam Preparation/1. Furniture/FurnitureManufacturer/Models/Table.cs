using System;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;
        private decimal area;

        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            this.Model = model;
            this.Material = materialType;
            this.Price = price;
            this.Height = height;
            this.length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get { return this.length; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length should be positive!");
                }
                this.length = value;
            }
        }

        public decimal Width
        {
            get { return this.width; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width should be positive!");
                }
                this.width = value;
            }
        }

        public decimal Area
        {
            get { return this.length*this.width; }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(
                string.Format(
                    "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}",
                    this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.Length, this.Width,
                    this.Area));

            return result.ToString().Trim();
        }
    }
}
