using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    //UC3
    class EmployeeWage
    {
        public static void Main(string[] args)
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int empSalaryPerHr = 20;
            int empPerHrDay = 8;
            int empCheck;
            int salary;
            Random random = new Random();
            empCheck = random.Next(0, 3);

            switch(empCheck)
            {
                case 1:
                    Console.WriteLine("IS_PART_TIME");
                    empPerHrDay = 8;
                    break;
                case 2:
                    Console.WriteLine("IS_PART_TIME");
                    empPerHrDay = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    empPerHrDay = 0;
                    break;

            }
            salary = empSalaryPerHr * empPerHrDay;
            Console.WriteLine("Daily employee Salary is:" + salary);
            Console.ReadLine(); 
        }


    }
}

    
