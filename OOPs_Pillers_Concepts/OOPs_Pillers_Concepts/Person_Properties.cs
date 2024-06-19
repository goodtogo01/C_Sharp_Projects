using System;

namespace OOPs_Pillers_Concepts
{
    public class Person_Properties

    {
        private int Age;
        private DateTime _birthdate;
        public int SalaryMonthly { get; set; }
        public string PersonAddress { get; set; }   

        //Method 1: Add Getter and Setter for particular field.
        public void SetAge(int age) { 
        this.Age=age;   
        }
        public int GetAge() {
            return Age;
        }

        //Method 2: Add Getter and Setter for particular field.
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        //Method 3: Add Getter and Setter for particular field.
        public string PersonName { get; set; }


        //Method 4: There is a tricks, Age is Dynamic and based on current Data&Time. 
        // We can only use {Get} Method and skipped {Set} method Due to get Age from
        // current date&time. below implementations:

        public int PersonAge { 
            get {
                var timeSpan = DateTime.Today - _birthdate;
                var year = timeSpan.Days / 365;

                return year;
            
            } 
        }



        public void display() {
            Console.WriteLine("Person Class with Properties concepts in c#.");
            Console.WriteLine("Person Name: "+PersonName+"\nPerson Age: "+GetAge()+"\nPerson DOB: "+_birthdate+"\nAddress: "
                +PersonAddress+"\nMonthly Salary: "+SalaryMonthly);
        }
    }
}
