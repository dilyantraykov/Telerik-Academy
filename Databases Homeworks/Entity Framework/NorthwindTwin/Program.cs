namespace NorthwindTwin
{
    using NorthwindContext;

    public class Program
    {
        public static void Main()
        {
            var northwind = new NorthwindEntities();
            northwind.Database.Create();
        }
    }
}
