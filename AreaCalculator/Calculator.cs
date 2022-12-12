namespace AreaCalculator;

public static class Calculator
{
    // В задачах использовал округления для удобства представления конечного ответа
    
    /// <summary>
    /// Точность вычеслений
    /// Нужна для того чтобы не потерять значения при вычислениях с плавающей запятой
    /// </summary>
    private const double Tolerance = 0.01;
    // 1 2 3
    private static bool CheckTriangleExistence(double side1, double side2, double side3)
    {
        return side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2;
    }
    
    
    /// <summary>
    /// Площадь треугольника по трем сторонам
    /// </summary>
    /// <param name="side1">Первая сторона</param>
    /// <param name="side2">Вторая сторона</param>
    /// <param name="side3">Третья сторона</param>
    /// <returns>Площадь треугольника</returns>
    /// <exception cref="ArgumentException">Если одна сторона меньше суммы двух других</exception>
    public static double CalculateTriangleArea(double side1, double side2, double side3)
    {
        if (!CheckTriangleExistence(side1, side2, side3))
            throw new ArgumentException(@"Треугольник не существует, 
                                            одна из его сторон меньше или равна сумме двух других");
        
        var halvedPerimeter = (side1 + side2 + side3) / 2;
        var answer =
            Math.Round(Math.Sqrt(
                halvedPerimeter * (halvedPerimeter - side1) * (halvedPerimeter - side2) * (halvedPerimeter - side3)
                ));
        return answer;
    }
    
    /// <summary>
    /// Площадь правильного многоугольника
    /// </summary>
    /// <param name="sideLength">длина стороны</param>
    /// <param name="sides">кол-во сторон</param>
    /// <returns>Площадь фигуры</returns>
    /// <exception cref="ArgumentException">
    /// Если длинна стороны или кол-во сторон меньше или равно нулю и трем соответственно</exception>
    public static double CalculatePolygonArea(double sideLength, int sides)
    {
        if (sideLength <=0 || sides <3) 
            throw new ArgumentException(
                "Длинна стороны или кол-во сторон не может быть меньше или равно нулю и трем соответственно");
        
        var angle = 180/(float)sides;
        var radians = angle * (Math.PI / 180);
        var answer = Math.Round((sides * sideLength * sideLength) / (4 * Math.Tan(radians)));
        return answer;
    }
    
    
    /// <summary>
    /// Площадь круга
    /// </summary>
    /// <param name="radius">радиус круга</param>
    /// <returns>Площадь круга</returns>
    /// <exception cref="ArgumentException"></exception>
    public static double CalculateCircleArea(double radius)
    {
        if (radius <=0) 
            throw new ArgumentException(
                "Радиус не может быть меньше или равен нулю");

        var answer = Math.Round(Math.PI * radius * radius);
        return answer;
    }

    /// <summary>
    /// Проверка треугольника на прямой угол
    /// </summary>
    /// <param name="side1">Первая сторона</param>
    /// <param name="side2">Вторая сторона</param>
    /// <param name="side3">Третья сторона</param>
    /// <returns>True если треугольник прямоугольный и False если нет</returns>
    /// <exception cref="ArgumentException">Если одна сторона меньше суммы двух других</exception>
    public static bool RightTriangleVerification(double side1, double side2, double side3)
    {
        if (!CheckTriangleExistence(side1, side2, side3))
            throw new ArgumentException(@"Треугольник не существует, 
                                            одна из его сторон меньше или равна сумме двух других");
        
        var square1 = Math.Pow(side1, 2);
        var square2 = Math.Pow(side2, 2);
        var square3 = Math.Pow(side3, 2);
        return Math.Abs(square1 - (square2 + square3)) < Tolerance || 
               Math.Abs(square2 - (square1 + square3)) < Tolerance || 
               Math.Abs(square3 - (square1 + square2)) < Tolerance;
    }
}