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
            this.deleteEmpButton.BackColor = System.Drawing.Color.Red;
            this.deleteEmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteEmpButton.ForeColor = System.Drawing.Color.White;
            this.deleteEmpButton.Location = new System.Drawing.Point(12, 152);
            this.deleteEmpButton.Name = "deleteEmpButton";
            this.deleteEmpButton.Size = new System.Drawing.Size(268, 29);
            this.deleteEmpButton.TabIndex = 0;
            this.deleteEmpButton.Text = "Delete Employee";
            this.deleteEmpButton.UseVisualStyleBackColor = false;
            this.deleteEmpButton.Click += new System.EventHandler(this.deleteEmpButton_Click);
            // 
            // deleteDeptButton
            // 
            this.deleteDeptButton.BackColor = System.Drawing.Color.Red;
            this.deleteDeptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteDeptButton.ForeColor = System.Drawing.Color.White;
            this.deleteDeptButton.Location = new System.Drawing.Point(12, 117);
            this.deleteDeptButton.Name = "deleteDeptButton";
            this.deleteDeptButton.Size = new System.Drawing.Size(268, 29);
            this.deleteDeptButton.TabIndex = 0;
            this.deleteDeptButton.Text = "Delete Department";
            this.deleteDeptButton.UseVisualStyleBackColor = false;
            this.deleteDeptButton.Click += new System.EventHandler(this.deleteDeptButton_Click);
            // 
            // updateEmpButton
            // 
            this.updateEmpButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateEmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateEmpButton.ForeColor = System.Drawing.Color.White;
            this.updateEmpButton.Location = new System.Drawing.Point(12, 82);
            this.updateEmpButton.Name = "updateEmpButton";
            this.updateEmpButton.Size = new System.Drawing.Size(268, 29);
            this.updateEmpButton.TabIndex = 0;
            this.updateEmpButton.Text = "Update Employee Information";
            this.updateEmpButton.UseVisualStyleBackColor = false;
            this.updateEmpButton.Click += new System.EventHandler(this.updateEmpButton_Click);
            // 
            // createNewEmpButton
            // 
            this.createNewEmpButton.BackColor = System.Drawing.Color.Green;
            this.createNewEmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createNewEmpButton.ForeColor = System.Drawing.Color.White;
            this.createNewEmpButton.Location = new System.Drawing.Point(12, 47);
            this.createNewEmpButton.Name = "createNewEmpButton";
            this.createNewEmpButton.Size = new System.Drawing.Size(268, 29);
            this.createNewEmpButton.TabIndex = 0;
            this.createNewEmpButton.Text = "Create New Employee";
            this.createNewEmpButton.UseVisualStyleBackColor = false;
            this.createNewEmpButton.Click += new System.EventHandler(this.createNewEmpButton_Click);
            // 
            // createNewDeptButton
            // 
            this.createNewDeptButton.BackColor = System.Drawing.Color.Green;
            this.createNewDeptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createNewDeptButton.ForeColor = System.Drawing.Color.White;
            this.createNewDeptButton.Location = new System.Drawing.Point(12, 12);
            this.createNewDeptButton.Name = "createNewDeptButton";
            this.createNewDeptButton.Size = new System.Drawing.Size(268, 29);
            this.createNewDeptButton.TabIndex = 0;
            this.createNewDeptButton.Text = "Create New Department";
            this.createNewDeptButton.UseVisualStyleBackColor = false;
            this.createNewDeptButton.Click += new System.EventHandler(this.createNewDeptButton_Click);
            // 
            // CRUDFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(188)))), ((int)(((byte)(225)))));
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