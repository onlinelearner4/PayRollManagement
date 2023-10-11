using PayrollManagementBL;
using PayrollManagementDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollManagement
{
    public partial class frmEmployee : Form
    {
        EmployeeService service = new EmployeeService();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = txtName.Text;
            emp.Address = txtAddress.Text;
            ResultResponse result=service.AddEmployee(emp);
            MessageBox.Show(result.Result, "Result");

        }
    }
}
