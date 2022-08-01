using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExample
{
    public class Controller
    {
        private IModel model = null;

        public Controller(IModel model) 
        {
            this.model = model;
        }

        public void AddEmployee(EmployeeDto employeeDto) 
        {
            Employee temp = Employee.CreateFrom(employeeDto);
            this.model.Save(temp);
        }

        public void RemoveEmployee(string employeeId) 
        {
            this.model.Remove(employeeId);
        }

        public void UpdateEmployee(EmployeeDto employeeDto) 
        { 
        
        }

        public List<Employee> FindAllEmployee() 
        {
            return this.model.FindAll();
        }

        public List<Employee> FindByDepartment(string department) 
        {
            return this.model.FindByDepartment(department);
        }


    }
}
