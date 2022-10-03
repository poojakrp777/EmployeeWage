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
            Console.WriteLine("Output of Employee wage for Multiple Company Using Interface Approach :");

            //Creating Object of the class to call in Main method
            //because method is non static

            EmpWageBuilderArray builder = new EmpWageBuilderArray();
            builder.addCompanyEmpWage("Dmart", 20, 2, 10);
            builder.addCompanyEmpWage("Reliance", 10, 4, 20);
            builder.computeEmpWage();
        }
    }
}
