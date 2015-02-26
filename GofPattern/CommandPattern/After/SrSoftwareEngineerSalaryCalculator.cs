using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.After
{
    public class SrSoftwareEngineerSalaryCalculator : ISalaryCalculator
    {

        public double Calculate(double baseSalary)
        {
            return CalculateSrSoftwareEngineerSalary(baseSalary);
        }
        private static double CalculateSrSoftwareEngineerSalary(double baseSalary)
        {
            return baseSalary * 2;
        }
    }
}
