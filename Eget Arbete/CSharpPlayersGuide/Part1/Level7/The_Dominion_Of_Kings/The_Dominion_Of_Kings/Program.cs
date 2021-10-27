Console.WriteLine("How many estates do you poseess");
var estates = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many provinces do you poseess");
var province = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many duchies do you poseess");
var duchie = Convert.ToInt32(Console.ReadLine());

var estatePoints = estates * 1;
var provincePoints = province * 6;
var duchiePoints = duchie * 3;

var dominonScore = estatePoints + provincePoints + duchiePoints;

Console.WriteLine($"Your dominion is worth {dominonScore} points");