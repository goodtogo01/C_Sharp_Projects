using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Pillers_Concepts
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Employee emp = new Employee();
            emp.SetSSN(123654789);
            emp.SetSEX('M');
            Console.WriteLine("SSN Number is : "+emp.GetSSN());
            Console.WriteLine("Sex : " + emp.GetSEX()); 

            var pp = new Person_Properties();
            pp.SetAge(36); //Method : 1 to create getter and setter
            pp.Birthdate = DateTime.Now; //Method : 2 to create getter and setter
            pp.PersonName = "Khosruz"; //Method : 3 to create getter and setter
            pp.SalaryMonthly = 12345; //Method : 3 to create getter and setter
            pp.PersonAddress = "508 Winfield Ave, Upper darby, PA, 19082";
            pp.display();

            pp.Birthdate = new DateTime(1985, 06, 18);
            Console.WriteLine("Age is : "+pp.GetAge());

            Console.WriteLine(Rev(123));

            HttpCookie cookie = new HttpCookie();
            cookie["Name"] = "Khosruz";
            Console.WriteLine(cookie["Name"]);
            cookie["key"] = "Your Name";
            cookie["value"] = "Zaman";
            Console.WriteLine("Name: "+cookie["key"]+"\nValue: " + cookie["value"]);*/


            Console.ReadKey();  
        }

        public static int Rev(int n) {
            return n.ToString().Reverse().Aggregate(0, (b,x) => 10 * b + x - '0');
             
        
            


        }


    }
}
