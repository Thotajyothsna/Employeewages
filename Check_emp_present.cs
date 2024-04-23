using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_wage
{
     class Check_emp_present
    {

      
        int IS_FULL_TIME = 1;
        public void IsPresent()
        {
            Random Rand = new Random();
            int empCheck = Rand.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");

            }


        }
    }

}
