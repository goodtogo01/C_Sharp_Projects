using System;

namespace OOPs_Concepts
{
    public class Person
    {
        public string Name;

        public void introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public static Person Pars(string str) { 
            var p = new Person();
            p.Name = str;

            return p;   
        
        }
    }
}
