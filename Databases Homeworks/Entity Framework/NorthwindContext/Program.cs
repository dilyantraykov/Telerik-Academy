namespace NorthwindContext
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var northwind = new NorthwindEntities();

            using (northwind)
            {
                Console.WriteLine("All products in Northwind database: ");
                northwind.Products
                    .Select(p => p.ProductName)
                    .ToList()
                    .ForEach(p => System.Console.WriteLine("- " + p));
            }
        }
    }
}
