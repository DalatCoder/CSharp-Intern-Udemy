using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>()
            {
                new Circle(),
                new Rectangle(),
                new Circle(),
                new Rectangle(),
                new Triangle()
            };

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
