// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
class Program
{
    // Liste de tâche ( en mémoire )
    static List<string> tasks = new List<string>();
    static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("-- Gestionnaire des taches --");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Show task");
            Console.WriteLine("3. Quite");
            Console.Write("Your choice : ");

            string input = Console.ReadLine();

            switch (input) {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTask();
                    break;
                case "3":
                    isRunning = false;
                    Console.WriteLine("U R Out !");
                    break;
                default:
                    Console.WriteLine("Invalid Choice, Click any key to continue ... ");
                    break;
            }
        }
    }
    // Fcts 
    static void AddTask()
    {
        Console.Write("Enter Task Name : ");

        string task = Console.ReadLine();
        tasks.Add(task);

        Console.WriteLine("task added");
        Console.WriteLine("Click any key to continue ... ");
        Console.ReadKey();
    }
    static void ShowTask()
    {
        Console.WriteLine("-- Task's List --");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No Task");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
        Console.WriteLine("Click any key to continue ...");
        Console.ReadKey();
    }
}