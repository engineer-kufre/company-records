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

        private void createNewDeptButton_Click(object sender, EventArgs e)
        {
            DepartmentForm department = new DepartmentForm(Operations);
            department.Show();
        }

        private void deleteDeptButton_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm = new DepartmentForm(Operations);
            departmentForm.Show();
        }

        private void createNewEmpButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(Operations);
            employeeForm.Show();
        }

        private void updateEmpButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(Operations);
            employeeForm.Show();
        }

        private void deleteEmpButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(Operations);
            employeeForm.Show();
        }
    }
}
