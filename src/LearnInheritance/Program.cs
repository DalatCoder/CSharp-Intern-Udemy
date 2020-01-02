using System;

namespace LearnInheritance
{
    public class PresentationObject
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard!");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
        }
    }

    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine($"We added a link to {url}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var text = new Text()
            {
                Width = 100,
                Height = 50,
                FontName = "Arial",
                FontSize = 11
            };

            text.Copy();
            text.Duplicate();
        }
    }
}
