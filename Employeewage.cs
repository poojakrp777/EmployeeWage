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

        private string company;
        private int Emp_Rate_Per_Hr;
        private int Number_Of_Working_Days;
        private int Max_Hr_In_Month;
        private int totalEmpWage;
        public Employeewage(string company, int Emp_Rate_Per_Hr, int Number_Of_Working_Days, int Max_Hr_In_Month)
        {
            this.company = company;
            this.Emp_Rate_Per_Hr = Emp_Rate_Per_Hr;
            this.Number_Of_Working_Days = Number_Of_Working_Days;
            this.Max_Hr_In_Month = Max_Hr_In_Month;
        }
        //Method is return type so it must return value
        public void computeEmpWage()
        {
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;

            ///While loop is used to check maximum working hours and number of working days.
            ///if it is true then it allows.
            while (totalEmpHrs <= Max_Hr_In_Month && totalWorkingDays < Number_Of_Working_Days)
            {
                totalWorkingDays++;
                Random random = new Random();
                //Switch case is used to check wheather employee is working as for part time or full time
                //according to that employee attendance employee hours will be taken.
                switch (random.Next(1, 3))
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_ABSENT:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;

                Console.WriteLine("Day " + totalWorkingDays + " : " + "Emp Hr: " + empHrs);

            }
            totalEmpWage = Emp_Rate_Per_Hr * totalEmpHrs;
            Console.WriteLine("Total EmpWage for company :" + company + "is " + totalEmpWage);
        }
        public string toString()
        {
            return "Total EMPWAge for Company :" + company + "is " + totalEmpWage;
        }
    }
}
