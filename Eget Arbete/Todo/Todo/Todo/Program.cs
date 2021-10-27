using System;

string[] currentTodo = new string[] { "Handla", "Äta Glass", "Plugga" };
bool[] todoCheck = new bool[] { false, false, false };

while (true)
{
    Console.Clear();

    Console.WriteLine("Vad vill du göra?");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("1. Lista befintlig todo och status");
    Console.WriteLine("2. Lägg till ny todo");
    Console.WriteLine("3. Färdigmarkera en todo");
    Console.WriteLine("-----------------------------------");

    //Om en todo är avklarad markera den med Att göra / Avklarad
    string[] checkTodo = new string[100];
    for (int i = 0; i < todoCheck.Length; i++)
    {
        if (todoCheck[i])
        {
            checkTodo[i] = "Avklarad";
        }
        else
        {
            checkTodo[i] = "Att göra";
        }
    }

    var input = Convert.ToInt32(Console.ReadLine());

    //Lista befintliga todos & status
    if (input == 1)
    {
        Console.Clear();
        Console.WriteLine("Todo Lista");
        Console.WriteLine("-----------------------------");
        for (int i = 0; i < currentTodo.Length; i++)
        {

            Console.WriteLine($"{i + 1}. {currentTodo[i],-20} {checkTodo[i]}");
        }
        Console.WriteLine("-----------------------------");
        Console.ReadLine();
    }

    //Lägg till nya todos och lägg till status
    else if (input == 2)
    {
        Console.Clear();
        string[] addTodo = new string[currentTodo.Length + 1];
        Console.WriteLine("Vad vill du lägga till till din todo-lista");
        string inputNew = Console.ReadLine();
        for (int i = 0; i < currentTodo.Length; i++)
        {
            addTodo[i] = currentTodo[i];
        }
        addTodo[^1] = inputNew;
        currentTodo = addTodo;

        bool[] newBool = new bool[todoCheck.Length + 1];
        for (int i = 0; i < todoCheck.Length; i++)
        {
            newBool[i] = todoCheck[i];
        }
        newBool[^1] = false;
        todoCheck = newBool;
    }

    //Välj en todo för att klarmarkera 
    else if (input == 3)
    {
        Console.Clear();
        Console.WriteLine("Välj en todo för att mearkera den som avklarad");
        Console.WriteLine("-----------------------------");
        for (int i = 0; i < currentTodo.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {currentTodo[i],-20} {checkTodo[i]}");
        }
        Console.WriteLine("-----------------------------");

        var updateTodo = Convert.ToInt32(Console.ReadLine()) - 1;
        for (int i = 0; i < todoCheck.Length; i++)
        {
            if (updateTodo == i)
            {
                todoCheck[i] = true;
            }
        }
    }
}