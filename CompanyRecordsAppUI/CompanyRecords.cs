using CompanyRecordsClassLib;
using System;
using System.Windows.Forms;

namespace CompanyRecordsAppUI
{
    public partial class CompanyRecords : Form
    {
        private readonly IOperations Operations;
        public CompanyRecords(IOperations operations)
        {
            InitializeComponent();
            Operations = operations;
        }

        private void crudFunctionsButton_Click(object sender, EventArgs e)
        {
            CRUDFunctions crudFunctions = new CRUDFunctions(Operations);
            crudFunctions.Show();
        }

        private void viewFunctionsButton_Click(object sender, EventArgs e)
        {
            ViewFunctions viewFunctions = new ViewFunctions(Operations);
            viewFunctions.Show();
        }
    }
}
