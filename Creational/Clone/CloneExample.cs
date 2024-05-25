using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Creational.Clone
{
    public static class CloneExample
    {

        public static List<Shape> shapes = [];

        public static void Run()
        {
            var circle = new Circle
            {
                X = 4,
                Y = 5,
                Radius = 11
            };
            shapes.Add(circle);

            var secondCircle = circle.Clone();
            shapes.Add(secondCircle);

            var rectangle = new Rectangle
            {
                X = 10,
                Y = 10,
                Width = 32,
                Height = 2
            };
            shapes.Add(rectangle);

            var shapesCopy = new List<Shape>();
            shapesCopy.AddRange(shapes.Select(x => x.Clone()));
        }
    }
}
