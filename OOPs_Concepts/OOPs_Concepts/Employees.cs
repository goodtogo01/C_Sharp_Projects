using System;

namespace OOPs_Concepts
{
    public class Employees
    {
        public int id;
        public string firstName;
        public string lastName;
        public DateTime startDate;

        public void display()
        {
            Console.WriteLine("Id: "+id+"\nFirst Name: "+firstName+"\nLast Name: "+lastName+"\nDate Of Employment: "+ startDate);
        }

    }
}
