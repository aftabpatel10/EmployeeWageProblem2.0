using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation program");
         
            int EMP_IS_PRESENT = 1;
            Random r = new Random();
            int employeeinput = r.Next(0, 2);

             if (EMP_IS_PRESENT == employeeinput)
                    Console.WriteLine("Employee is Present");
             else
                    Console.WriteLine("Employee is Absent");
            

        }
    }
}
