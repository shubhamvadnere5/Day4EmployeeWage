using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    //UC2
    class Salary
    {
        public static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int empSalaryPerHr = 20;
            int empPerHrDay = 8;
            int empCheck;
            int salary;
            Random random = new Random();
            empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Present");
                empPerHrDay = 8;
            }
            else
            {
                Console.WriteLine("Absent");
                empPerHrDay = 0;
            }
            salary = empSalaryPerHr * empPerHrDay;
            Console.WriteLine("Salary is:" + salary);
            Console.ReadLine();
        }


    }
}

    
