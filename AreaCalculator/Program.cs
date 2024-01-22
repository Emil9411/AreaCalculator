using AreaCalculator.Logger;
using AreaCalculator.Model;
using AreaCalculator.Reader;

namespace AreaCalculator
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            IReader reader = new ConsoleReader();
            IList<Shapes> shapes = Enum.GetValues<Shapes>();
            logger.Log("Enter the number of the chosen shape:");
            for (int i = 0; i < shapes.Count; i++)
            {
                logger.Log($"{i + 1}. {shapes[i]}");
            }
            int shapeNumber = int.Parse(reader.Read());
            Shapes shape = shapes[shapeNumber - 1];
            logger.Log("Enter the parameters of the chosen shape:");
            switch (shape)
            {
                case Shapes.Parallelogram:
                    logger.Log("Enter the base:");
                    float base1 = float.Parse(reader.Read());
                    logger.Log("Enter the height:");
                    float height1 = float.Parse(reader.Read());
                    logger.Log("Enter the angle:");
                    float angle1 = float.Parse(reader.Read());
                    logger.Log($"The area of the parallelogram is {new Parallelogram(base1, height1, angle1).Area}");
                    logger.Log($"The perimeter of the parallelogram is {new Parallelogram(base1, height1, angle1).Perimeter}");
                    break;
                case Shapes.Rectangle:
                    logger.Log("Enter the width:");
                    float width1 = float.Parse(reader.Read());
                    logger.Log("Enter the height:");
                    float height2 = float.Parse(reader.Read());
                    logger.Log($"The area of the rectangle is {new Rectangle(width1, height2).Area}");
                    logger.Log($"The perimeter of the rectangle is {new Rectangle(width1, height2).Perimeter}");
                    break;
                case Shapes.Square:
                    logger.Log("Enter the side:");
                    float side1 = float.Parse(reader.Read());
                    logger.Log($"The area of the square is {new Square(side1).Area}");
                    logger.Log($"The perimeter of the square is {new Square(side1).Perimeter}");
                    break;
                case Shapes.Rhombus:
                    logger.Log("Enter the side:");
                    float side2 = float.Parse(reader.Read());
                    logger.Log("Enter the angle:");
                    float angle2 = float.Parse(reader.Read());
                    logger.Log($"The area of the rhombus is {new Rhombus(side2, angle2).Area}");
                    logger.Log($"The perimeter of the rhombus is {new Rhombus(side2, angle2).Perimeter}");
                    break;
                case Shapes.Trapezoid:
                    logger.Log("Enter the base1:");
                    float base2 = float.Parse(reader.Read());
                    logger.Log("Enter the base2:");
                    float base3 = float.Parse(reader.Read());
                    logger.Log("Enter the height:");
                    float height3 = float.Parse(reader.Read());
                    logger.Log($"The area of the trapezoid is {new Trapezoid(base2, base3, height3).Area}");
                    logger.Log($"The perimeter of the trapezoid is {new Trapezoid(base2, base3, height3).Perimeter}");
                    break;
                default:
                    logger.Log("Unknown shape");
                    break;
            }
        }
    }
}