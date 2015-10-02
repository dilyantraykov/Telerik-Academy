namespace TelerikRss
{
    using System;
    using System.Collections;

    public static class Extensions
    {
        public static void Print(this IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
