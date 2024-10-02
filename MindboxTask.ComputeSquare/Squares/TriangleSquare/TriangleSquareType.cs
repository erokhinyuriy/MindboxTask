using MindboxTask.ComputeSquare.Shapes;

namespace MindboxTask.ComputeSquare.Squares.TriangleSquare;

/// <summary>
/// Вычисление площади треугольника по трем сторонам.
/// </summary>
public sealed class TriangleSquareType : ITriangleSquareType
{
    private readonly SomeTriangle _triangle;

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="triangle">Треугольник.</param>
    public TriangleSquareType(SomeTriangle triangle)
    {
        _triangle = triangle;
    }

    // Периметр.
    private float Perimeter() => _triangle.SideA + _triangle.SideB + _triangle.SideC;

    // Полупериметр.
    private float SemiPerimetr() => Perimeter() / 2;

    /// <summary>
    /// Площадь треугольника.
    /// </summary>
    /// <returns></returns>
    public float Square()
    {
        var p = SemiPerimetr();
        double result = p * (p - _triangle.SideA) * (p - _triangle.SideB) * (p - _triangle.SideC); //по формуле Герона
        return (float)Math.Sqrt(result);
    }
}