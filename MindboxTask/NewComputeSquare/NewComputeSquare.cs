using MindboxTask.ComputeSquare;
using MindboxTask.ComputeSquare.Squares.CircleSquare;
using MindboxTask.ComputeSquare.Squares.TriangleSquare;
using MindboxTask.NewSquares.RectangleSquare;

namespace MindboxTask.NewComputeSquare;

/// <summary>
/// Расширенный класс вычислителя площадей.
/// </summary>
public class NewComputeSquare : ComputeSquare.ComputeSquare, INewComputeSquare
{
    private readonly IRectangleSquareType _rectangleSquareType;
    
    public NewComputeSquare(ISquareType squareType, ICircleSquareType circleSquareType, ITriangleSquareType triangleSquareType) 
        : base(squareType, circleSquareType, triangleSquareType)
    {
    }

    public NewComputeSquare(ISquareType squareType, ICircleSquareType circleSquareType, ITriangleSquareType triangleSquareType, 
        IRectangleSquareType rectangleSquareType) 
        : base(squareType, circleSquareType, triangleSquareType)
    {
        _rectangleSquareType = rectangleSquareType;
    }
    
    public float RectangleSquare()
    {
        return _rectangleSquareType.Square();
    }
}