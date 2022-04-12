using System;
using ShapesProcessing.Exceptions;
using ShapesProcessing.Shapes.Common;

namespace ShapesProcessing.Shapes
{
    public class Triangle : Shape
    {
        private readonly int _sideA;
        private readonly int _sideB;
        private readonly int _sideC;

        private int _firstLeg;
        private int _secondLeg;

        public Triangle(string petName, int sideA, int sideB, int sideC) : base(petName)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ShapesExceptions("Стороны фигуры не могут быть меньше или равны 0");
            if (sideA > (sideC + sideB) || sideB > (sideA + sideC) || sideC > (sideA + sideB))
                throw new ShapesExceptions("Одна сторона треугольника не может быть больше суммы двух других сторон");
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double GetSquare()
        {
            if (IsRightTriangle())
                return (double) (_firstLeg + _secondLeg) / 2;
            var p = ((double) (_sideA + _sideB + _sideC)) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        private bool IsRightTriangle()
        {
            if (_sideA == Math.Sqrt(Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2)))
            {
                _firstLeg = _sideB;
                _secondLeg = _sideC;
                return true;
            }

            if (Math.Pow(_sideB, 2) == (Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2)))
            {
                _firstLeg = _sideA;
                _secondLeg = _sideC;
                return true;
            }

            if (Math.Pow(_sideC, 2) == (Math.Pow(_sideA, 2) + Math.Pow(_sideA, 2)))
            {
                _firstLeg = _sideA;
                _secondLeg = _sideB;
                return true;
            }

            return false;
        }
    }
}