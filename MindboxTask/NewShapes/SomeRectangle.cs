using MindboxTask.ComputeSquare;
using MindboxTask.ComputeSquare.Shapes;

namespace MindboxTask.NewShapes;

public class SomeRectangle : AbstractShape
{
    public float Width { get; }
    public float Height { get; }
    

    public SomeRectangle(float width, float height)
    {
        Height = height;
        Width = width;
    }
    
    public override float Square(ISquareType squareType)
    {
        return squareType.Square();
    }
}