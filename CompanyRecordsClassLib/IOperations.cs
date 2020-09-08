using System.Collections.Generic;
using System.Linq;

namespace CompanyRecordsClassLib
{
    //the IOperations interface is implemented by the Operations class
    public interface IOperations
    {
        bool CreateNewEmployee(string firstname, string lastname, string email, string phoneNumber, decimal salary, int departmentId);
        bool CreateNewDepartment(string departmentName);
        bool DeleteEmployee(string firstname, string email);
        bool DeleteDepartment(string departmentName);
        bool UpdateEmployee(string firstName, string lastName, string email, string phoneNumber, decimal salary, int departmentId);
        List<AnonType> EmployeesEarningOver(decimal salary);
        List<EmpAndDeptAnonType> AllEmployeesAndDepartmentNames();
        List<EmpAndDeptAnonType> AllEmployeesGroupedByDepartment();
        List<string> AllDepartmentsWithNoEmployee();
        List<EmpAndDeptAnonType> AllEmployeesAndAllDepartments();
    }
}
