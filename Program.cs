using System;
using System.Collections.Generic;

namespace csharpFundamentals_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee
            {
                EmpCategory = Employee.Category.Casual
            };
            if (emp.EmpCategory == Employee.Category.Casual)
            {
                Console.WriteLine(
                emp.CalculateSalary(1000, 45));
            }
        }
    }

    
}
