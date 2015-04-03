using System;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;

        public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            this.Model = model;
            this.Material = materialType;
            this.Price = price;
            this.Height = height;
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Chair should have positive number of legs!");
                }
                this.numberOfLegs = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(
                string.Format(
                    "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}", 
                    this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs));

            return result.ToString().Trim();
        }
    }
}
