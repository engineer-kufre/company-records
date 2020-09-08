using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyRecordsClassLib
{
    //an employee and department hybrid object class
    public class EmpAndDeptAnonType
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }

        public EmpAndDeptAnonType(string firstName, string lastName, string departmentName)
        {
            FirstName = firstName;
            LastName = lastName;
            DepartmentName = departmentName;
        }
    }
}
