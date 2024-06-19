using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsFrameWorks
{
    internal class ArraysTest_02
    {
        static void Main2( ) {
            string[] ourPlanet = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Eclipse", "Eclipse" };
            string[] ourPlanet2 = new string[12]; // { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Eclipse", "Eclipse", "Saturn", "Neptune", "Urenus", "pluto" };
            
            //Original Arrays
            Console.WriteLine("\nArray: Our Planets list from soler-system old arrys\n==========================================================");
            foreach (string item in ourPlanet){
                Console.WriteLine(item);
            }

            //coping and merge new arrays and added two more item
            Console.WriteLine("\nArray: Our Planets list from soler-system after coping arrys\n==========================================================");
            Array.Copy(ourPlanet, ourPlanet2, 7);
            ourPlanet2[7] = "Urenus";
            ourPlanet2[8] = "Npetune";
            foreach (string item in ourPlanet2) { 
                Console.WriteLine(item);
            }
            
            // Arraylist 
            Console.WriteLine("\nArrayList : Our Planets list from soler-system Using For-Each Loop\n==========================================================");
            List<string> pList = new List<string>(ourPlanet2);
            pList.Add("Pluto");
            pList.Add("Saturn");
             
            foreach (string item in pList) { 
            Console.WriteLine(item);    
            }
            Console.ReadKey();
        }
    }
}
