namespace CalculatorNUnit;

public class CalculatorTestsNegative
{
    [TestCase(1,2,3)]
    [TestCase(-5,1,2)]
    [TestCase(0,0,0)]
    public void TestCalculateTriangleAreaNegative(double side1, double side2, double side3)
    {
        Assert.Throws<ArgumentException>(() =>CalculateTriangleArea(side1, side2, side3));
    }
    
    [TestCase(1,2,3)]
    [TestCase(-2,4,6)]
    [TestCase(0,0,0)]
    public void TestRightTriangleVerificationNegative(double side1, double side2, double side3)
    {
        Assert.Throws<ArgumentException>(() => RightTriangleVerification(side1, side2, side3));
    }
    
    [TestCase(-2)]
    [TestCase(0)]
    public void TestCalculateCircleAreaNegative(double radius)
    {
        Assert.Throws<ArgumentException>(() => CalculateCircleArea(radius));
    }

    [TestCase(0, 3)]
    [TestCase(-1, 3)]
    [TestCase(1, 1)]
    [TestCase(1, -1)]
    [TestCase(1, 1)]
    [TestCase(1, -1)]
    public void TestCalculatePolygonAreaNegative(double sideLength, int sides)
    {
        Assert.Throws<ArgumentException>(() => CalculatePolygonArea(sideLength, sides));
    }

}