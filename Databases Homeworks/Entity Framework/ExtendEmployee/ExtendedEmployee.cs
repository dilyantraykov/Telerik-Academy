namespace ExtendEmployee
{
    using System.Data.Entity.Core.Metadata.Edm;
    using NorthwindContext;

    public partial class Employee
    {
        public EntitySet TeritoriesSet { get; set; }
    }
}
