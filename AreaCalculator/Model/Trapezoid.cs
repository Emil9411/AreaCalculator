namespace AreaCalculator.Model;

public class Trapezoid
{
    private float Base1 { get; }
    private float Base2 { get; }
    private float Height { get; }
    public float Area => (Base1 + Base2) * Height / 2;
    public float Perimeter => Base1 + Base2 + Height * MathF.Sqrt((Base1 - Base2) * (Base1 - Base2) + Height * Height);
    
    public Trapezoid(float base1, float base2, float height)
    {
        Base1 = base1;
        Base2 = base2;
        Height = height;
    }
}