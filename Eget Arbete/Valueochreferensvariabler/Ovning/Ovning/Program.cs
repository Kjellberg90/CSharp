using Ovning;
using System;

//int x1 = 15;
//int x2 = 25;

//string s1 = "abc";
//string s2 = "abc";

//if (x1 == x2)
//{
//    Console.WriteLine("Value type är lika");
//}
//else
//{
//    Console.WriteLine("Value type är olika");
//}

//int x3 = 8;
//int x4 = 8;

//if (x3 == x4)
//{
//    Console.WriteLine("Value type är lika");
//}
//else
//{
//    Console.WriteLine("Value type är olika");
//}

//MemoryDemo x5 = new MemoryDemo();
//MemoryDemo x6 = new MemoryDemo();


//if (x5 == x6)
//{
//    Console.WriteLine("Value type är lika");
//}
//else
//{
//    Console.WriteLine("Value type är olika");
//}

//if (x5.MyProperty == x5.MyProperty)
//{
//    Console.WriteLine("Value type i referens är lika");
//}
//else
//{
//    Console.WriteLine("Value type i referens är olika");
//}

string s1 = null;

if (s1 != null)
{
    Console.WriteLine("String contains text");
}
if (s1 == null)
{
    Console.WriteLine("String is null");
}

string[] stringArray = new string[] { "Position 0", null , "Position 2" };

for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i] != null)
    {
        Console.WriteLine(stringArray[i]);
    }
}

Console.WriteLine("---------------------------------");

MemoryDemo2 demo1 = new MemoryDemo2();

for (int i = 0; i < demo1.MyProperty2.Length; i++)
{
    if (demo1.MyProperty2 != null)
    {
        Console.WriteLine(demo1.MyProperty2[i]);
    }
}