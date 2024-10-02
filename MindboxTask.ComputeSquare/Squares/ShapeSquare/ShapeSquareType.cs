using MindboxTask.ComputeSquare.Shapes;

namespace MindboxTask.ComputeSquare.Squares.ShapeSquare;

/// <summary>
/// Вычисление площади фигуры.
/// </summary>
public class ShapeSquareType : ISquareType
{
    private readonly SomeShape _shape;

    private Func<SomeShape, float> _compute;

    public ShapeSquareType(SomeShape shape, Func<SomeShape, float> compute)
    {
        _shape = shape;
        _compute = compute;
    }
    
    /// <summary>
    /// Площадь фигуры.
    /// </summary>
    /// <returns></returns>
    public float Square()
    {
        return _compute(_shape);
    }
}