using MindboxTask.ComputeSquare;
using MindboxTask.ComputeSquare.Shapes;
using MindboxTask.ComputeSquare.Squares.CircleSquare;
using MindboxTask.ComputeSquare.Squares.ShapeSquare;
using MindboxTask.ComputeSquare.Squares.TriangleSquare;
using Xunit;
using Assert = Xunit.Assert;

namespace MindboxTask.Tests;

public class ComputeSquareTest
{
    [Fact]
    public void ComputeSquare()
    {
        var shape = new SomeShape();
        var circle = new SomeCircle(7);
        var triangle = new SomeTriangle(3, 5, 7);
        
        IComputeSquare compute = new ComputeSquare.ComputeSquare(new ShapeSquareType(shape, x => 5 * 7 * 7), 
            new CircleSquareType(circle), 
            new TriangleSquareType(triangle));

        var shapeSquare = compute.Square();
        var circleSquare = compute.CircleSquare();
        var triangleSquare = compute.TriangleSquare();
        
        Assert.Equal("245.00", shapeSquare.ToString("0.00"));
        Assert.Equal("153.86", circleSquare.ToString("0.00"));
        Assert.Equal("6.495", triangleSquare.ToString("0.000"));
    }
}