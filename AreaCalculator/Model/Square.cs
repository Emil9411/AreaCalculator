namespace AreaCalculator.Model;

public class Square
{
    private float Side { get; }
    public float Area => Side * Side;
    public float Perimeter => Side * 4;
    
    public Square(float side)
    {
        Side = side;
    }
}