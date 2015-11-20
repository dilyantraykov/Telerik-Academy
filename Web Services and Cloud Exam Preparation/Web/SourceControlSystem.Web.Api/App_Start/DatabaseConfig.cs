using SourceControlSystem.Data;
using SourceControlSystem.Data.Migrations;
using System.Data.Entity;

namespace SourceControlSystem.Web.Api.App_Start
{
    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SourceControlSystemDbContext, Configuration>());
            SourceControlSystemDbContext.Create().Database.Initialize(true);
        }
    }
}