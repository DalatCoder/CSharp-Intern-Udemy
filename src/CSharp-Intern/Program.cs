using System;

namespace CSharp_Intern
{
    public class Person
    {
        public string Name { get; set; }

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {Name}.");
        }

        public static Person Parse(string name)
        {
            return new Person() { Name = name };
        }

        public override string ToString()
        {
            return $"Hello, my name is {Name}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var hieu = Person.Parse("Hieu");
            System.Console.WriteLine(hieu);
            hieu.Introduce("Ha");
        }
    }
}
