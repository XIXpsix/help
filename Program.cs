using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            var peopleList = new List<Person>
            {
                new Person("Иван", 30),
                new Person("Анна", 25),
                new Person("Борис", 40),
                new Person("Галина", 35)
            };

            var peopleSet = new HashSet<Person>(peopleList);

            peopleList.Sort();

            Console.WriteLine("Список людей (отсортирован по имени):");
            foreach (var p in peopleList)
                Console.WriteLine(p);

            Console.WriteLine("\nМножество людей (отсортировано по имени):");
            var sortedSet = new List<Person>(peopleSet);
            sortedSet.Sort();
            foreach (var p in sortedSet)
                Console.WriteLine(p);
        }
    }
}
