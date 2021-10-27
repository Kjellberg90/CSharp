Console.WriteLine("Target Row?");
int targetRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Target Columns?");
int targetColumn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deply to");
Console.WriteLine($"({targetRow}, {targetColumn - 1})");
Console.WriteLine($"({targetRow - 1}, {targetColumn})");
Console.WriteLine($"({targetRow}, {targetColumn + 1})");
Console.WriteLine($"({targetRow + 1}, {targetColumn})");