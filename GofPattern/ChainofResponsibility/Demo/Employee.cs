using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainofResponsibility.Demo
{
    public class Employee
    {
        public String Name { get; set; }
        public int Days { get; set; }
        public Employee(String name, int days)
        {
            Name = name;
            Days = days;
        }
    }
}
