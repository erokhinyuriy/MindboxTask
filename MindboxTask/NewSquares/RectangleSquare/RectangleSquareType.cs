using MindboxTask.NewShapes;

namespace MindboxTask.NewSquares.RectangleSquare;

public class RectangleSquareType : IRectangleSquareType
{
    private readonly SomeRectangle _rectangle;

    public RectangleSquareType(SomeRectangle rectangle)
    {
        _rectangle = rectangle;
    }

    public float Square()
    {
        return _rectangle.Height * _rectangle.Width;
    }
}