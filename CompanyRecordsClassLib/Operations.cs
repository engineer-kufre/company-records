using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRecordsClassLib
{
    //this class drives all app functionalities by implementing the IOperations inteface
    public class Operations : IOperations
    {
        //method for adding a new department to the database
        public bool CreateNewDepartment(string departmentName)
        {
            try
            {
                CompanyRecordsContext context = new CompanyRecordsContext();
                var department = new Department()
                {
                    DepartmentName = departmentName
                };

                context.Departments.Add(department);
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //method for adding a new employee to the database
        public bool CreateNewEmployee(string firstName, string lastName, string email, string phoneNumber, decimal salary, int departmentId)
        {
            try
            {
                CompanyRecordsContext context = new CompanyRecordsContext();
                Employee employee = new Employee()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    Salary = salary,
                    DepartmentId = departmentId
                };

                context.Employees.Add(employee);
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //method for editing an existing employee
        public bool UpdateEmployee(string firstname, string lastname, string email, string phoneNumber, decimal salary, int departmentId)
        {
            try
            {
                CompanyRecordsContext context = new CompanyRecordsContext();
                var emp = context.Employees.Where(e => e.Email == email)
                                                           .ToArray()[0];
                if (firstname != "")
                {
                    emp.FirstName = firstname;
                }
                if (lastname != "")
                {
                    emp.LastName = lastname;
                }
                if (phoneNumber != "")
                {
                    emp.PhoneNumber = phoneNumber;
                }
                if (salary != 0)
                {
                    emp.Salary = salary;
                }
                if (departmentId != 0)
                {
                    emp.DepartmentId = departmentId;
                }
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //method for deleting an existing department
        public bool DeleteDepartment(string departmentName)
        {
            try
            {
                CompanyRecordsContext context = new CompanyRecordsContext();
                var department = context.Departments.Where(d => d.DepartmentName == departmentName)
                                                                         .ToArray()[0];
                context.Departments.Remove(department);
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //method for deleting an existing employee
        public bool DeleteEmployee(string firstname, string email)
        {
            try
            {
                CompanyRecordsContext context = new CompanyRecordsContext();
                var emp = context.Employees.Where(e => e.FirstName == firstname && e.Email == email)
                                                           .ToArray()[0];
                context.Employees.Remove(emp);
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //method returns a list of names of departments with no employees
        public List<string> AllDepartmentsWithNoEmployee()
        {
            CompanyRecordsContext context = new CompanyRecordsContext();
            string sql = "Select Employees.Email, Employees.DepartmentId, Departments.DepartmentName from Employees Full Outer Join Departments On Employees.DepartmentId = Departments.DepartmentId where Employees.Email is NULL";
            var result = context.Departments
                                        .FromSqlRaw(sql)
                                        .Select(e => e.DepartmentName)
                                        .ToList();
            return result;
        }

        //method returns a list of all employees and all departments (assigned or not assigned)
        public List<EmpAndDeptAnonType> AllEmployeesAndAllDepartments()
        {
            var result = AllEmployeesAndDepartmentNames().Concat(AllDepartmentsWithNoEmployee()
                                                                                    .Select(e => new EmpAndDeptAnonType("", "", e)))
                                                                                    .ToList();
            return result;
        }

        //method returns a list of all assigned employees and their departments
        public List<EmpAndDeptAnonType> AllEmployeesAndDepartmentNames()
        {
            CompanyRecordsContext context = new CompanyRecordsContext();

            var result = context.Employees
                                        .Include(e => e.Department)
                                        .Select(e => new EmpAndDeptAnonType(e.FirstName, e.LastName, e.Department.DepartmentName))
                                        .ToList();
            return result;
        }

        //method returns a list of all assigned employees grouped by their departments
        public List<EmpAndDeptAnonType> AllEmployeesGroupedByDepartment()
        {
            CompanyRecordsContext context = new CompanyRecordsContext();

            var result = context.Employees
                                       .Include(e => e.Department)
                                       .OrderBy(d => d.Department.DepartmentName)
                                       .ThenBy(d => d.FirstName)
                                       .Select(e => new EmpAndDeptAnonType(e.FirstName, e.LastName, e.Department.DepartmentName))
                                       .ToList();
            return result;
        }

        //method returns a list of all employees earning over an inputted threshold
        public List<AnonType> EmployeesEarningOver(decimal salary)
        {
            CompanyRecordsContext context = new CompanyRecordsContext();

            var result = context.Employees
                                         .Include(e => e.Department)
                                         .Where(e => e.Salary > salary)
                                         .Select(e => new AnonType(e.FirstName, e.LastName, e.Department.DepartmentName, e.Salary))
                                         .ToList();
            return result;
        }
    }
}
