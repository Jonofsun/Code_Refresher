using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Code_Refresher
{
    internal class Program
    {
        static List<Player> players = new List<Player>();
        static void Main(string[] args)
        {
            Player player = new Player("Nami", 20);
            Player player1 = new Player("Luffy", 99);
            Player player2 = new Player("Zoro", 96);
            Player player3 = new Player("Robin", 77);
            Player player4 = new Player("Usopp", 3);
            players.Add(player);
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);

            Console.WriteLine("Welcome: Press anything");
            Console.ReadKey();
            Menu();
        }
        static void Menu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n1 - Display All Players");
                Console.WriteLine("2 - Display Players with an Odd Number");
                Console.WriteLine("3 - Display Players starting with a letter");
                Console.WriteLine("4 - Add Player");
                Console.WriteLine("e - Exit\n");
                Console.Write("USER selection: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        DisplayAllPlayers();
                        break;
                    case "2":
                        DisplayPlayersOdd();
                        break;
                    case "3":
                        DisplayLetterIndex();
                        break;
                    case "4":
                        AddPlayer();
                        break;
                    case "e":
                        Console.WriteLine("Good Bye");
                        Console.ReadKey();
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("\nInvalid selection\n");
                        break;
                }
            }
        }
        static void DisplayAllPlayers()
        {
            Console.WriteLine("\nAll Players:");
            foreach (Player p in players)
            {
                Console.WriteLine(p.ToString());
            }
        }
        static void DisplayPlayersOdd()
        {
            Console.WriteLine("\nPlayers with Odd Numbers:");
            foreach (var p in players)
            {
                if (p.Number % 2 != 0)
                {
                    Console.WriteLine($"{p.Name} - Lvl: {p.Number}");
                }
            }
        }
        static void DisplayLetterIndex()
        {
            Console.Write("Enter a letter: ");
            char letter = char.ToLower(Console.ReadLine()[0]);

            Console.WriteLine($"\nPlayers with Names Starting with '{letter}':");
            foreach (var p in players)
            {
                if (char.ToLower(p.Name[0]) == letter)
                {
                    Console.WriteLine($"{p.Name}  - Lvl: {p.Number}");
                }
            }
        }
        static void AddPlayer()
        {
            Console.Write("Enter player's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter player's Level: ");
            int number = int.Parse(Console.ReadLine());
            Player player = new Player(name, number);
            players.Add(player);
            Console.WriteLine($"Player {name} added successfully.");
        }
    }
}
