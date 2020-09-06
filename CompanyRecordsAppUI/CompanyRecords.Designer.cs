namespace CompanyRecordsAppUI
{
    partial class CompanyRecords
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crudFunctionsButton = new System.Windows.Forms.Button();
            this.viewFunctionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crudFunctionsButton
            // 
            this.crudFunctionsButton.Location = new System.Drawing.Point(13, 13);
            this.crudFunctionsButton.Name = "crudFunctionsButton";
            this.crudFunctionsButton.Size = new System.Drawing.Size(268, 29);
            this.crudFunctionsButton.TabIndex = 0;
            this.crudFunctionsButton.Text = "CRUD Functions";
            this.crudFunctionsButton.UseVisualStyleBackColor = true;
            this.crudFunctionsButton.Click += new System.EventHandler(this.crudFunctionsButton_Click);
            // 
            // viewFunctionsButton
            // 
            this.viewFunctionsButton.Location = new System.Drawing.Point(13, 48);
            this.viewFunctionsButton.Name = "viewFunctionsButton";
            this.viewFunctionsButton.Size = new System.Drawing.Size(268, 29);
            this.viewFunctionsButton.TabIndex = 0;
            this.viewFunctionsButton.Text = "View Functions";
            this.viewFunctionsButton.UseVisualStyleBackColor = true;
            this.viewFunctionsButton.Click += new System.EventHandler(this.viewFunctionsButton_Click);
            // 
            // CompanyRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 92);
            this.Controls.Add(this.viewFunctionsButton);
            this.Controls.Add(this.crudFunctionsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CompanyRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Records";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crudFunctionsButton;
        private System.Windows.Forms.Button viewFunctionsButton;
    }
}

