namespace CompanyRecordsAppUI
{
    partial class ViewFunctions
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
            this.thresholdTextBox = new System.Windows.Forms.TextBox();
            this.employeesEarningOverButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeesGrpByDepartmentsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.employeesAndDepartmentsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.deptsNoEmpsButton = new System.Windows.Forms.Button();
            this.employeesGrpByDepartmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.employeesAndDepartmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.employeesEarningOverDataGridView = new System.Windows.Forms.DataGridView();
            this.deptsNoEmpsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.allEmpsAndAllDeptsButton = new System.Windows.Forms.Button();
            this.allEmpsAndAllDeptsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrpByDepartmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesAndDepartmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesEarningOverDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmpsAndAllDeptsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // thresholdTextBox
            // 
            this.thresholdTextBox.Location = new System.Drawing.Point(159, 286);
            this.thresholdTextBox.Name = "thresholdTextBox";
            this.thresholdTextBox.Size = new System.Drawing.Size(223, 27);
            this.thresholdTextBox.TabIndex = 1;
            // 
            // employeesEarningOverButton
            // 
            this.employeesEarningOverButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.employeesEarningOverButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.employeesEarningOverButton.ForeColor = System.Drawing.Color.White;
            this.employeesEarningOverButton.Location = new System.Drawing.Point(388, 284);
            this.employeesEarningOverButton.Name = "employeesEarningOverButton";
            this.employeesEarningOverButton.Size = new System.Drawing.Size(268, 29);
            this.employeesEarningOverButton.TabIndex = 2;
            this.employeesEarningOverButton.Text = "Submit";
            this.employeesEarningOverButton.UseVisualStyleBackColor = false;
            this.employeesEarningOverButton.Click += new System.EventHandler(this.employeesEarningOverButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(221, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employees Earning Above Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Threshold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(804, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employees Grouped By Department";
            // 
            // employeesGrpByDepartmentsButton
            // 
            this.employeesGrpByDepartmentsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.employeesGrpByDepartmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.employeesGrpByDepartmentsButton.ForeColor = System.Drawing.Color.White;
            this.employeesGrpByDepartmentsButton.Location = new System.Drawing.Point(746, 284);
            this.employeesGrpByDepartmentsButton.Name = "employeesGrpByDepartmentsButton";
            this.employeesGrpByDepartmentsButton.Size = new System.Drawing.Size(387, 29);
            this.employeesGrpByDepartmentsButton.TabIndex = 2;
            this.employeesGrpByDepartmentsButton.Text = "Submit";
            this.employeesGrpByDepartmentsButton.UseVisualStyleBackColor = false;
            this.employeesGrpByDepartmentsButton.Click += new System.EventHandler(this.employeesGrpByDepartmentsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(593, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employees And Their Departments";
            // 
            // employeesAndDepartmentsButton
            // 
            this.employeesAndDepartmentsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.employeesAndDepartmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.employeesAndDepartmentsButton.ForeColor = System.Drawing.Color.White;
            this.employeesAndDepartmentsButton.Location = new System.Drawing.Point(529, 664);
            this.employeesAndDepartmentsButton.Name = "employeesAndDepartmentsButton";
            this.employeesAndDepartmentsButton.Size = new System.Drawing.Size(387, 29);
            this.employeesAndDepartmentsButton.TabIndex = 2;
            this.employeesAndDepartmentsButton.Text = "Submit";
            this.employeesAndDepartmentsButton.UseVisualStyleBackColor = false;
            this.employeesAndDepartmentsButton.Click += new System.EventHandler(this.employeesAndDepartmentsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(998, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Departments With No Employees";
            // 
            // deptsNoEmpsButton
            // 
            this.deptsNoEmpsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.deptsNoEmpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deptsNoEmpsButton.ForeColor = System.Drawing.Color.White;
            this.deptsNoEmpsButton.Location = new System.Drawing.Point(986, 663);
            this.deptsNoEmpsButton.Name = "deptsNoEmpsButton";
            this.deptsNoEmpsButton.Size = new System.Drawing.Size(268, 29);
            this.deptsNoEmpsButton.TabIndex = 2;
            this.deptsNoEmpsButton.Text = "Submit";
            this.deptsNoEmpsButton.UseVisualStyleBackColor = false;
            this.deptsNoEmpsButton.Click += new System.EventHandler(this.deptsNoEmpsButton_Click);
            // 
            // employeesGrpByDepartmentsDataGridView
            // 
            this.employeesGrpByDepartmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGrpByDepartmentsDataGridView.Location = new System.Drawing.Point(717, 36);
            this.employeesGrpByDepartmentsDataGridView.Name = "employeesGrpByDepartmentsDataGridView";
            this.employeesGrpByDepartmentsDataGridView.RowHeadersWidth = 51;
            this.employeesGrpByDepartmentsDataGridView.Size = new System.Drawing.Size(454, 244);
            this.employeesGrpByDepartmentsDataGridView.TabIndex = 6;
            this.employeesGrpByDepartmentsDataGridView.Text = "dataGridView1";
            // 
            // employeesAndDepartmentsDataGridView
            // 
            this.employeesAndDepartmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesAndDepartmentsDataGridView.Location = new System.Drawing.Point(500, 414);
            this.employeesAndDepartmentsDataGridView.Name = "employeesAndDepartmentsDataGridView";
            this.employeesAndDepartmentsDataGridView.RowHeadersWidth = 51;
            this.employeesAndDepartmentsDataGridView.Size = new System.Drawing.Size(454, 244);
            this.employeesAndDepartmentsDataGridView.TabIndex = 7;
            this.employeesAndDepartmentsDataGridView.Text = "dataGridView2";
            // 
            // employeesEarningOverDataGridView
            // 
            this.employeesEarningOverDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesEarningOverDataGridView.Location = new System.Drawing.Point(80, 36);
            this.employeesEarningOverDataGridView.Name = "employeesEarningOverDataGridView";
            this.employeesEarningOverDataGridView.RowHeadersWidth = 51;
            this.employeesEarningOverDataGridView.Size = new System.Drawing.Size(576, 244);
            this.employeesEarningOverDataGridView.TabIndex = 5;
            this.employeesEarningOverDataGridView.Text = "dataGridView1";
            // 
            // deptsNoEmpsListBox
            // 
            this.deptsNoEmpsListBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deptsNoEmpsListBox.FormattingEnabled = true;
            this.deptsNoEmpsListBox.ItemHeight = 23;
            this.deptsNoEmpsListBox.Location = new System.Drawing.Point(986, 414);
            this.deptsNoEmpsListBox.Name = "deptsNoEmpsListBox";
            this.deptsNoEmpsListBox.Size = new System.Drawing.Size(268, 211);
            this.deptsNoEmpsListBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(462, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "All Employees And All Departments(Assigned And Unassigned)";
            // 
            // allEmpsAndAllDeptsButton
            // 
            this.allEmpsAndAllDeptsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.allEmpsAndAllDeptsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.allEmpsAndAllDeptsButton.ForeColor = System.Drawing.Color.White;
            this.allEmpsAndAllDeptsButton.Location = new System.Drawing.Point(42, 662);
            this.allEmpsAndAllDeptsButton.Name = "allEmpsAndAllDeptsButton";
            this.allEmpsAndAllDeptsButton.Size = new System.Drawing.Size(387, 29);
            this.allEmpsAndAllDeptsButton.TabIndex = 2;
            this.allEmpsAndAllDeptsButton.Text = "Submit";
            this.allEmpsAndAllDeptsButton.UseVisualStyleBackColor = false;
            this.allEmpsAndAllDeptsButton.Click += new System.EventHandler(this.allEmpsAndAllDeptsButton_Click);
            // 
            // allEmpsAndAllDeptsDataGridView
            // 
            this.allEmpsAndAllDeptsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allEmpsAndAllDeptsDataGridView.Location = new System.Drawing.Point(13, 414);
            this.allEmpsAndAllDeptsDataGridView.Name = "allEmpsAndAllDeptsDataGridView";
            this.allEmpsAndAllDeptsDataGridView.RowHeadersWidth = 51;
            this.allEmpsAndAllDeptsDataGridView.Size = new System.Drawing.Size(454, 244);
            this.allEmpsAndAllDeptsDataGridView.TabIndex = 6;
            this.allEmpsAndAllDeptsDataGridView.Text = "dataGridView1";
            // 
            // ViewFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(188)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1269, 723);
            this.Controls.Add(this.allEmpsAndAllDeptsDataGridView);
            this.Controls.Add(this.allEmpsAndAllDeptsButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deptsNoEmpsListBox);
            this.Controls.Add(this.employeesAndDepartmentsDataGridView);
            this.Controls.Add(this.employeesGrpByDepartmentsDataGridView);
            this.Controls.Add(this.employeesEarningOverDataGridView);
            this.Controls.Add(this.deptsNoEmpsButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeesAndDepartmentsButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.employeesGrpByDepartmentsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesEarningOverButton);
            this.Controls.Add(this.thresholdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ViewFunctions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Functions";
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrpByDepartmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesAndDepartmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesEarningOverDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmpsAndAllDeptsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox thresholdTextBox;
        private System.Windows.Forms.Button employeesEarningOverButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button employeesGrpByDepartmentsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button employeesAndDepartmentsButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deptsNoEmpsButton;
        private System.Windows.Forms.DataGridView employeesEarningOverDataGridView;
        private System.Windows.Forms.DataGridView employeesGrpByDepartmentsDataGridView;
        private System.Windows.Forms.DataGridView employeesAndDepartmentsDataGridView;
        private System.Windows.Forms.ListBox deptsNoEmpsListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button allEmpsAndAllDeptsButton;
        private System.Windows.Forms.DataGridView allEmpsAndAllDeptsDataGridView;
    }
}