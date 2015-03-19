using System.Collections.Generic;

namespace CompositeDesignPattern.Before
{
    public class EmployeeRepository
    {
        private readonly List<Employee> _employeeList;
        //public EmployeeRepository()
        //{
        //    _employeeList = new List<Employee>
        //    {
        //        new Employee
        //        {
        //            Name = "Forhad",
        //            EmployeeId = 1,
        //            Designation = "Associate Software Engineer",
        //            Email = "Forhad.Ali@bd.imshealth.com",
        //            TeamName = "Mobile & Sharepoint Team"
        //        },
        //        new Employee
        //        {
        //            Name = "Adib",
        //            EmployeeId = 2,
        //            Designation = "Associate Software Engineer",
        //            Email = "Adib@bd.imshealth.com",
        //            TeamName = "Application Pool"
        //        },
        //        new Employee
        //        {
        //            Name = "Ponir",
        //            EmployeeId = 3,
        //            Designation = "Associate Software Engineer",
        //            Email = "Ponir@bd.imshealth.com",
        //            TeamName = "Pricing Team"
        //        },
        //        new Employee
        //        {
        //            Name = "Tonmoy",
        //            EmployeeId = 4,
        //            Designation = "Associate Software Engineer",
        //            Email = "Tonmoy@bd.imshealth.com",
        //            TeamName = "Database Team"
        //        }
        //    };
        //}
        public List<Employee> GetAllEmployee()
        {
            return _employeeList;
        }
    }
}
