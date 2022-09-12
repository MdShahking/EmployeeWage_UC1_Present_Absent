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
            int empPresent = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
                Console.WriteLine("Random Value:" + empCheck);
            if (empPresent == empCheck)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
                Console.ReadLine();
            }
        }
    }
