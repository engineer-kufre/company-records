using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyRecordsClassLib
{
    public class AnonType
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }
        public decimal Salary { get; set; }

        public AnonType(string firstName, string lastName, string departmentName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            DepartmentName = departmentName;
            Salary = salary;
        }
    }
}
