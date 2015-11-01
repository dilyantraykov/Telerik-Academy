namespace LinkedListImplementation
{
    using System;

    /// <summary>
    /// Implement the data structure linked list.
    /// - Define a class ListItem<T> that has two fields: value(of type T) and NextItem(of type ListItem<T>).
    /// - Define additionally a class LinkedList<T> with a single field FirstElement(of type ListItem<T>).
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var linkedList = new LinkedList<string>();
            linkedList.Add("Ko");
            linkedList.Add("Ma");
            linkedList.Add("Foreachvash");
            linkedList.Add("Be?");

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
