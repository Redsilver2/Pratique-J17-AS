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
            new Meteo();

            Console.ReadKey();
        }
    }
}
