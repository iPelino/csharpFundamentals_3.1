using System;
using System.Collections.Generic;

namespace csharpFundamentals_3._1
{
    internal class Employee
    {
        // properties
        public string EmpNumber { get; set; }
        public string EmpName { get; set; }
        public Category EmpCategory { get; set; }
        public Gender EmpGender { get; set; }
        public Employee()
        {
            
        }
        public enum Category
        {
            Casual,
            Permanent,
        }
        public enum Gender
        {
            Female,
            Male,
            Other,
        }

        // methods
        public double CalculateSalary(double hourlyRate, double hours)
        {
            var totalPay = hourlyRate * hours;
            var deductions = (totalPay * 0.03) + (totalPay * 0.15);
            return totalPay - deductions;
        }
        
        public double CalculateSalary(double grossSalary)
        {
            var deductions = (grossSalary * 0.11) + (grossSalary * 0.3);
            return grossSalary - deductions;
        }
    }
}