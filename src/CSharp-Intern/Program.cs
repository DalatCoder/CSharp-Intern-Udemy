using System;

namespace CSharp_Intern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var hieu = new Person(new DateTime(2000, 03, 11));
            Console.WriteLine($"Your age is: {hieu.Age}");
        }
    }
}
