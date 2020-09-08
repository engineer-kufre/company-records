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
    public partial class CRUDFunctions : Form
    {
        private readonly IOperations Operations;
        public CRUDFunctions(IOperations operations)
        {
            InitializeComponent();
            Operations = operations;
        }

        //click event to create and show department form
        private void createNewDeptButton_Click(object sender, EventArgs e)
        {
            DepartmentForm department = new DepartmentForm(Operations);
            department.Show();
        }

        //click event to create and show department form
        private void deleteDeptButton_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm = new DepartmentForm(Operations);
            departmentForm.Show();
        }

        //click event to create and show employee form
        private void createNewEmpButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(Operations);
            employeeForm.Show();
        }

        //click event to create and show employee form
        private void updateEmpButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(Operations);
            employeeForm.Show();
        }

        //click event to create and show employee form
        private void deleteEmpButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(Operations);
            employeeForm.Show();
        }
    }
}
