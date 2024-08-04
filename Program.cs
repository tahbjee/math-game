using System;
using System.Collections.Generic;
using System.Data;

class Program
{
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
            
            Console.WriteLine("\t---- Menu ----\n");
            Console.WriteLine(" \t0. History\n \t1. Add \n \t2. Division\n \t3. Multiply\n \t4. Division\n \t5. Exit\n");
            Console.WriteLine("\t--------------");

            string option = Console.ReadLine();

            try 
            {
                int convertOptionInt = Int32.Parse(option);
                game = RunGame(convertOptionInt, game);
            }
            catch(Exception) 
            {
                Console.WriteLine("Error");
            }
        }
    }

static bool RunGame(int convertOptionInt, bool game) {
            if (convertOptionInt == 0)
            {
                Console.WriteLine("\t--------------\n");
                Console.WriteLine("\tGame History:");
                foreach (int i in gameHistory)
                {
                  Console.WriteLine($"\t {i} ");

                } 
                Console.WriteLine("\t--------------\n");
            }
            else if (convertOptionInt == 5)
            {
               return game == false;
            }
            else if (convertOptionInt < 0 ||  convertOptionInt > 5) {
                Console.WriteLine("Not a valid input, try another number!");
            }
            else
            {
                HandleGame(convertOptionInt);
            }
                return true;
            }
    static void HandleGame(int convertOptionInt)
    {
        Console.WriteLine("First number:");
        string inputOne = Console.ReadLine();
        Console.WriteLine("Second number:");
        string inputTwo = Console.ReadLine();

        int numberOne = int.Parse(inputOne);
        int numberTwo = int.Parse(inputTwo);

        switch (convertOptionInt)
        {
            case 1:
                AddNumbers(numberOne, numberTwo);
                break;
            case 2:
                SubtractNumbers(numberOne, numberTwo);
                break;
            case 3:
                MultiplyNumbers(numberOne, numberTwo);
                break;
            case 4:
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
    Console.WriteLine($"\t{a} plus {b} is equal to {result}\t\n");
        gameHistory.Add(result);
    }

    static void SubtractNumbers(int a, int b)
    {
        int result = a - b;
    Console.WriteLine($"\t{a} minus {b} is equal to {result}\t\n");
        gameHistory.Add(result);
    }

    static void MultiplyNumbers(int a, int b)
    {
        int result = a * b;
    Console.WriteLine($"\t{a} multiplied by {b} is equal to {result}\t\n");
        gameHistory.Add(result);
    }

    static void DivideNumbers(int a, int b)
    {
        if (b != 0)
        {
            int result = a / b;
        Console.WriteLine($"\t{a} divided by {b} is equal to {result}\t\n");
            gameHistory.Add(result);
        }
        else
        {
            Console.WriteLine("\tCannot divide by zero.\n");
        }
    }
};