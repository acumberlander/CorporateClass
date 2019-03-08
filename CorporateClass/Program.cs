using System;
using System.Collections.Generic;

namespace CorporateClass
{
    public class Company
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        
        //Properties

        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees

        public List<Employee> employees { get; set; }


        // Create a method that allows external code to add an employee

        public void AddEmployee()
        {
            
        }

        // Create a method that allows external code to remove an employee

        public void RemoveEmployee()
        {

        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }

    }
}
