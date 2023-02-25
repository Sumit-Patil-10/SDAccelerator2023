/* Simple program to calculatesalary

Concepts Covered 
- Helper file
- Optional Parameter
- Expression bodied syntax
- string interpolation 
- Top level Statement feature
- Named argument
*/


using Method;

int amount =  15000;
int totalMonth = 8;
int incentive = 123;

int Salary = Class1.CalculateYearSalary(amount, totalMonth);

Console.WriteLine($"Yearly Salary + incentive == {Salary + incentive}");
 static int SimpleAddition(int firstValue, int secondValue) => firstValue + secondValue; // Expression bodied expression

SimpleAddition(firstValue: 10, secondValue: 20);


/*
Helper file (Class1.cs)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Class1
    {

        public static int CalculateYearSalary(int Salary, int NoOfMonthsWorked, int bonus = 123)
        {
            return (Salary * NoOfMonthsWorked);
        }

    }
}

