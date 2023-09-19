using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MonProjet2
{
    internal class Meteo
    {
        public Meteo() 
        {
            Console.WriteLine("\n\n\t\t\tWelcome to the weather tool.");

            string tempTypeInput = string.Empty;
          
            while (true)
            {
                Console.WriteLine("\n\nEnter the temperature type to convert in (C ou F): ");
                tempTypeInput = Console.ReadLine();

                if(tempTypeInput == "F" || tempTypeInput == "f" || tempTypeInput == "C" || tempTypeInput == "c")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Il y a une erreur!");
                }
            }

            string tempType = tempTypeInput == "C" || tempTypeInput == "c" ? "fahrenheit" : "celcius";

            Console.WriteLine($"\n\nEnter the temperature in " + tempType + ":");

            float temp       =   float.Parse(Console.ReadLine());
            float resultat   = tempType.Contains("fahrenheit") ? (temp - 32) / 1.8f : (temp * 1.8f) + 32;

            string sign1 = tempType.Contains("fahrenheit") ? "°F" : "°C";
            string sign2 = sign1.Contains("°F") ? "°C" : "°F";

            Console.WriteLine($"\n\t\t\t{temp.ToString() + sign1} is equal to {Math.Round(resultat, 2)}"
                + sign2 + ".");
        }
    }
}
