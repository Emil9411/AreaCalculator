namespace AreaCalculator.Model;

public class Parallelogram
{
    private float Base { get; }
    private float Height { get; }
    private float Angle { get; }
    public float Area => Base * Height * MathF.Sin(Angle);
    public float Perimeter => Base * 2 + Height * 2;
    
    public Parallelogram(float @base, float height, float angle)
    {
        Base = @base;
        Height = height;
        Angle = angle;
    }
}