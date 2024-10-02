using MindboxTask.ComputeSquare.Shapes;
using Xunit;
using Assert = Xunit.Assert;

namespace MindboxTask.Tests;

public class ShapeTest
{
    [Fact]
    public void TriangleIsRectangularTest()
    {
        var triangle1 = new SomeTriangle(4, 2, 4.47f);
        var triangle2 = new SomeTriangle(4, 2, 8);
        
        Assert.True(triangle1.IsRectangular);
        Assert.False(triangle2.IsRectangular);
    }
}