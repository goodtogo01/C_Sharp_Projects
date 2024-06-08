using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsFrameWorks
{
    internal class Concepts_Arrays
    {
        static void Main2()
        {
            //Declear an array with Static means fixd length
            string[] empName = new string[3] { "Jhon", "Adam", "Sean" }; //Method: 1
            int[] empId = new int[3] { 11, 22, 33 }; //Method: 2
            int[] zipCode = new int[3]; //Method: 3
            zipCode[0] = 19082;
            zipCode[1] = 11101;
            zipCode[2] = 19026;
            Console.WriteLine("Print Zip-Code (Static) Using For-Each Loop, Where Length is more then decleared..\n==========================================================");
            foreach (int z in zipCode)
            {
                Console.WriteLine(z);
            };



            //Declear an array with Dynamic means length not fixd 
            string[] empName2 = { "Jibon", "Monor", "Charls", "Sandra", "Bandra", "Mike" };//Method: 1
            int[] empId2 = { 44, 55, 66, 77, 88, 99 };//Method: 2
            int[] zipCode2 = { 19011, 19033, 10023, 10054, 22241, 32104 };//Method: 3

            // Print Array throu loop
            string[] ourPlanet = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Eclipse", "Saturn", "Neptune", "Urenus", "pluto" };

            Console.WriteLine("\nOur Planets list from soler-system Using For-Each Loop\n==========================================================");

            foreach (string planets in ourPlanet)
            {
                Console.WriteLine(planets);
            };

            Console.WriteLine("\nOur Planets list from soler-system Using For-Each Loop\n==========================================================");
            for (int i = 0; i < ourPlanet.Length; i++)
            {
                Console.WriteLine(ourPlanet[i]);
            }


            Console.ReadKey();

        }
    }
}
