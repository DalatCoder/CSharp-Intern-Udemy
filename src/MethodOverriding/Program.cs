using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    public class Position
    {

    }

    public enum ShapeType
    {
        Circle,
        Rectangle,
        Triangle
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        public ShapeType Type { get; set; }
    }

    public class Canvas
    {
        public void DrawShape(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                switch (shape.Type)
                {
                    case ShapeType.Circle:
                        Console.WriteLine("Draw a circle.");
                        break;
                    case ShapeType.Rectangle:
                        Console.WriteLine("Draw a rectangle.");
                        break;
                    case ShapeType.Triangle:
                        Console.WriteLine("Draw a triangle.");
                        break;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
