namespace EntityConcurrency
{
    using NorthwindContext;

    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            // task - 7 - https://msdn.microsoft.com/en-us/data/jj592904.aspx
            for (int i = 0; i < 3; i++)
            {
                var firstConection = new NorthwindEntities();
                var secondConection = new NorthwindEntities();

                Console.WriteLine();
                var firstCustomer = firstConection.Customers.Find("TELER");
                var secondCustomer = secondConection.Customers.Find("TELER");

                Console.WriteLine("Name from first connection: " + firstCustomer.CompanyName);
                Console.WriteLine("Name from second connection: " + secondCustomer.CompanyName);

                firstCustomer.CompanyName = "TELERIK 1";
                secondCustomer.CompanyName = "TELERIK 2";

                secondConection.SaveChanges();
                firstConection.SaveChanges();

                var result = new NorthwindEntities().Customers.Find("TELER");
                Console.WriteLine("Final company name {0}", result.CompanyName);
                Console.WriteLine();
            }
        }
    }
}
