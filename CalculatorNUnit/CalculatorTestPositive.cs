namespace CalculatorNUnit;

public class CalculatorTestsPositive
{
    [TestCase(3,4,5, 6)]
    [TestCase(15,13,17, 94)]
    [TestCase(10,10,7, 33)]
    public void TestCalculateTriangleAreaPositive(double side1, double side2, double side3, double ans)
    {
        Assert.That(CalculateTriangleArea(side1, side2, side3), Is.EqualTo(ans));
    }
    
    [TestCase(3,4,5, true)]
    [TestCase(5,12,13, true)]
    [TestCase(5,12,12, false)]
    [TestCase(5,3,3, false)]
    public void TestRightTriangleVerificationPositive(double side1, double side2, double side3, bool ans)
    {
        Assert.That(RightTriangleVerification(side1, side2, side3), Is.EqualTo(ans));
    }
    
    [TestCase(1, 3)]
    [TestCase(2, 13)]
    public void TestCalculateCircleAreaPositive(double radius, double ans)
    {
        Assert.That(CalculateCircleArea(radius), Is.EqualTo(ans));
    }
    
    [TestCase(3, 3, 4)]
    [TestCase(10, 10, 769)]
    public void TestCalculatePolygonAreaPositive(double sideLength, int sides, double ans)
    {
        Assert.That(CalculatePolygonArea(sideLength, sides), Is.EqualTo(ans));
    }
    
}