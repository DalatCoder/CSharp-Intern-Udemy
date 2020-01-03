using System.Linq;
using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vitae nibh mauris. Aliquam eget diam vel magna placerat tincidunt a nec massa. Cras placerat quis orci sed commodo.";

            var shortenedPost = post.Shorten(5);

            System.Console.WriteLine($"Original post: {post}");
            System.Console.WriteLine($"Shortend post: {shortenedPost}");

            IEnumerable<int> numbers = new List<int>() { 1, 4, 5, 6, 10, 2, 4 };
            var max = numbers.Max();
        }

    }
}
