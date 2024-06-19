using System;
using System.Security.Cryptography;

namespace OOPs_Concepts
{
    public class MethodConcepts
    {
        public int a;
        public int b;
        public int c;   

        public MethodConcepts(int a,int b, int c ) {
  
            this.a = a;
            this.b = b; 
            this.c = c;
        }

        public void calculators(int a, int b, int c)
        {
            Console.WriteLine("\nThis method contains 3 params.\n=====================================");
            this.a = a;
            this.b = b;
            this.c = c;

            int cal = (a + b + c);
            Console.WriteLine("The calculation is for : " + a + "+" + b + "+" + c + " = " + cal);
        }
        public void calculators(int a, int b) {
            this.a = a;
            this.b = b;
            Console.WriteLine("\nThis method contains 2 params.\n=====================================");
            int cal = (a - b);
            Console.WriteLine("The calculation is for : " + a  + " - " + b +" = " + cal);
        }
        public  void calculators(int a)
        {
            this.a = a;
          
            Console.WriteLine("\nThis method contains 1 params.\n====================================");
            if (a >= 5) {
            Console.WriteLine("User input is : "+a);
                a += 10;
                Console.WriteLine("New Value After Calculation of User input : " + a);
            }
            int cal = (a * 5);
            Console.WriteLine("The calculation done based on user input : "+ cal);
        }

        public void mm(int a) {
            a += 2;

            Console.WriteLine(a);
        }

        public void tt(ref int a) {
            a += 2;
            Console.WriteLine(a);
        }
    }
}
