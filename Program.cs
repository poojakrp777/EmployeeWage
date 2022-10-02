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
            Console.WriteLine("Output of Total Employee wage for a Month  :");
            Employeewage emp = new Employeewage();
            emp.ComputeEmpWage("Reliance", 20, 25, 150);
            emp.ComputeEmpWage("D-Mart", 15, 20, 100);
        }
    }
}
