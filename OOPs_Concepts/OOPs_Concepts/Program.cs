using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("\nBasic Classes Operations \n=======================================");
            // Method : 1 to access Class
            Person person = new Person();
            person.Name = "Khosruz";
            person.introduce("Jhon");
            Console.WriteLine("\n");

            // Method : 2 to access Class
            var person1 = new Person();
            person1.Name = "Zaman";
            person1.introduce("Sean");

            // Method : 2 to access Pars method
            var person2 = Person.Pars("Komola"); // for non static/instance method -- var p3 = new Person(); 
            person2.introduce("Komola");        // for non static/instance method -- var p = p3.Pars("jo"); 
                                                // for non static/instance method -- p.introduce("Kol"); 

            Console.WriteLine("\nCustomer Class \n=======================================");
            var customer = new Customer();

            customer.id = 11;
            customer.name = "Khosruz";
            Console.WriteLine(customer.id);
            Console.WriteLine(customer.name);

            Console.WriteLine("\nOrders Class \n=======================================");
            var order = new Order();
            //customer.orders = new List<Order>();
            customer.orders.Add(order); 
            
            Console.WriteLine("\nEmployee Class \n=======================================");
            var emp = new Employees
            {
                id = 123,
                firstName = "Khsouz",
                lastName = "Zaman",
                startDate = DateTime.Now,
            };
             emp.display();
            // Console.WriteLine("Method Concepts\n=======================================");
            var mc = new MethodConcepts(10,20, 30);
            mc.calculators(12, 14, 98);
            mc.calculators(12, 36);
            mc.calculators(6);

            */
            var cs = new Customer(1, "Khosru", 39);
            cs.display();


            //cs.promot();
            var cs1 = new Customer(1);
            cs1.Orders.Add(new Order());
            cs1.Orders.Add(new Order());
            cs1.promot();
            Console.WriteLine("\n---------------------\nNumber of Orders: "+cs1.Orders.Count);


            Console.ReadKey();
        }
    }
}
