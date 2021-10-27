Food[] food = new Food[] { Food.soup, Food.gumbo, Food.stew };

main[] mains = new main[] { main.mushrooms, main.chicken, main.potatoes };
Seasoning[] seasonings = new Seasoning[] { Seasoning.spicy, Seasoning.sweet, Seasoning.salty };


Tuple<Seasoning, main, Food> s1 = new Tuple<Seasoning, main, Food>(Seasoning.spicy, main.chicken, Food.soup);
Tuple<Seasoning, main, Food> s2 = new Tuple<Seasoning, main, Food>(Seasoning.salty, main.mushrooms, Food.stew);
Tuple<Seasoning, main, Food> s3 = new Tuple<Seasoning, main, Food>(Seasoning.sweet, main.potatoes, Food.gumbo);


Console.WriteLine("Do you want food S1,S2 or S3?");
string input = Console.ReadLine();

if (input == "S1")
{
    Console.WriteLine($"You have choosen a {s1.Item1} {s1.Item2} {s1.Item3}");
}







enum Food { soup, stew, gumbo };
enum main { mushrooms, chicken, potatoes};
enum Seasoning { sweet, salty, spicy };
