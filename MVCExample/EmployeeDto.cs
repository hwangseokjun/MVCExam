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


        public EmployeeDto() 
        { 

        }

        public static EmployeeDto Builder() 
        {
            return new EmployeeDto();
        }

        public EmployeeDto SetEmployeeId(string value) 
        {
            this.employeeDto.EmployeeId = value;
            return this;
        }

        public EmployeeDto SetName(string value)
        {
            this.employeeDto.Name = value;
            return this;
        }

        public EmployeeDto SetDepartment(string value)
        {
            this.employeeDto.Department = value;
            return this;
        }

        public EmployeeDto SetGender(string value)
        {
            this.employeeDto.Gender = value;
            return this;
        }

        public EmployeeDto SetRank(string value)
        {
            this.employeeDto.Rank = value;
            return this;
        }

        public EmployeeDto SetDuty(string value)
        {
            this.employeeDto.Duty = value;
            return this;
        }

        public EmployeeDto SetRemarks(string value)
        {
            this.employeeDto.Remarks = value;
            return this;
        }

        public EmployeeDto SetStartDate(string value)
        {
            this.employeeDto.StartDate = value;
            return this;
        }

        public EmployeeDto SetWriter(string value)
        {
            this.employeeDto.Writer = value;
            return this;
        }

        public EmployeeDto ToBuild()
        {
            return this.employeeDto;
        }
    }

}
