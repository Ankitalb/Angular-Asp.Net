using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MachineTestWebAPI.Models;
namespace MachineTestWebAPI.ViewModels
{
	public class ViewVisitTable
	{
        public ViewVisitTable()
        {

        }

        public ViewVisitTable(VisitTable visitTable)
        {
            VisitId = visitTable.VisitId;
            CustName = visitTable.CustName;
            ContactPerson = visitTable.ContactPerson;
            ContactNo = visitTable.ContactNo;
            InterestProduct = visitTable.InterestProduct;
            Description =visitTable.Description;
            VisitDatetime = visitTable.VisitDatetime;
            IsDisabled = visitTable.IsDisabled;
            IsDeleted = visitTable.IsDeleted;
            EmpId = visitTable.EmpId;
        }

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

    }
}
