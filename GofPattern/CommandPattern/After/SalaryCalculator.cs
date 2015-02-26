using System;
using System.Collections.Generic;

namespace CommandPattern.After
{
    public class SalaryCalculator
    {
        private double BaseSalary { get; set; }
        private Stack<ISalaryCalculator> _salaryCalculator = new Stack<ISalaryCalculator>();

        public SalaryCalculator()
        {
            BaseSalary = 40000;
        }
        public void CalculateSalary()
        {
            ISalaryCalculator calculator = _salaryCalculator.Pop();
            double salary = calculator.Calculate(BaseSalary);
            Console.WriteLine(salary);
        }


        public void AddSalaryCalculator(ISalaryCalculator salaryCalculator)
        {
            _salaryCalculator.Push(salaryCalculator);
        }
    }
}
