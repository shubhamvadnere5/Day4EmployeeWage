using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    //UC3
    class Salary
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

            if (empCheck == IS_FULL_TIME)
            {
                empPerHrDay = 8;
            }
            else if(empCheck == IS_PART_TIME)
            {
                
                empPerHrDay = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

            salary = empSalaryPerHr * empPerHrDay;
            Console.WriteLine("Daily employee Salary is:" + salary);
            Console.ReadLine(); 
        }


    }
}

    
