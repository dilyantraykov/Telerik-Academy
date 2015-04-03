using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private readonly decimal initialHeight;

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.initialHeight = height;
            this.IsConverted = false;
        }

        public bool IsConverted { get; set; }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;
            if (this.IsConverted)
            {
                this.Height = 0.10M;
            }
            else
            {
                this.Height = initialHeight;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(
                string.Format(
                    "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}", 
                    this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs, this.IsConverted ? "Converted" : "Normal"));

            return result.ToString().Trim();
        }
    }
}
