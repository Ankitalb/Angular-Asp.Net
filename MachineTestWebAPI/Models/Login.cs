using System;
using System.Collections.Generic;

namespace MachineTestWebAPI.Models
{
    public partial class Login
    {
        public Login()
        {
            Employee = new HashSet<Employee>();
        }

        public decimal LId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
