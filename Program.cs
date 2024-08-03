using System;
using System.Collections.Generic;

class Program
{
    // Define gameHistory as a class-level field
    private static List<int> gameHistory = new List<int>();

    static void Main()
    {
        GameLogic();
    }

    static void GameLogic()
    {
        bool game = true;
        while (game)
        {
            
            Console.WriteLine("Menu");
            Console.WriteLine("0. History\n 1. Add \n 2. Division");

            string option = Console.ReadLine();

            if (option == "0")
            {
                // Display the history
                foreach (int i in gameHistory)
                {
                  Console.WriteLine(i);

                } 
            }
            else if (option == "6")
            {
                game = false;
            }
            else
            {
                HandleGame(option);
            }
        }
    }

    static void HandleGame(string option)
    {
        Console.WriteLine("First number:");
        string inputOne = Console.ReadLine();
        Console.WriteLine("Second number:");
        string inputTwo = Console.ReadLine();

        int numberOne = int.Parse(inputOne);
        int numberTwo = int.Parse(inputTwo);

        switch (option)
        {
            case "1":
                AddNumbers(numberOne, numberTwo);
                break;
            case "2":
                SubtractNumbers(numberOne, numberTwo);
                break;
            case "3":
                MultiplyNumbers(numberOne, numberTwo);
                break;
            case "4":
                DivideNumbers(numberOne, numberTwo);
                break;
            default:
                Console.WriteLine("Not a valid option!");
                break;
        }
    }

    static void AddNumbers(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"\ta + b is equal to {result}");
        gameHistory.Add(result);
    }

    static void SubtractNumbers(int a, int b)
    {
        Console.WriteLine($"a - b is equal to {a - b}");
    }

    static void MultiplyNumbers(int a, int b)
    {
        Console.WriteLine($"a * b is equal to {a * b}");
    }

    static void DivideNumbers(int a, int b)
    {
        if (b != 0)
        {
            Console.WriteLine($"a / b is equal to {a / b}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}
