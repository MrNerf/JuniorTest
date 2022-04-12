using System;
using ShapesProcessing.Exceptions;
using ShapesProcessing.Shapes.Common;

namespace ShapesProcessing.Shapes
{
    public class Circle : Shape
    {
        private readonly int _radius;

        public Circle(string petName, int radius) : base(petName)
        {
            if (radius <= 0)
                throw new ShapesExceptions("Радиус не может быть отрицательным или равен 0");
            _radius = radius;
        }
        public override double GetSquare() => Math.PI * Math.Pow(_radius, 2);
    }
}