using CompanyRecordsClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CompanyRecordsAppUI
{
    public partial class ViewFunctions : Form
    {
        private readonly IOperations Operations;
        public ViewFunctions(IOperations operations)
        {
            InitializeComponent();
            Operations = operations;
        }

        //click event displays all employees earning above the inputted threshold
        private void employeesEarningOverButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal threshold = decimal.Parse(thresholdTextBox.Text);
                var employeeList = Operations.EmployeesEarningOver(threshold);

                employeesEarningOverDataGridView.DataSource = employeeList;
            }
            catch
            {
                MessageBox.Show("Please enter a valid threshold");
            }
        }

        //click event displays all employees and their assigned departments
        private void employeesAndDepartmentsButton_Click(object sender, EventArgs e)
        {
            var resultList = Operations.AllEmployeesAndDepartmentNames();
            employeesAndDepartmentsDataGridView.DataSource = resultList;
        }

        //click event displays all employees grouped by their assigned departments
        private void employeesGrpByDepartmentsButton_Click(object sender, EventArgs e)
        {
            var resultList = Operations.AllEmployeesGroupedByDepartment();
            employeesGrpByDepartmentsDataGridView.DataSource = resultList;
        }

        //click event displays all departments with no employees
        private void deptsNoEmpsButton_Click(object sender, EventArgs e)
        {
            var resultList = Operations.AllDepartmentsWithNoEmployee();
            deptsNoEmpsListBox.DataSource = resultList;
            deptsNoEmpsListBox.DisplayMember = "Department";
        }

        //click event displays all employees and all departments
        private void allEmpsAndAllDeptsButton_Click(object sender, EventArgs e)
        {
            var resultlist = Operations.AllEmployeesAndAllDepartments();
            allEmpsAndAllDeptsDataGridView.DataSource = resultlist;
        }
    }
}
