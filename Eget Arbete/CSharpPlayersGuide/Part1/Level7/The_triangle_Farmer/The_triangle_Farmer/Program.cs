Console.WriteLine("What is the triangles Height?");
var height = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the triangles Width?");
var width = Convert.ToDouble(Console.ReadLine());

var area = (width * height) / 2;

Console.WriteLine($"The area of your triangle is {area}");