using static AreaCalculator.Calculator;

namespace HHTask
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(CalculatePolygonArea(10, 10));
            Console.WriteLine(CalculateTriangleArea(10,5,1));
        }
    }
}