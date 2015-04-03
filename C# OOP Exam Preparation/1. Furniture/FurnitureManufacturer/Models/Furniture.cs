using System;

namespace FurnitureManufacturer.Models
{
    public class Furniture
    {
        private decimal height;
        private string model;
        private decimal price;

        public string Model
        {
            get { return model; }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentNullException("Model name should contain at least 3 symbols!");
                }
                model = value;
            }
        }

        public string Material { get; set; }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price should be positive!");
                }
                price = value;
            }
        }

        public decimal Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height should be positive!");
                }
                height = value;
            }
        }
    }
}