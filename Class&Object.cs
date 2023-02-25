// Program.cs


using Class_Object;

Employee Sumit =  new Employee("Sumit", "Patil","Nashik", 25);

Employee Rajesh = new Employee("Rajesh", "khanna", "Mumbai", 55);

Sumit.workDoneHr = 12;
Rajesh.workDoneHr = 2;

Sumit.DisplayInfo();
Rajesh.DisplayInfo ();

Sumit.DoSomeWork();

Sumit.DisplayInfo();



// Employee.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public int age;
        public string city;
        public int workDoneHr;

        public Employee(string first, string last, string _city, int _age) // constructor
        {
            firstName = first;
            lastName = last;
            city = _city;
            age = _age;
        }

        public void DoSomeWork()
        {
            workDoneHr += 1;
        }
        public void DoSomeWork(int noOfHrs) => workDoneHr += noOfHrs;

        public void DisplayInfo()
        {
            Console.WriteLine($"name is {firstName + " " + lastName} and age is {age} and Workdonehr :{workDoneHr} and city = {city}");

        }


    }
}
