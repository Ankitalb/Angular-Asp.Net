using System;
using System.Collections.Generic;

namespace MachineTestWebAPI.Models
{
    public partial class Employee
    {
        public Employee()
        {
            VisitTable = new HashSet<VisitTable>();
        }

        public decimal EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public decimal? PhoneNumber { get; set; }
        public decimal? LId { get; set; }

        public virtual Login L { get; set; }
        public virtual ICollection<VisitTable> VisitTable { get; set; }
    }
}
