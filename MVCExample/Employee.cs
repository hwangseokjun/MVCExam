using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExample
{
    public class Employee : IModel
    {
        private List<Employee> employees = new List<Employee>();

        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public string Rank { get; set; }
        public string Duty { get; set; }
        public string Remarks { get; set; }
        public string StartDate { get; set; }
        public string Creator { get; set; }
        public string CreatedDate { get; set; }
        public string Modifier { get; set; }
        public string ModifiedDate { get; set; }

        public Employee()
        {

        }

        public static Employee CreateFrom(EmployeeDto dto) 
        {
            Employee employee = new Employee();

            employee.EmployeeId = dto.EmployeeId;
            employee.Name = dto.Name;
            employee.Department = dto.Department;
            employee.Gender = dto.Gender;
            employee.Rank = dto.Rank;
            employee.Duty = dto.Duty;
            employee.Remarks = dto.Remarks;
            employee.Creator = dto.Writer;
            employee.CreatedDate = DateTime.Now.ToString();
            employee.Modifier = null;
            employee.ModifiedDate = null;

            return employee;
        }

        public void Save(Employee employee) 
        {
            this.employees.Add(employee);
        }

        public void Update(EmployeeDto dto) 
        {
            this.EmployeeId = dto.EmployeeId;
            this.Name = dto.Name;
            this.Department = dto.Department;
            this.Gender = dto.Gender;
            this.Rank = dto.Rank;
            this.Duty = dto.Duty;
            this.Remarks = dto.Remarks;
            this.Modifier = dto.Writer;
            this.ModifiedDate = DateTime.Now.ToString();
        }

        public void Remove(string employeeId) 
        {
            for (int i = 0; i <= this.employees.Count - 1; i++) 
            {
                if (this.employees[i].EmployeeId == employeeId) 
                {
                    this.employees.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Employee> FindAll() 
        {
            return this.employees;
        }

        public List<Employee> FindByDepartment(string department) 
        {
            List<Employee> temp = new List<Employee>();

            foreach (Employee emp in this.employees)
                if (emp.Department == department)
                    temp.Add(emp);

            return temp;
        }
    }
}
