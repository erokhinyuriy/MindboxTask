namespace MindboxTask.ComputeSquare.Shapes;

/// <summary>
/// Треугольник.
/// </summary>
public class SomeTriangle : AbstractShape
{
    private float _sideA;
    private float _sideB;
    private float _sideC;

    /// <summary>
    /// Катет А.
    /// </summary>
    public float SideA
    {
        get => _sideA;
    }
    
    /// <summary>
    /// Катет Б.
    /// </summary>
    public float SideB
    {
        get => _sideB;
    }
    
    /// <summary>
    /// Гипотенуза.
    /// </summary>
    public float SideC
    {
        get => _sideC;
    }
    
    /// <summary>
    /// Треугольник прямоугольный?
    /// </summary>
    public bool IsRectangular
    {
        get => Math.Round(Math.Pow(_sideC, 2)) == (Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2 ));
    }
    
    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="sideA">Катет А.</param>
    /// <param name="sideB">Катет Б.</param>
    /// <param name="sideC">Гипотенуза.</param>
    public SomeTriangle(float sideA, float sideB, float sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    /// <summary>
    /// Площадь треугольника.
    /// </summary>
    /// <param name="squareType"></param>
    /// <returns></returns>
    public override float Square(ISquareType squareType)
    {
        return squareType.Square();
    }
}