using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Inharitance
{
    internal class Program
    {
        static void Main(string[] args)


        {
            var text = new Text();
            text.Width = 100;
            text.Height = 500;
            text.DisplayPresentation();
            text.AddHyperLink("www.zsolution.com");
            text.DisplayText();
          
            Console.ReadKey();  
        }
    }

}
