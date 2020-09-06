namespace CompanyRecordsAppUI
{
    partial class DepartmentForm
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
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createDeptButton = new System.Windows.Forms.Button();
            this.deleteDeptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(151, 16);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(206, 27);
            this.departmentTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department Name";
            // 
            // createDeptButton
            // 
            this.createDeptButton.Location = new System.Drawing.Point(13, 64);
            this.createDeptButton.Name = "createDeptButton";
            this.createDeptButton.Size = new System.Drawing.Size(170, 29);
            this.createDeptButton.TabIndex = 2;
            this.createDeptButton.Text = "Create";
            this.createDeptButton.UseVisualStyleBackColor = true;
            this.createDeptButton.Click += new System.EventHandler(this.createDeptButton_Click);
            // 
            // deleteDeptButton
            // 
            this.deleteDeptButton.Location = new System.Drawing.Point(189, 64);
            this.deleteDeptButton.Name = "deleteDeptButton";
            this.deleteDeptButton.Size = new System.Drawing.Size(173, 29);
            this.deleteDeptButton.TabIndex = 2;
            this.deleteDeptButton.Text = "Delete";
            this.deleteDeptButton.UseVisualStyleBackColor = true;
            this.deleteDeptButton.Click += new System.EventHandler(this.deleteDeptButton_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 110);
            this.Controls.Add(this.deleteDeptButton);
            this.Controls.Add(this.createDeptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createDeptButton;
        private System.Windows.Forms.Button deleteDeptButton;
    }
}