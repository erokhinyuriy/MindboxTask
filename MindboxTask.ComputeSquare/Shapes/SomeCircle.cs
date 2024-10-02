namespace MindboxTask.ComputeSquare.Shapes;

/// <summary>
/// Круг.
/// </summary>
public class SomeCircle : AbstractShape
{
    private float _radius;

    /// <summary>
    /// Радиус.
    /// </summary>
    public float Radius
    {
        get => _radius;
    }
    
    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="radius"></param>
    public SomeCircle(float radius)
    {
        _radius = radius;
    }
    
    /// <summary>
    /// Площадь круга.
    /// </summary>
    /// <param name="squareType"></param>
    /// <returns></returns>
    public override float Square(ISquareType squareType)
    {
        return squareType.Square();
    }
}