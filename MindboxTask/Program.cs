using MindboxTask.ComputeSquare;
using MindboxTask.ComputeSquare.Shapes;
using MindboxTask.ComputeSquare.Squares.CircleSquare;
using MindboxTask.ComputeSquare.Squares.ShapeSquare;
using MindboxTask.ComputeSquare.Squares.TriangleSquare;
using MindboxTask.NewComputeSquare;
using MindboxTask.NewShapes;
using MindboxTask.NewSquares.RectangleSquare;

/**
 * MindboxTask.ComputeSquare - библиотека для рассчета площадей круга (по радиусу) и треугольника (по трём сторонам).
 * Библиотека может быть расширена новыми фигурами, и способами вычисления их площадей.
 */

Console.WriteLine("Тестовое задание для Mindbox!");

// Поддерживаются MindboxTask.ComputeSquare.
var shape = new SomeShape();
var circle = new SomeCircle(5);
var triangle = new SomeTriangle(4, 2, 4.47f);

// Добавил новую фигуру, которая не поддерживается в MindboxTask.ComputeSquare.
var restangle = new SomeRectangle(5, 7);

// Вычислитель из библиотеки.
IComputeSquare compute = new ComputeSquare(new ShapeSquareType(shape, x => 5 * 7 * 7), 
    new CircleSquareType(circle), 
    new TriangleSquareType(triangle));

// Расширенный, с добавлением новой фигуры.
INewComputeSquare newCompute = new NewComputeSquare(new ShapeSquareType(shape, x => 5 * 7 * 7), 
    new CircleSquareType(circle),
    new TriangleSquareType(triangle),
    new RectangleSquareType(restangle));

var shapeSquare = compute.Square();
var circleSquare = compute.CircleSquare();
var triangleSquare = compute.TriangleSquare();

var restangleSquare = newCompute.RectangleSquare();

Console.WriteLine($"shape square: {shapeSquare}");
Console.WriteLine($"circle square: {circleSquare}");
Console.WriteLine($"triangle square: {triangleSquare}");
Console.WriteLine($"restangle square: {restangleSquare}");

Console.WriteLine($"triangle is rectangular: {triangle.IsRectangular}");

