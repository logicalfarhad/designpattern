using System;
using CommandPattern.After;

namespace CommandPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var salaryCalculator = new SalaryCalculator();//invoker

            salaryCalculator.AddSalaryCalculator(new JrSoftwareEngineerSalaryCalculator());
            salaryCalculator.CalculateSalary();


            salaryCalculator.AddSalaryCalculator(new ProjectManagerSalaryCalculator());
            salaryCalculator.CalculateSalary();

        } 
    }
}