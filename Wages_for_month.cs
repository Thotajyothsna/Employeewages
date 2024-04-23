using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_wage
{
    class Wages_for_month
    {
        int IS_FULL_TIME = 2;
        int IS_PART_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;
        int NO_OF_WORKING_DAYS = 20;
        public void month_wages()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWages = 0;
            for (int day = 0; day < NO_OF_WORKING_DAYS; day++)
            {
                Random rand = new Random();
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWages += empWage;
                Console.WriteLine("EMP WAGE:{0}", empWage);
            }
            Console.WriteLine("total monthly wage he got is :{0}",totalEmpWages);
        }

    }
}
