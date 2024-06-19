using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsFrameWorks
{
    internal class DictionaryTest_01
    {
        static void Main(string[] args) {
            Console.WriteLine(" Dictionary in C#");

            Dictionary<int, string> emp = new Dictionary<int, string>()
            // Insert Data Method : 1
            {
                {001, "Jhon" },
                {002, "Modon"},
                {003, "Sudon"},
                {004, "Gedon"}
            };

            // Insert Data Method : 2
            emp.Add(005, "Lodon");

            // Insert Data Method : 1
            emp[006] = "Fadon";

            foreach (var item in emp)
            {
                if (emp.ContainsValue("Jhon"))
                {
                    Console.WriteLine(item);
                }
                else { 
                    Console.WriteLine("not found");
                }
            }
           
            Console.ReadKey();

        }
    }
}
