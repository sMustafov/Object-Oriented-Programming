using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.CustomLINQExtensionMethods
{
    static class CustomLINQExtensionMethods
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            List<T> list = new List<T>();

            foreach (var element in collection)
            {
                bool match = predicate(element);
                if (!match)
                {
                    list.Add(element);
                }
            }
            return list;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection,
            Func<TSource, TSelector> predicate) where TSelector : IComparable<TSelector>
        {
            TSelector max = predicate(collection.First());

            foreach (var element in collection.Where(element => max.CompareTo(predicate(element)) < 0))
            {
                max = predicate(element);
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("WhereNot :");
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var filteredCollection = nums.WhereNot(x => x % 2 == 0);
            Console.WriteLine(String.Join(", ", filteredCollection));

            Console.WriteLine("Max :");
            var students = new List<Student>
            {
                new Student("Pesho",3),
                new Student("Gosho",2),
                new Student("Mariika", 7),
                new Student("Stamat",5)
            };
            Console.WriteLine(students.Max(student => student.Grade));
        }
    }
}
