using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonProjet2
{
    internal class Meteo
    {
        public Meteo() 
        {
            Console.WriteLine("\n\n\t\t\tBienvenu à l'outil météo ");
            Console.WriteLine("\n\nEntrez une température en celcius:");

            float celcius    = float.Parse(Console.ReadLine());
            float fahrenheit = (celcius * 1.8f) + 32;

            Console.WriteLine($"\n\t\t\t{celcius}°C est égale à { Math.Round(fahrenheit, 2) }°F");
        }
    }
}
