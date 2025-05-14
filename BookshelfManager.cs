using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Swift;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ArrayBokhylle
{
    internal class BookshelfManager
    {
        string[] _shelves = new string[10];

        public void Run()
        {
            WelcomeMessage();
            HandleInput();
        }
        private void WelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("This is my bookshelf!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("""
                              1) View all shelf contents
                              2) Add item to shelf
                              3) Exit
                              """);
        }

        private void HandleInput()
        {
            var choice = Console.ReadKey(true);

            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    ViewAllShelves();
                    break;
                case ConsoleKey.D2:
                    AddItemsToShelf();
                    break;
                case ConsoleKey.D3:
                    Environment.Exit(420);
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }
        }
        private void ViewAllShelves()
        {
            var index = 0;
            foreach (var shelf in _shelves)
            {
                Console.WriteLine($"Shelf {index}: {shelf}");
                index++;
            }
            Console.ReadKey(true);
        }

        private void AddItemsToShelf()
        {
            Console.WriteLine("Pick a shelf:");
            var index = 0;
            foreach (var shelf in _shelves)
            {
                Console.WriteLine($"Shelf {index}: {shelf}");
                index++;
            }
            var isNum = int.TryParse(Console.ReadLine(), out var inputChoice);

            if (isNum && inputChoice <= _shelves.Length - 1 && inputChoice >= 0)
            {
                Console.WriteLine("What would you like to put there?");
                var input = Console.ReadLine();
                _shelves[inputChoice] = input;
            }
        }
    }
}
