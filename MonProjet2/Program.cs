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


            Console.WriteLine("Entrer votre nom: ");
            string username = Console.ReadLine();

            Console.WriteLine($"\n\t\t\tBonjour {username},\n\t\t\tBienvenu à MonProjet2 ");

            new Meteo();


            Console.ReadKey();
        }
    }
}
