using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExample
{
    public class EmployeeDto
    {
        private EmployeeDto employeeDto;
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public string Rank { get; set; }
        public string Duty { get; set; }
        public string Remarks { get; set; }
        public string StartDate { get; set; }
        public string Writer { get; set; }

        public EmployeeDto(string empId, string name, string dpt, string gender, string rank, string duty, string remarks, string startDate, string writer)
        {
            this.EmployeeId = empId;
            this.Name = name;
            this.Department = dpt;
            this.Gender = gender;
            this.Rank = rank;
            this.Duty = duty;
            this.Remarks = remarks;
            this.StartDate = startDate;
            this.Writer = writer;
        }

        public EmployeeDto() 
        { 
            this.employeeDto = new EmployeeDto(null, null, null, null, null, null, null, null, null);
        }

        public EmployeeDto SetEmployeeId(string value) 
        {
            this.employeeDto.EmployeeId = value;
            return this;
        }

        public EmployeeDto SetName(string value)
        {
            this.employeeDto.EmployeeId = value;
            return this;
        }

        public EmployeeDto SetDepartment(string value)
        {
            this.employeeDto.EmployeeId = value;
            return this;
        }

        public EmployeeDto SetGender(string value)
        {
            this.employeeDto.EmployeeId = value;
            return this;
        }

        public EmployeeDto SetRank(string value)
        {
            this.employeeDto.EmployeeId = value;
            return this;
        }

        public EmployeeDto SetDuty(string value)
        {
            this.employeeDto.EmployeeId = value;
            return this;
        }

        public EmployeeDto SetRemarks(string value)
        {
            this.employeeDto.EmployeeId = value;
            return this;
        }

        public EmployeeDto SetStartDate(string value)
        {
            this.employeeDto.EmployeeId = value;
            return this;
        }

        public EmployeeDto SetWriter(string value)
        {
            this.employeeDto.EmployeeId = value;
            return this;
        }

        public EmployeeDto ToBuild()
        {
            return this.employeeDto;
        }
    }

}
