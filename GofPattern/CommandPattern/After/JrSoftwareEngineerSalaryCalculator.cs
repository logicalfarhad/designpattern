using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.After
{
    public class JrSoftwareEngineerSalaryCalculator : ISalaryCalculator
    {

        public double Calculate(double baseSalary)
        {
            return CalculateJrSoftwareEngineerSalary(baseSalary);
        }
        private static double CalculateJrSoftwareEngineerSalary(double baseSalary)
        {
            return baseSalary;
        }

    }
}
