using System;

namespace Problem3_4.GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int> { 12, 6, 9, 5, 45, 6, 6, 8, 95, 5 };
            Console.WriteLine("GenericList :");
            Console.WriteLine(list);
            list.Version();
            Console.WriteLine();

            Console.WriteLine("Adding an element");
            list.Add(1);
            Console.WriteLine(list);
            Console.WriteLine();

            Console.WriteLine("Accessing element by index");
            Console.WriteLine("The element at index {0} is {1}", 8, list[8]);
            Console.WriteLine();

            Console.WriteLine("The first index of {0} is {1}", 5, list.IndexOf(5));
            Console.WriteLine("The last index of {0} is {1}", 5, list.LastIndexOf(5));
            Console.WriteLine();

            Console.WriteLine("Removing element by index");
            list.RemoveAt(1);
            Console.WriteLine("Removing the element at index 1, result:");
            Console.WriteLine(list);
            Console.WriteLine();

            Console.WriteLine("Removing element by value");
            list.Remove(45);
            Console.WriteLine("Removing the element with value 45, result:");
            Console.WriteLine(list);
            Console.WriteLine();

            Console.WriteLine("Inserting element at given position");
            list.InsertAt(6, 14);
            Console.WriteLine("Inserted element with value 14 at index 6, result:");
            Console.WriteLine(list);
            Console.WriteLine();

            Console.WriteLine("Checking if the list contains an element with value 6");
            Console.WriteLine(list.Contains(6));
            Console.WriteLine();

            Console.WriteLine("The min element is {0}", list.Min());
            Console.WriteLine("The max element is {0}", list.Max());
            Console.WriteLine();

            Console.WriteLine("List Count before clearing: {0}", list.Count);
            list.Clear();
            Console.WriteLine("List Count after clearing: {0}", list.Count);
            Console.WriteLine("Displaying the elements in the GenericList: {0}", list);
            Console.WriteLine();

            Console.WriteLine("Adding new elements to the GenericList");
            list.Add(6);
            list.Add(5);
            list.Add(89);
            list.Add(12);
            list.Add(5);
            list.Add(99);
            list.Add(65);
            list.Add(456);
            list.Add(44);
            list.Add(8768);
            list.Add(45488);
            list.Add(11);
            Console.WriteLine("GenericList: {0}", list);
            Console.WriteLine();

            System.Reflection.MemberInfo info = typeof(GenericList<>);
            foreach (object attribute in info.GetCustomAttributes(false))
            {
                Console.WriteLine(attribute);
            }
        }
    }
}
