using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CompanyRecordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyRecordsContext context = new CompanyRecordsContext();

            //CREATE new employee
            //Employee emp1 = new Employee()
            //{
            //    FirstName = "Akin",
            //    LastName = "Adesola",
            //    Email = "aakin@gmail.com",
            //    PhoneNumber = "08065783903",
            //    Salary = 255000,
            //    DepartmentId = 1
            //};

            //context.Employees.Add(emp1);
            //context.SaveChanges();

            //DELETE employee
            //var emp = context.Employees.Where(e => e.DepartmentId == 7)
            //                                            .ToArray()[0];
            //context.Employees.Remove(emp);
            //context.SaveChanges();

            //DELETE department
            //var dept = context.Departments.Where(e => e.DepartmentId == 7)
            //                                            .ToArray()[0];
            //context.Departments.Remove(dept);
            //context.SaveChanges();

            //UPDATE employee details
            //var emp = context.Employees.Where(e => e.FirstName == "Segun")
            //                                            .ToArray()[0];
            //emp.FirstName = "Segzy";
            //context.SaveChanges();

            //returns empolyees earning over 500000
            //var above150000 = context.Employees
            //                                        .Where(e => e.Salary > 500000)
            //                                        .ToList();
            //foreach (var item in above150000)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} from {item.Department} earns {item.Salary}");
            //}

            //returns all Employees and their department name
            //var allEmployees = context.Employees
            //                                        .Include(e => e.Department)
            //                                        .ToList();
            //foreach (var item in allEmployees)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} from the {item.Department.DepartmentName} department earns {item.Salary}");
            //}

            //display records grouped by departments
            //var recs = context.Employees
            //                           .Include(e => e.Department)
            //                           .ToList()
            //                           .OrderBy(d => d.Department.DepartmentName)
            //                           .ThenBy(d => d.FirstName)
            //                           .GroupBy(d => d.Department.DepartmentName);
            //foreach (var item in recs)
            //{
            //    Console.WriteLine($"{item.Key} department: ");
            //    foreach (var employee in item)
            //    {
            //        Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            //    }
            //}

            //display all departments not assigned any employee
            var Emps = context.Employees
                                       .ToList();
            var Depts = context.Departments
                                       .ToList();
            var grouped = Depts.GroupJoin(Emps,
                                            dept => dept.DepartmentId,
                                            emp => emp.DepartmentId,
                                            (dept, empy) => new
                                            {
                                                Employ = empy,
                                                DeptId = dept.DepartmentId
                                            });
            foreach (var item in grouped)
            {
                foreach (var emp in item.Employ)
                {
                    if(emp.FirstName == null)
                    {
                        Console.WriteLine(emp.Department.DepartmentName);
                        Console.WriteLine("in");
                    }
                    else
                    {
                        Console.WriteLine(emp.Department.DepartmentName);
                    }
                }
            }
        }
    }
}
