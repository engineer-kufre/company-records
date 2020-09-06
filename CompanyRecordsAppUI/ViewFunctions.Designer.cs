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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.employeesAndDepartmentsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.employeesEarningOverDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeesAndDepartmentsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.employeesEarningOverDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesAndDepartmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // thresholdTextBox
            // 
            this.thresholdTextBox.Location = new System.Drawing.Point(92, 286);
            this.thresholdTextBox.Name = "thresholdTextBox";
            this.thresholdTextBox.Size = new System.Drawing.Size(189, 27);
            this.thresholdTextBox.TabIndex = 1;
            // 
            // employeesEarningOverButton
            // 
            this.employeesEarningOverButton.Location = new System.Drawing.Point(13, 320);
            this.employeesEarningOverButton.Name = "employeesEarningOverButton";
            this.employeesEarningOverButton.Size = new System.Drawing.Size(268, 29);
            this.employeesEarningOverButton.TabIndex = 2;
            this.employeesEarningOverButton.Text = "Submit";
            this.employeesEarningOverButton.UseVisualStyleBackColor = true;
            this.employeesEarningOverButton.Click += new System.EventHandler(this.employeesEarningOverButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employees Earning Above Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Threshold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(317, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employees Grouped By Department";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(617, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employees And Their Departments";
            // 
            // employeesAndDepartmentsButton
            // 
            this.employeesAndDepartmentsButton.Location = new System.Drawing.Point(617, 320);
            this.employeesAndDepartmentsButton.Name = "employeesAndDepartmentsButton";
            this.employeesAndDepartmentsButton.Size = new System.Drawing.Size(268, 29);
            this.employeesAndDepartmentsButton.TabIndex = 2;
            this.employeesAndDepartmentsButton.Text = "Submit";
            this.employeesAndDepartmentsButton.UseVisualStyleBackColor = true;
            this.employeesAndDepartmentsButton.Click += new System.EventHandler(this.employeesAndDepartmentsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(929, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Departments With No Employees";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(917, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(268, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(916, 36);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(270, 264);
            this.listBox4.TabIndex = 0;
            // 
            // employeesEarningOverDataGridView
            // 
            this.employeesEarningOverDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesEarningOverDataGridView.Location = new System.Drawing.Point(13, 36);
            this.employeesEarningOverDataGridView.Name = "employeesEarningOverDataGridView";
            this.employeesEarningOverDataGridView.RowHeadersWidth = 51;
            this.employeesEarningOverDataGridView.Size = new System.Drawing.Size(268, 244);
            this.employeesEarningOverDataGridView.TabIndex = 5;
            this.employeesEarningOverDataGridView.Text = "dataGridView1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(268, 273);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // employeesAndDepartmentsDataGridView
            // 
            this.employeesAndDepartmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesAndDepartmentsDataGridView.Location = new System.Drawing.Point(617, 36);
            this.employeesAndDepartmentsDataGridView.Name = "employeesAndDepartmentsDataGridView";
            this.employeesAndDepartmentsDataGridView.RowHeadersWidth = 51;
            this.employeesAndDepartmentsDataGridView.Size = new System.Drawing.Size(268, 273);
            this.employeesAndDepartmentsDataGridView.TabIndex = 7;
            this.employeesAndDepartmentsDataGridView.Text = "dataGridView2";
            // 
            // ViewFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 450);
            this.Controls.Add(this.employeesAndDepartmentsDataGridView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.employeesEarningOverDataGridView);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeesAndDepartmentsButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
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
            ((System.ComponentModel.ISupportInitialize)(this.employeesEarningOverDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesAndDepartmentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox thresholdTextBox;
        private System.Windows.Forms.Button employeesEarningOverButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button employeesAndDepartmentsButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.DataGridView employeesEarningOverDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView employeesAndDepartmentsDataGridView;
    }
}