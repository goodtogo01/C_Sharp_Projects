using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsFrameWorks
{
    internal class ArraysTest_01
    {
        static void Main(string[] args)
        {
            // Print Array throu loop
            string[] ourPlanet = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Eclipse", "Saturn", "Neptune", "Urenus", "pluto" };

            Console.WriteLine("\nOur Planets list from soler-system Using For-Each Loop\n==========================================================");

            /*   foreach (string planets in ourPlanet)
               {
                   Console.WriteLine(planets);
               };*/
            Console.WriteLine(" Type of Planet No. that you want");
            Console.WriteLine("1 = Mercury.");
            Console.WriteLine("2 = Venus.");
            Console.WriteLine("3 = Earth.");
            
            var planetNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(ourPlanet[planetNumber]);


            Console.ReadKey();

        }

    }
}
