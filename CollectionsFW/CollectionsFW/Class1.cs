using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsFW
{
    internal class ArraysTest_01
    {
        static void Main(string[] args)
        {
            string[] arrPlanets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Eclipse", "Saturn", "Neptune", "Urenus", "pluto" };
            foreach (string planet in arrPlanets) {
                Console.WriteLine(planet);


            }
            Console.ReadKey();  
        
        }
    }
}
