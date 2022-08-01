using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExample
{
    public interface IView
    {
        void SetController(Controller controller);
        void AddEmployee(Employee employee);
        void RemoveEmployee(string employeeId);
        void UpdateEmployee(Employee employee);
        EmployeeDto employeeDto { get; set; }
    }
}
