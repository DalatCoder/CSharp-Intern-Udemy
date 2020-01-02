using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CastingClass
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
            Console.WriteLine("Draw a shape");
        }
    }

    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            var shape = text;

            // Both text and shape reference the same object in memory
            // but they have difference view
            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);

            text.FontSize = 13;
            // shape is actually text at runtime
            // downcasting
            if (shape is Text) { var anotherText = (Text)shape; }

            var anotherText = shape as Text;
            if (anotherText != null)
            {
                Console.WriteLine("Downcasting shape object");
                anotherText.FontSize = 11; // text and another text have the same reference
                Console.WriteLine(text.FontSize);
            }
        }
    }
}
