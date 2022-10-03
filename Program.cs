using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            Console.WriteLine("Output of Total Employee wage and Save Total Wage of company as :");
            //Creating Object of the class to call in Main method
            //because method is non static

            Employeewage dmart = new Employeewage("Dmart", 20, 2, 10);
            Employeewage reliance = new Employeewage("Reliance", 10, 4, 20);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.toString());

            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}
