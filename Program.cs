using System;
using System.Collections.Generic;
using System.Linq;
namespace CollectionExample
{
    class CollectionType
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public CollectionType(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public void Show()
        {
            Console.WriteLine($"Назва: {Name}, Значення: {Value}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<CollectionType> collections = new List<CollectionType>
            {
                new CollectionType("Колекцiя A", 150),
                new CollectionType("Колекцiя B", 300),
                new CollectionType("Колекцiя C", 50),
                new CollectionType("Колекцiя D", 220)
            };
            Console.WriteLine("Усi колекцiї:");
            foreach (var item in collections)
            {
                item.Show();
            }
            int threshold = 100;
            int countAboveThreshold = collections.Count(c => c.Value > threshold);
            Console.WriteLine($"\nКiлькiсть колекцiй з сумою бiльше {threshold}: {countAboveThreshold}");
            var maxItem = collections.OrderByDescending(c => c.Value).First();
            Console.WriteLine($"\nМаксимальна колекцiя:");
            maxItem.Show();
            var minItem = collections.OrderBy(c => c.Value).First();
            Console.WriteLine($"\nМiнiмальна колекцiя:");
            minItem.Show();
            Console.ReadLine();
        }
    }
}
