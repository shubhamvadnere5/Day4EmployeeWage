using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    class UC1
    {
        public static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int empCheck;
            Random random = new Random();
            empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
            Console.ReadLine();
        }


    }
}

    
