using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace ExtendEmployee
{
    using System;
    using NorthwindContext;

    public class Program
    {
        public static void Main()
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                var employee = northwindEntities.Employees.First();

                // The new model for the Employee is in Task01.CreateDbContextForNorthwind
                // in the file EmployeeExtended.cs
                EntitySet territories = employee.TerritoriesSet;

                Console.WriteLine("All territories for employee {0} are:", employee.FirstName);

                foreach (var territory in territories)
                {
                    Console.WriteLine(territory.TerritoryDescription);
                }
            }
        }
    }
}
