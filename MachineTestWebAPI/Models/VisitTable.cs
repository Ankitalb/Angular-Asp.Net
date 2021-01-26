using System;
using System.Collections.Generic;

namespace MachineTestWebAPI.Models
{
    public partial class VisitTable
    {
        public decimal VisitId { get; set; }
        public string CustName { get; set; }
        public string ContactPerson { get; set; }
        public decimal? ContactNo { get; set; }
        public string InterestProduct { get; set; }
        public string Description { get; set; }
        public DateTime? VisitDatetime { get; set; }
        public bool? IsDisabled { get; set; }
        public bool? IsDeleted { get; set; }
        public decimal? EmpId { get; set; }

        public virtual Employee Emp { get; set; }
    }
}
