using System;

string[] currencies = new string[] { "SEK", "USD", "YEN" };

for


















//Console.WriteLine("Välj något att konvertera (Skriv siffran)");
//Console.WriteLine("------------------------------------------");
//Console.WriteLine("1. Valutor");
//Console.WriteLine("2. Längdenheter");
//Console.WriteLine("3. Måttenheter");S
//Console.WriteLine("------------------------------------------");

//var input = Convert.ToInt32(Console.ReadLine());



//switch (input)
//{
//    case 1:
//        string[] currencyArray = new string[] { "Svenska Kronor", "Euro", "USD Dollar", "Yen" };
//        Console.Clear();
//        Console.WriteLine("Du har valt att konvertera Valutor");
//        Console.WriteLine("Välj den valuta du vill konvertera från:");
//        Console.WriteLine("------------------------------------------");

//        for (int i = 0; i < currencyArray.Length; i++)
//        {
//            Console.WriteLine($"{i + 1}. {currencyArray[i]}");
//        }
//        Console.WriteLine("------------------------------------------");
//        int currencyIn = Convert.ToInt32(Console.ReadLine());
//        currencyIn -= 1; //Från 1-index till 0-Index
//        Console.Clear();

//        Console.WriteLine("Välj den valuta du vill konvertera till:");
//        Console.WriteLine("------------------------------------------");
       
//        for (int i = 0; i < currencyArray.Length; i++)
//        {
//            if (i != currencyIn)
//            {
//                Console.WriteLine($"{i + 1}. {currencyArray[i]}");
//            }
//        }
//        Console.WriteLine("------------------------------------------");
//        int currencyOut = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine($"Konvertera {currencyIn + 1} till {currencyOut}");

//        //Slutar här
//        break;
//    case 2:
//        Console.WriteLine("Du har valt att konvertera Längdenheter");
//        break;
//    case 3:
//        Console.WriteLine("Du har valt att konvertera Måttenheter");
//        break;
//    default:
//        Console.WriteLine("ERROR");
//        break;
//}