using System;

namespace OOPs_Inharitance
{
    public class Text : PresentationObject
    {
        public int FrontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a link to : " + url);
        }

        public void DisplayText()
        {
            Console.WriteLine("\nText class ===========================");
            Console.WriteLine("Font Size is : " + this.FrontSize + "\nFont Name:" + this.FontName);
        }
    }

}
