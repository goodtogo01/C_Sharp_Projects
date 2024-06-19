using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsFrameWorks
{
    internal class ArraysTest_01
    {
        static void array_01()
        {
            // Print Array throu loop
            string[] ourPlanet = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Eclipse", "Eclipse", "Saturn", "Neptune", "Urenus", "pluto" };

            Console.WriteLine("\nOur Planets list from soler-system Using For-Each Loop\n==========================================================");

       /*    Console.WriteLine(" Type of Planet No. that you want");
            Console.WriteLine("1 = Mercury.");
            Console.WriteLine("2 = Venus.");
            Console.WriteLine("3 = Earth.");*/

            /* var planetNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(ourPlanet[planetNumber]);*/
            Console.WriteLine("Before Operations of Original Arrays\n==========================================================");
            
            foreach (var planet in ourPlanet) { 
                Console.WriteLine(planet); 
            }

            //Reverse
            Console.WriteLine("\nAfter Reversed of Original Arrays\n==========================================================");
            Array.Reverse(ourPlanet);
            foreach (var planet in ourPlanet) {
                Console.WriteLine(planet);
            }

            //sort
            Console.WriteLine("\nAfter Sort of Original Arrays\n==========================================================");
            Array.Sort(ourPlanet);
            foreach (var planet in ourPlanet){
                Console.WriteLine(planet);
            }

            //find Duplicates
            //var duplicateItems = ourPlanet.GroupBy(x => x).Where(x => x.Count() > 1).Select(g =>g.Key);
            if (ourPlanet.Distinct().Count() != ourPlanet.Count()) { 
                foreach (var planet in ourPlanet) { 
               // Console.WriteLine("Duplicate items found : " + planet);
                           
                }

            };

          







            //find particuler item 
            Console.WriteLine("One or more planet begiens with '[D]': {0}", Array.Exists(ourPlanet, element =>element.StartsWith("M")));


            Console.ReadKey();

        }
        
    }
}
