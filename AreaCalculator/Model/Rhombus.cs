namespace AreaCalculator.Model;

public class Rhombus
{
    private float Side { get; }
    private float Angle { get; }
    public float Area => Side * Side * MathF.Sin(Angle);
    public float Perimeter => Side * 4;
    
    public Rhombus(float side, float angle)
    {
        Side = side;
        Angle = angle;
    }
}