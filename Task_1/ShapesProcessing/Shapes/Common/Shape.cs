using ShapesProcessing.Exceptions;

namespace ShapesProcessing.Shapes.Common
{
    public abstract class Shape
    {
        public string PetName { get; }

        protected Shape(string petName)
        {
            if (string.IsNullOrWhiteSpace(petName))
                throw new ShapesExceptions("Имя фигуры не может быть пустым");
            PetName = petName;
        }

        public abstract double GetSquare();

        public override string ToString() => $"Имя фигуры: {PetName}, площадь фигуры {GetSquare():N3}";

    }
}