using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonProjet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string username = Console.ReadLine();

            Console.WriteLine($"\n\t\t\tHi {username},\n\t\t\tWelcome to MyProjet2 ");

            while (true)
            {
                Console.WriteLine("\n\nChoose an option (weather, money or quit): ");
                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "weather":
                        new Meteo();
                        break;

                    case "money":
                        new Money();
                        break;

                    case "quit":
                        Console.WriteLine("Have a nice day :D");
                        Console.ReadKey();
                        return;

                    default:
                        Console.WriteLine("The option is invalid.");
                        break;
                }
            }
        }
    }
}
