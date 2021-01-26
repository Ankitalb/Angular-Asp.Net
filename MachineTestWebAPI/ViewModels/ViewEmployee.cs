using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineTestWebAPI.ViewModels
{
	public class ViewEmployee
	{

        public ViewEmployee()
        {

        }
        public ViewEmployee(decimal empId, string firstName, string lastName, int? age, string gender, string address, decimal? phoneNumber, decimal? lId)
        {
            EmpId = empId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Address = address;
            PhoneNumber = phoneNumber;
            LId = lId;
        }

        public decimal EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public decimal? PhoneNumber { get; set; }
        public decimal? LId { get; set; }

    }
}
