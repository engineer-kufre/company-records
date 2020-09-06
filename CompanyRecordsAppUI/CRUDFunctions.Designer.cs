namespace CompanyRecordsAppUI
{
    partial class CRUDFunctions
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
            this.deleteEmpButton = new System.Windows.Forms.Button();
            this.deleteDeptButton = new System.Windows.Forms.Button();
            this.updateEmpButton = new System.Windows.Forms.Button();
            this.createNewEmpButton = new System.Windows.Forms.Button();
            this.createNewDeptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteEmpButton
            // 
            this.deleteEmpButton.Location = new System.Drawing.Point(12, 152);
            this.deleteEmpButton.Name = "deleteEmpButton";
            this.deleteEmpButton.Size = new System.Drawing.Size(268, 29);
            this.deleteEmpButton.TabIndex = 0;
            this.deleteEmpButton.Text = "Delete Employee";
            this.deleteEmpButton.UseVisualStyleBackColor = true;
            this.deleteEmpButton.Click += new System.EventHandler(this.deleteEmpButton_Click);
            // 
            // deleteDeptButton
            // 
            this.deleteDeptButton.Location = new System.Drawing.Point(12, 117);
            this.deleteDeptButton.Name = "deleteDeptButton";
            this.deleteDeptButton.Size = new System.Drawing.Size(268, 29);
            this.deleteDeptButton.TabIndex = 0;
            this.deleteDeptButton.Text = "Delete Department";
            this.deleteDeptButton.UseVisualStyleBackColor = true;
            this.deleteDeptButton.Click += new System.EventHandler(this.deleteDeptButton_Click);
            // 
            // updateEmpButton
            // 
            this.updateEmpButton.Location = new System.Drawing.Point(12, 82);
            this.updateEmpButton.Name = "updateEmpButton";
            this.updateEmpButton.Size = new System.Drawing.Size(268, 29);
            this.updateEmpButton.TabIndex = 0;
            this.updateEmpButton.Text = "Update Employee Information";
            this.updateEmpButton.UseVisualStyleBackColor = true;
            this.updateEmpButton.Click += new System.EventHandler(this.updateEmpButton_Click);
            // 
            // createNewEmpButton
            // 
            this.createNewEmpButton.Location = new System.Drawing.Point(12, 47);
            this.createNewEmpButton.Name = "createNewEmpButton";
            this.createNewEmpButton.Size = new System.Drawing.Size(268, 29);
            this.createNewEmpButton.TabIndex = 0;
            this.createNewEmpButton.Text = "Create New Employee";
            this.createNewEmpButton.UseVisualStyleBackColor = true;
            this.createNewEmpButton.Click += new System.EventHandler(this.createNewEmpButton_Click);
            // 
            // createNewDeptButton
            // 
            this.createNewDeptButton.Location = new System.Drawing.Point(12, 12);
            this.createNewDeptButton.Name = "createNewDeptButton";
            this.createNewDeptButton.Size = new System.Drawing.Size(268, 29);
            this.createNewDeptButton.TabIndex = 0;
            this.createNewDeptButton.Text = "Create New Department";
            this.createNewDeptButton.UseVisualStyleBackColor = true;
            this.createNewDeptButton.Click += new System.EventHandler(this.createNewDeptButton_Click);
            // 
            // CRUDFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 195);
            this.Controls.Add(this.createNewDeptButton);
            this.Controls.Add(this.createNewEmpButton);
            this.Controls.Add(this.updateEmpButton);
            this.Controls.Add(this.deleteDeptButton);
            this.Controls.Add(this.deleteEmpButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CRUDFunctions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Functions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteEmpButton;
        private System.Windows.Forms.Button deleteDeptButton;
        private System.Windows.Forms.Button updateEmpButton;
        private System.Windows.Forms.Button createNewEmpButton;
        private System.Windows.Forms.Button createNewDeptButton;
    }
}