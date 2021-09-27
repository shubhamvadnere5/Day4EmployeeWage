using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    //UC6
    class EmployeeWage
    {
        public const int IS_FULL_TIME = 1;   //constants means when you dont want to override existing variables (unchangable and readonly)
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int salary = 0;
            int EmpPerHrs = 0;
            int empWorkingDays = 0;

            while (EmpPerHrs <= MAX_WORKING_HRS && empWorkingDays <= NUM_OF_WORKING_DAYS)
            {
                empWorkingDays++;
                Random random = new Random(); //predefine random class for generating random values
                int empCheck = random.Next(0, 3); //for min(0) to max(3) values

               
                switch (empCheck)  // switch case evaluates the expression and run the cases accordingly Option = 1 then case 1 will get executed
                {
                    case 1:
                        Console.WriteLine("IS_FULL_TIME");
                        empHrs = 8;
                        break;
                    case 2:
                        Console.WriteLine("IS_PART_TIME");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }

                EmpPerHrs += empHrs;
                Console.WriteLine("Days:" + empWorkingDays + "Emp Hrs: " + empHrs);
            }
            salary = EmpPerHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total employee Salary:" + salary);
            Console.ReadLine();
        }
    }
}
