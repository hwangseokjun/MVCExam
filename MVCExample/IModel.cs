using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExample
{
    public interface IModel
    {
        void Save(Employee employee);
        void Update(EmployeeDto employeeDto);
        void Remove(string employeeId);
        List<Employee> FindAll();
        List<Employee> FindByDepartment(string department);
    }
}
