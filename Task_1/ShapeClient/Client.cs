using System;
using ShapesProcessing.Shapes;
using ShapesProcessing.Shapes.Common;

namespace ShapeClient
{
    internal class Client
    {
        private static void Main()
        {
            Console.Title = "Клиент библиотеки ShapesProcessing";
            Console.ForegroundColor = ConsoleColor.Green;
            try
            {

                var shapes = new Shape[5];
                shapes[0] = new Circle("Круг 1", 10);
                shapes[1] = new Triangle("Треугольник 1", 4, 5 , 3);
                shapes[2] = new Triangle("Треугольник 2", 4, 4, 7);
                shapes[3] = new Circle("Круг 2", 2);
                shapes[4] = new Triangle("Треугольник 3", 2, 3, 4);
                foreach (var shape in shapes) Console.WriteLine(shape.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Программа вызывала исключение {e.Message}, тип исключения: {e.GetType().Name}");
            }

            Console.WriteLine("Работа приложения завершена, нажмите Enter чтобы продолжить");
            Console.ReadLine();
        }
    }
}
