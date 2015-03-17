namespace VersionAttribute
{
    using System;

    [Version("1.0.1")]
    class TestVerstionAttribute
    {
        private static void Main()
        {
            object[] attributes = typeof(TestVerstionAttribute).GetCustomAttributes(false);
            Console.WriteLine("Version: {0}", attributes[0]);
        }
    }
}
