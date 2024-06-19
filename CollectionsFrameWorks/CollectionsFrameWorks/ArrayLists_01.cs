using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsFrameWorks
{
    internal class ArrayLists_01
    {
        static void Main9() {
            List<string> names = new List<string>();
            names.Add("Bruce");
            names.Add("Alfred");
            names.Add("Tim");
            names.Add("Richard");
            names.ForEach(x => Console.WriteLine(x));

            names.ForEach(delegate (string name)
            {
                Console.WriteLine(name);
            });

            Console.ReadKey();
        }
        void Print(string s) {
            Console.WriteLine(s);

        }
    }
}
