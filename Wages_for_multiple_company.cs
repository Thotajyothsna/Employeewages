﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_wage
{
    public class Wages_for_multiple_company
    {
        int IS_FULL_TIME = 2;
        int IS_PART_TIME = 1;
        
        public void month_wages(string company,int EMP_RATE_PER_HOUR,int NO_OF_WORKING_DAYS,int MAX_HOURS_IN_MONTH)
        {
            int totalEmpWages = 0;
            int empHrs = 0;
            int empWage = 0;

            int totalEmpHrs = 0;
            int TOTAL_WORKING_DAYS = 0;
            while (totalEmpHrs <= MAX_HOURS_IN_MONTH && TOTAL_WORKING_DAYS < NO_OF_WORKING_DAYS)
            {
                TOTAL_WORKING_DAYS++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("day:" + TOTAL_WORKING_DAYS + " emply hrs:" + empHrs);
            }
            totalEmpWages = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("total monthly wage for company:{0} is {1}", totalEmpWages,totalEmpWages);
        }

    }

}
