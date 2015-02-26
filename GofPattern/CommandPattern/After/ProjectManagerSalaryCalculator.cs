using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.After
{
    public class ProjectManagerSalaryCalculator : ISalaryCalculator
    {
        public double Calculate(double baseSalary)
        {
            return CalculateProjectManagerSalary(baseSalary);
        }

        private static double CalculateProjectManagerSalary(double baseSalary)
        {
            return baseSalary * 3;
        }
    }
}
