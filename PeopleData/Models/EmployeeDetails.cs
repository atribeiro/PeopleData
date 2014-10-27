using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleData.Models
{
    public partial class EmployeeDetails : EmplSampleEntities
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public Nullable<decimal> Phone { get; set; }
    
    
        public List<PersonDetail> Details { get; set; }
    }
}