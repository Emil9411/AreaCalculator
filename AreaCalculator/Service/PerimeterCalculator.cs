using AreaCalculator.Model;

namespace AreaCalculator.Service;

public class PerimeterCalculator :  ICalculator
{
    public float Calculate(object shape)
    {
        return shape switch
        {
            Trapezoid trapezoid => trapezoid.Perimeter,
            Rhombus rhombus => rhombus.Perimeter,
            Rectangle rectangle => rectangle.Perimeter,
            Square square => square.Perimeter,
            _ => throw new ArgumentException("Invalid shape")
        };
    }
}