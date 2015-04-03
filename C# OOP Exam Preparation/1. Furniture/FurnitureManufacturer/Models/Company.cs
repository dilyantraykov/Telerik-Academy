using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string regNumber)
        {
            this.Name = name;
            this.RegistrationNumber = regNumber;
            this.furnitures = new Collection<IFurniture>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("Company name should be at least 5 symbols long!");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length != 10)
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbols!");
                }
                foreach (var letter in value)
                {
                    if (!Char.IsDigit(letter))
                    {
                        throw new ArgumentException("Registration number should contain only digits!");
                    }
                }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.furnitures; }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture"
                ));

            if (this.Furnitures.Count > 0)
            {
                var sortedFurniture = this.Furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model);
                foreach (var item in sortedFurniture)
                {
                    result.AppendLine(item.ToString());
                }
            }

            return result.ToString().Trim();
        }
    }
}
