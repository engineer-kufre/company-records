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

        private void employeesAndDepartmentsButton_Click(object sender, EventArgs e)
        {
            var resultList = Operations.AllEmployeesAndDepartmentNames();
            employeesAndDepartmentsDataGridView.DataSource = resultList;
        }

        private void employeesGrpByDepartmentsButton_Click(object sender, EventArgs e)
        {
            var resultList = Operations.AllEmployeesGroupedByDepartment();
            employeesGrpByDepartmentsDataGridView.DataSource = resultList;
        }
    }
}
