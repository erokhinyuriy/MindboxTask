using MindboxTask.ComputeSquare.Shapes;

namespace MindboxTask.ComputeSquare.Squares.CircleSquare;

/// <summary>
/// Вычисление площади круга по радиусу.
/// </summary>
public sealed class CircleSquareType : ICircleSquareType
{
    private readonly SomeCircle _circle;
    
    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="circle">Круг.</param>
    public CircleSquareType(SomeCircle circle)
    {
        _circle = circle;
    }
    
    /// <summary>
    /// Площадь круга.
    /// </summary>
    /// <returns></returns>
    public float Square()
    {
        return (float)((_circle.Radius * _circle.Radius) * 3.14);
    }
}