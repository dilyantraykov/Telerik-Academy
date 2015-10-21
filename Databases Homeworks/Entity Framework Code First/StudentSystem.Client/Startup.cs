using System;

namespace StudentSystem.Client
{
    using StudentSystem.Data;
    using System.Data.Entity;
    using System.Linq;
    using StudentSystem.Data.Migrations;



    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());

            var con = new StudentSystemContext();

            Console.WriteLine("Students currently in the system: ");
            con.Students
                .Select(s => new { s.FirstName, s.LastName })
                .ToList()
                .ForEach(s => System.Console.WriteLine("- {0} {1}", s.FirstName, s.LastName));
        }
    }
}
