using System;

string[] todos = new[] { "Laga bil", "Programmera", "Köp glass" };
bool[] isDone = new[] { false, false, true };

int actionId = -1;
while (true)
{
    Console.Clear();

    if (actionId != -1)
    {
        if (actionId == 1)
        {
            string format = "{0, -40} {1, 11}";
            Console.WriteLine(format, "What todo?", "Is it done?");
            Console.WriteLine("----------------------------------------------------");
            for (int i = 0; i < todos.Length; i++)
            {
                string todo = todos[i];
                string done;
                if (isDone[i])
                {
                    done = "Yes";
                }
                else
                {
                    done = "No";
                }
                Console.WriteLine(format, todo, done);
            }
        }
        else if (actionId == 2)
        {
            Console.WriteLine("What do you want to do?");
            string input = Console.ReadLine();

            string[] newTodos = new string[todos.Length + 1];
            for (int i = 0; i < todos.Length; i++)
            {
                newTodos[i] = todos[i];
            }
            newTodos[^1] = input;
            todos = newTodos;

            bool[] newIsDone = new bool[isDone.Length + 1];
            for (int i = 0; i < isDone.Length; i++)
            {
                newIsDone[i] = isDone[i];
            }
            newIsDone[^1] = false;
            isDone = newIsDone;
        }
        else if (actionId == 3)
        {
            Console.WriteLine("Which todo is done?");
            ConsoleKeyInfo input = Console.ReadKey(true);
            string todoIdAsString = input.KeyChar.ToString();
            int todoIndex = Convert.ToInt32(todoIdAsString);

            isDone[todoIndex - 1] = true;
        }
    }

    Console.WriteLine();
    Console.WriteLine("Select an action:");
    Console.WriteLine("1. List todos");
    Console.WriteLine("2. Add todo");
    Console.WriteLine("3. Mark done");
    
    ConsoleKeyInfo answer = Console.ReadKey(true);
    string answerAsString = answer.KeyChar.ToString();
    actionId = Convert.ToInt32(answerAsString);
}


