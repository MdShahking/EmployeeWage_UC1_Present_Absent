using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_UC1_Present_Absent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int EMP_PRESENT = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            Console.WriteLine("Random Value:" + empCheck);
            if (EMP_PRESENT == empCheck)
            {
                empHrs = 8;
                Console.WriteLine("Employee is present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee wage per day is:" + empWage);
            Console.ReadLine();

        }
    }
}