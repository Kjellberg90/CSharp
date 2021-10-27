using System;


//for (int i = 0; i < 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine("/");
//    }
//    else
//    {
//        Console.WriteLine("\\");
//    }
//}

//for (int i = 0; i < 20; i++)
//{
//    if (i <= 9)
//    {
//        Console.WriteLine("|");
//    }
//    else if (i >= 10 && i <= 20)
//    {
//        if (i % 2 == 0)
//        {
//            Console.WriteLine("/");
//        }
//        else
//        {
//            Console.WriteLine("\\");
//        }
//    } else if (i > 20 && i <= 30)
//    {
//        Console.WriteLine("|");
//    } else
//    {
//        if (i % 2 == 0)
//        {
//            Console.WriteLine("/");
//        }
//        else
//        {
//            Console.WriteLine("\\");
//        }
//    }
//}

//for (int i = 0; i < 40; i++)
//{
//    //Raka sömmar
//    if (i < 10 || (i >= 30 && i <= 40))
//    {
//        Console.WriteLine("|");
//    }//SICK-SACK Sömmar
//    else
//    {
//        if (i % 2 == 0)
//        {
//            Console.WriteLine("/");
//        }
//        else
//        {
//            Console.WriteLine("\\");
//        }
//    }
//}

//int[] doubleArray = new int[8];
//Console.WriteLine(doubleArray.Length);

//bool[] boolArray = new[] { false, true, false, true };

//int[] myIntArray = new int[5] { 5, 7, 9, 4, 6 };
//foreach (int i in myIntArray)
//{
//    Console.WriteLine($"{i}");
//}



//while (true)
//{
//    Console.WriteLine("Write a letter:");
//    var inputKey = Console.ReadKey(true);
//    Console.WriteLine($"Key: {inputKey.KeyChar}");
//}

int[] myArray = new int[] { 4, 7, 9, 0, 7, 5, 7, 4, 6, 3, 6, 3, 4, 0, 5, 6, 8 };

//for (int i = 0; i < myArray.Length; i++)
//{
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    if (i % 2 == 0)
//    {
//        Console.BackgroundColor = ConsoleColor.Red;
//        Console.WriteLine("{0, -20}", myArray[i]);
//    }
//    else
//    {
//        Console.BackgroundColor = ConsoleColor.Blue;
//        Console.WriteLine("{0, -20}", myArray[i]);
//    }
//}
//Console.ResetColor();

//while (true)
//{
//    Console.WriteLine("/");
//    System.Threading.Thread.Sleep(50);
//    Console.Clear();
//    Console.WriteLine("|");
//    System.Threading.Thread.Sleep(50);
//    Console.Clear();
//    Console.WriteLine("-");
//    System.Threading.Thread.Sleep(50);
//    Console.Clear();
//    Console.WriteLine("\\");
//    System.Threading.Thread.Sleep(50);
//    Console.Clear();
//}

//To-DO Application

//string[] todos = new[] { "abc,", "köpa glass", "laga bil" };
//bool[] isDone = new[] { false, false, true };

//string format = "{0, -40} {1, 11}";
//Console.WriteLine(format, "What Todo", "Is it done?");
//Console.WriteLine("-----------------------------------------------------");

//for (int i = 0; i < todos.Length; i++)
//{
//    string todo = todos[i];
//    string done = isDone[i];
//    if (isDone[i])
//        {
//        done = "yes";
//    } else
//    {
//        done = "no";
//    }
//    Console.WriteLine(format, todo, done);
//}


string[] currencyArray = new string[] { "SEK", "USD", "YEN", "EUR" };
string[] empty = new string[] { };

empty = currencyArray;
//Console.WriteLine("Välj en som ska bort");
//Console.WriteLine("1. SEK");
//Console.WriteLine("2. USD");
//Console.WriteLine("3. YEN");
//Console.WriteLine("4. EUR");

//int input = Convert.ToInt32(Console.ReadLine()) - 1;



int i = 0;
int pos;
int[] arr = new int[5] { 35, 50, 55, 77, 98 };

Console.WriteLine("Elements before deletion");
for (i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"{arr[i]}");
}

pos = 2;
for (i = pos - 1; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
    arr[i] = arr[i + 1];
}

Console.WriteLine("Elemants after deletion");
for (i = 0; i < 4; i++)
{
    Console.WriteLine($"{arr[i]}");
}


//for (int i = 0; i < currencyArray.Length; i++)
//{
//    if (input == i)
//    {
//        currencyArray[i] = null;
//    }
//}

//for (int i = 0; i < currencyArray.Length; i++)
//{
//        Console.WriteLine(currencyArray[i]);
//}


//Console.WriteLine(empty[0]);
//Console.WriteLine(empty[1]);
//Console.WriteLine(empty[2]);
//Console.WriteLine(empty[3]);