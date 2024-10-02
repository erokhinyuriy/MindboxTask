using MindboxTask.ComputeSquare.Squares.CircleSquare;
using MindboxTask.ComputeSquare.Squares.TriangleSquare;

namespace MindboxTask.ComputeSquare;

/// <summary>
/// Вычислитель площадей.
/// </summary>
public class ComputeSquare : IComputeSquare
{
    private readonly ISquareType _squareType;
    
    private readonly ICircleSquareType _circleSquareType;

    private readonly ITriangleSquareType _triangleSquareType;

    public ComputeSquare(ISquareType squareType, ICircleSquareType circleSquareType, ITriangleSquareType triangleSquareType)
    {
        _squareType = squareType;
        _circleSquareType = circleSquareType;
        _triangleSquareType = triangleSquareType;
    }
    
    public float Square() 
    {
        return _squareType.Square();
    }

    public float CircleSquare()
    {
        return _circleSquareType.Square();
    }
    
    public float TriangleSquare()
    {
        return _triangleSquareType.Square();
    }
}