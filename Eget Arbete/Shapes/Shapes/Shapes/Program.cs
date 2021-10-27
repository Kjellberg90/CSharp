using System;
using System.Collections.Generic;
using Shapes;

Square square = new Square(3);
Console.WriteLine(square.GetArea());

Triangle triangle = new Triangle(3, 7);
Console.WriteLine(triangle.GetArea());

Circle circle = new Circle(10);
Console.WriteLine(circle.GetArea());

List<IShape> list = new List<IShape> { new Square(3), new Triangle(3, 7), new Circle(10), new Circle(20) };

Console.WriteLine();
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i].GetArea());
}

