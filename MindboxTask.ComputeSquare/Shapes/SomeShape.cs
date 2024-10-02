namespace MindboxTask.ComputeSquare.Shapes;

/// <summary>
/// Фигура.
/// </summary>
public class SomeShape : AbstractShape
{
    /// <summary>
    /// Площадь фигуры.
    /// </summary>
    /// <param name="squareType"></param>
    /// <returns></returns>
    public override float Square(ISquareType squareType)
    {
        return squareType.Square();
    }
}