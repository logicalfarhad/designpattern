using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Before
{
    public class SalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            var salary = 0.0;
            const double baseSalary = 40000;
            switch (employee)
            {
                case Employee.Trainee:
                    salary = baseSalary / 2;    //Any other business logic goes here
                    break;
                case Employee.JuniorSoftwareEngineer:
                    salary = baseSalary;        //Any other business logic goes here
                    break;
                case Employee.SeniorSoftwareEngineer:
                    salary = baseSalary * 2;    //Any other business logic goes here
                    break;
                case Employee.ProjectManager:
                    salary = baseSalary * 3;    //Any other business logic goes here
                    break;
            }

            return salary;
        }
    }
}
