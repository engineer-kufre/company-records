namespace CompanyRecordsAppUI
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deptIdTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteEmpButton = new System.Windows.Forms.Button();
            this.createEmpButton = new System.Windows.Forms.Button();
            this.updateEmpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Department ID";
            // 
            // deptIdTextBox
            // 
            this.deptIdTextBox.Location = new System.Drawing.Point(127, 175);
            this.deptIdTextBox.Name = "deptIdTextBox";
            this.deptIdTextBox.Size = new System.Drawing.Size(275, 27);
            this.deptIdTextBox.TabIndex = 6;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(127, 142);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(275, 27);
            this.salaryTextBox.TabIndex = 6;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(127, 109);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(275, 27);
            this.phoneNumberTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(127, 76);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(275, 27);
            this.emailTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(127, 43);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(275, 27);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(127, 10);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(275, 27);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // deleteEmpButton
            // 
            this.deleteEmpButton.Location = new System.Drawing.Point(274, 221);
            this.deleteEmpButton.Name = "deleteEmpButton";
            this.deleteEmpButton.Size = new System.Drawing.Size(127, 29);
            this.deleteEmpButton.TabIndex = 7;
            this.deleteEmpButton.Text = "Delete";
            this.deleteEmpButton.UseVisualStyleBackColor = true;
            this.deleteEmpButton.Click += new System.EventHandler(this.deleteEmpButton_Click);
            // 
            // createEmpButton
            // 
            this.createEmpButton.Location = new System.Drawing.Point(13, 221);
            this.createEmpButton.Name = "createEmpButton";
            this.createEmpButton.Size = new System.Drawing.Size(127, 29);
            this.createEmpButton.TabIndex = 7;
            this.createEmpButton.Text = "Create";
            this.createEmpButton.UseVisualStyleBackColor = true;
            this.createEmpButton.Click += new System.EventHandler(this.createEmpButton_Click);
            // 
            // updateEmpButton
            // 
            this.updateEmpButton.Location = new System.Drawing.Point(144, 221);
            this.updateEmpButton.Name = "updateEmpButton";
            this.updateEmpButton.Size = new System.Drawing.Size(127, 29);
            this.updateEmpButton.TabIndex = 7;
            this.updateEmpButton.Text = "Update";
            this.updateEmpButton.UseVisualStyleBackColor = true;
            this.updateEmpButton.Click += new System.EventHandler(this.updateEmpButton_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 265);
            this.Controls.Add(this.updateEmpButton);
            this.Controls.Add(this.createEmpButton);
            this.Controls.Add(this.deleteEmpButton);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.deptIdTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deptIdTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button deleteEmpButton;
        private System.Windows.Forms.Button createEmpButton;
        private System.Windows.Forms.Button updateEmpButton;
    }
}