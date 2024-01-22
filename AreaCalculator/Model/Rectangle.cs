namespace AreaCalculator.Model;

public class Rectangle
{
    private float Width { get; }
    private float Height { get; }
    public float Area => Width * Height;
    public float Perimeter => (Width + Height) * 2;
    
    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }
}