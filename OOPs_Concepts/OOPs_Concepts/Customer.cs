using System;
using System.Collections.Generic;

namespace OOPs_Concepts
{
    public class Customer
    {
        public int id;
        public string name;
        public int age;
        public readonly List<Order> Orders = new List<Order>();

        public Customer() {
            Orders = new List<Order>();
        }
        public Customer(int id) {
            this.id = id;
        }
        public Customer(int id, string name, int age)
            : this(id) {
            this.name = name;
            this.age = age;
        }

        public void promot() { 
        //Orders = new List<Order>();  
        }

        public void display() { 
 
                Console.WriteLine("Employee Details\n-------------------------");
              Console.WriteLine("Id: " +id+"\nName: "+name+"\nAge: "+age); 
        }

    }
}
