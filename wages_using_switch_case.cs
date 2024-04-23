using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_wage
{
     class wages_using_switch_case
    {

        int IS_FULL_TIME = 2;
        int IS_PART_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;
        public void wage_using_switch()
        {
            int empHrs = 0;
            int empWage = 0;

            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            switch(empCheck)
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
            Console.WriteLine("EMP WAGE:{0}", empWage);

        }
    }
}
