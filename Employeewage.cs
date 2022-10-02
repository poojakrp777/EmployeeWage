using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employeewage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int IS_ABSENT = 0;


        public int ComputeEmpWage(string company, int Emp_Rate_Per_Hr, int Number_Of_Working_Days, int Max_Hr_In_Month)
        {
            int emphrs = 0;
            int empwage = 0;
            int totalwage = 0;
            int totalworkingdays = 0;
            int totalworkinghrs = 0;

            while (totalworkinghrs <= Max_Hr_In_Month && totalworkingdays < Number_Of_Working_Days)
            {
                totalworkingdays++;
                Random random = new Random();
                int choice = random.Next(0, 3);

                switch (choice)
                {
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    case IS_ABSENT:
                        emphrs = 0;
                        break;
                }
                totalworkinghrs += emphrs;
                Console.WriteLine("Day" + totalworkingdays + ":" + "Employee Hours:" + emphrs);
                empwage = Emp_Rate_Per_Hr * emphrs;
                totalwage += empwage;

            }
            Console.WriteLine("Total Employee Wage:" + totalwage);
            Console.WriteLine("Total Working Hours:" + totalworkinghrs);
            Console.WriteLine("Total Working Days:" + totalworkingdays);
            return totalwage;
        }
    }
}
