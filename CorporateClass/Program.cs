using System;
using System.Collections.Generic;

namespace CorporateClass
{
    public class Company
    {

        //Properties

        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees

        public List<Employee> Employees { get; set; }

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

        //Constructor for Employee List
        //private Company(List<Employee> employees)
        //{
        //    Employees = employees;
        //}

        List<Employee> GKEmployees = new List<Employee>();
        

        // Create a method that allows external code to add an employee

        public void AddEmployee()
        {

        }

        // Create a method that allows external code to remove an employee

        public void RemoveEmployee()
        {

        }


        static void Main(string[] args)
        {
        //GrassKisser Company
        Company GrassKisser = new Company("GrassKisser", DateTime.Parse("02/15/2019"));


        //Employees
        Employee owner = new Employee("Zachery Cumberlander", "CEO", DateTime.Parse("11/13/2013"));
        Employee developer = new Employee("Austin Cumberlander", "CTO", DateTime.Parse("02/15/2019"));
        Employee investor = new Employee("Mark Cuban", "Investor", DateTime.Parse("02/15/2019"));
        
        List<Employee> GKEmployees = new List<Employee>();
        GKEmployees.Add(owner);
        GKEmployees.Add(developer);
        GKEmployees.Add(investor);
        
        
        foreach(var employee in GKEmployees)
            {
                var Name = employee.Name;
                var Job = employee.JobTitle;
                var Start = employee.StartDate;

                Console.WriteLine(Name);
                Console.WriteLine(Job);
                Console.WriteLine(Start);
                Console.WriteLine("");
            }

        Console.WriteLine("Hello World!");
        Console.ReadLine();
        }
    }

}
      
