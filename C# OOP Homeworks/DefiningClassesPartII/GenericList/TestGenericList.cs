namespace GenericList
{
    using System;

    class TestGenericList
    {
        static void Main()
        {
            var myList = new GenericList.GenericList<int>(2);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            myList.InsertElementAtIndex(7, 5);
            myList.RemoveElementAtIndex(3);

            Console.WriteLine("My list: {0}", myList);
            Console.WriteLine();

            Console.WriteLine("The index of the found element is: {0}", myList.FindElement(7));
            Console.WriteLine();

            Console.WriteLine("The smallest element is: {0}", myList.Min());
            Console.WriteLine();
            Console.WriteLine("The biggest element is: {0}", myList.Max());

            myList.Clear();
            Console.WriteLine();
            Console.WriteLine(myList);
        }
    }
}
