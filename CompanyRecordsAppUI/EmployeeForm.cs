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
    public partial class EmployeeForm : Form
    {
        private readonly IOperations Operations;
        public EmployeeForm(IOperations operations)
        {
            InitializeComponent();
            Operations = operations;
        }

        //click event to create a new employee
        private void createEmpButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            decimal salary;
            if (salaryTextBox.Text == "")
            {
                MessageBox.Show("Please enter salary!");
                return;
            }
            else
            {
                salary = decimal.Parse(salaryTextBox.Text);
            }
            int departmentId;
            if (deptIdTextBox.Text == "")
            {
                MessageBox.Show("Please enter department Id!");
                return;
            }
            else
            {
                departmentId = int.Parse(deptIdTextBox.Text);
            }

            bool response = Operations.CreateNewEmployee(firstName, lastName, email, phoneNumber, salary, departmentId);
            if(response == true)
            {
                MessageBox.Show("Employee created!");
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
                phoneNumberTextBox.Text = "";
                salaryTextBox.Text = "";
                deptIdTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Operation Failed!");
            }
        }

        //click event to update an existing employee
        private void updateEmpButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            decimal salary;
            if (salaryTextBox.Text == "")
            {
                salary = 0;
            }
            else
            {
                salary = decimal.Parse(salaryTextBox.Text);
            }
            int departmentId;
            if (deptIdTextBox.Text == "")
            {
                departmentId = 0;
            }
            else
            {
                departmentId = int.Parse(deptIdTextBox.Text);
            }

            bool response = Operations.UpdateEmployee(firstName, lastName, email, phoneNumber, salary, departmentId);
            if (response == true)
            {
                MessageBox.Show("Employee updated!");
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
                phoneNumberTextBox.Text = "";
                salaryTextBox.Text = "";
                deptIdTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Operation Failed!");
            }
        }

        //click event to delete an existing employee
        private void deleteEmpButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string email = emailTextBox.Text;

            bool response = Operations.DeleteEmployee(firstName, email);
            if (response == true)
            {
                MessageBox.Show("Employee deleted!");
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
                phoneNumberTextBox.Text = "";
                salaryTextBox.Text = "";
                deptIdTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Operation Failed!");
            }
        }
    }
}
