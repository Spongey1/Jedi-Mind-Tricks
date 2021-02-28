using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_Mind_Tricks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            Dictionary<string, int> droids = new Dictionary<string, int>();

            // Opgave 2
            droids.Add("Driton", 18);
            droids["John"] = 19;
            Console.WriteLine(droids.First());

            // Opgave 3
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false }
            };
            characters.Remove("han");

            // Opgave 4
            foreach (var item in droids)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

