using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCExample
{
    public partial class MainForm : Form
    {
        private Controller controller;
        private DataSet dataSet;
        private DataTable mainTable;
        private DataTable detailTable;

        public MainForm()
        {
            InitializeComponent();
            SetController();

        }

        private void SetController() 
        {
            this.controller = new Controller(new Employee());
        }

        private void AddEmployee(EmployeeDto employeeDto) 
        {
            this.controller.AddEmployee(employeeDto);
        }

        private void RemoveEmployee(string employeeId) 
        {
            this.controller.RemoveEmployee(employeeId);
        }

        private void UpdateEmployee(EmployeeDto employeeDto) 
        {
            this.controller.UpdateEmployee(employeeDto);
        }

        private void DrawGridView() { }

        private void ClearGridView() { }
    }
}
