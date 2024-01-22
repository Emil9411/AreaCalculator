using AreaCalculator.Model;

namespace AreaCalculatorTest;

public class ModelMethodTests
{
    [Test]
    public void ParallelogramAreaTest()
    {
        Assert.That(new Parallelogram(3, 2, 90).Area, Is.EqualTo(5.36397982f).Within(0.00000001));
    }
    
    [Test]
    public void ParallelogramPerimeterTest()
    {
        Assert.That(new Parallelogram(3, 2, 90).Perimeter, Is.EqualTo(10).Within(0.00000001));
    }
    
    [Test]
    public void RectangleAreaTest()
    {
        Assert.That(new Rectangle(3, 2).Area, Is.EqualTo(6).Within(0.00000001));
    }
    
    [Test]
    public void RectanglePerimeterTest()
    {
        Assert.That(new Rectangle(3, 2).Perimeter, Is.EqualTo(10).Within(0.00000001));
    }
    
    [Test]
    public void SquareAreaTest()
    {
        Assert.That(new Square(3).Area, Is.EqualTo(9).Within(0.00000001));
    }
    
    [Test]
    public void SquarePerimeterTest()
    {
        Assert.That(new Square(3).Perimeter, Is.EqualTo(12).Within(0.00000001));
    }
    
    [Test]
    public void RhombusAreaTest()
    {
        Assert.That(new Rhombus(3, 90).Area, Is.EqualTo(8.04596996f).Within(0.00000001));
    }
    
    [Test]
    public void RhombusPerimeterTest()
    {
        Assert.That(new Rhombus(3, 90).Perimeter, Is.EqualTo(12).Within(0.00000001));
    }
    
    [Test]
    public void TrapezoidAreaTest()
    {
        Assert.That(new Trapezoid(3, 2, 90).Area, Is.EqualTo(225.0f).Within(0.00000001));
    }
    
    [Test]
    public void TrapezoidPerimeterTest()
    {
        Assert.That(new Trapezoid(3, 2, 90).Perimeter, Is.EqualTo(8105.5f).Within(0.00000001));
    }
    
    [Test]
    public void CircleAreaTest()
    {
        Assert.That(new Circle(3).Area, Is.EqualTo(28.2743339f).Within(0.00000001));
    }
    
    [Test]
    public void CirclePerimeterTest()
    {
        Assert.That(new Circle(3).Perimeter, Is.EqualTo(18.8495559f).Within(0.00000001));
    }
    
}