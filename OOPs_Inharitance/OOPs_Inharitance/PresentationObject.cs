using System;

namespace OOPs_Inharitance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy() {
            Console.WriteLine("Object copied to clipboard. ");
        }
        public void Duplicate() {
            Console.WriteLine("Object was duplicated. ");
        }
        public void DisplayPresentation() {
            Console.WriteLine("Presentation class ===========================");
            Console.WriteLine("Width is : "+this.Width+"\nHeight is: "+this.Height);
        }
    } 
}
