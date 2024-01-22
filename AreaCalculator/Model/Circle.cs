namespace AreaCalculator.Model;

public class Circle
{
    private float Radius { get; }
    public float Area => (float) (Math.Pow(Radius, 2) * Math.PI);
    public float Perimeter => (float) (2 * Radius * Math.PI);

    public Circle(float radius)
    {
        Radius = radius;
    }
}