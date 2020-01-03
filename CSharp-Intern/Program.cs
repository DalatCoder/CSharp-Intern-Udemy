using System;

namespace CSharp_Intern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Hieu";
            cookie["age"] = 19.ToString();
            Console.WriteLine(cookie["name"]);
        }
    }
}
