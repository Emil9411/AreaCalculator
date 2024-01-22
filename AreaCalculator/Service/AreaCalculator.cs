using AreaCalculator.Model;

namespace AreaCalculator.Service;

public class AreaCalculator : ICalculator
{
    public float Calculate(object shape)
    {
        return shape switch
        {
            Trapezoid trapezoid => trapezoid.Area,
            Rhombus rhombus => rhombus.Area,
            Rectangle rectangle => rectangle.Area,
            Square square => square.Area,
            _ => throw new ArgumentException("Invalid shape")
        };
    }
}