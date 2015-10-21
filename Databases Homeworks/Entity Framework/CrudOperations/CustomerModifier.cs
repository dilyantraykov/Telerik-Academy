using System.Collections.Generic;
using System.Linq;

namespace CrudOperations
{
    using NorthwindContext;

    public class CustomerModifier
    {
        public static string AddCustomer(string customerId, string companyName, string contactName, string contactTitle,
            string address, string city, string region, string postalCode, string country, string phone, string fax)
        {
            var northwind = new NorthwindEntities();
            var customer = new Customer()
            {
                CustomerID = customerId,
                CompanyName = companyName,
                ContactName = contactName,
                ContactTitle = contactTitle,
                Address = address,
                City = city,
                Region = region,
                PostalCode = postalCode,
                Country = country,
                Phone = phone,
                Fax = fax,
            };

            northwind.Customers.Add(customer);
            northwind.SaveChanges();
            return customer.CustomerID;
        }

        public static Customer GetCustomerById(NorthwindEntities northwind, string customerId)
        {
            var customer = northwind.Customers.FirstOrDefault(c => c.CustomerID == customerId);

            return customer;
        }

        public static void ModifyCompanyName(string customerId, string companyName)
        {
            var northwind = new NorthwindEntities();
            var customer = GetCustomerById(northwind, customerId);
            customer.CompanyName = companyName;
            northwind.SaveChanges();
        }

        public static void ModifyContactName(string customerId, string contactName)
        {
            var northwind = new NorthwindEntities();
            var customer = GetCustomerById(northwind, customerId);
            customer.ContactName = contactName;
            northwind.SaveChanges();
        }

        public static void DeleteCustomer(string customerId)
        {
            var northwind = new NorthwindEntities();
            var customer = GetCustomerById(northwind, customerId);
            northwind.Customers.Remove(customer);
            northwind.SaveChanges();
        }
    }
}
