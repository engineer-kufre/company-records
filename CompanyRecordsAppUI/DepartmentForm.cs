﻿using CompanyRecordsClassLib;
using System.Windows.Forms;

namespace CompanyRecordsAppUI
{
    public partial class DepartmentForm : Form
    {
        private readonly IOperations Operations;
        public DepartmentForm(IOperations operations)
        {
            InitializeComponent();
            Operations = operations;
        }

        //click event to create a new department
        private void createDeptButton_Click(object sender, System.EventArgs e)
        {
            string departmentName = departmentTextBox.Text;
            bool response = Operations.CreateNewDepartment(departmentName);
            if (response == true)
            {
                MessageBox.Show($"{departmentName} department created!");
                departmentTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Operation Failed!");
            }
        }

        //click event to delete an existing department
        private void deleteDeptButton_Click(object sender, System.EventArgs e)
        {
            string departmentName = departmentTextBox.Text;
            bool response = Operations.DeleteDepartment(departmentName);
            if (response == true)
            {
                MessageBox.Show($"{departmentName} department deleted!");
                departmentTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Operation Failed!");
            }
        }
    }
}
