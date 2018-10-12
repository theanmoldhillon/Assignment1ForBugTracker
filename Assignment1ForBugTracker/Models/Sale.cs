using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1ForBugTracker.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int StoreLocationId { get; set; }
        public virtual StoreLocation StoreLocation { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public int EmployeeAproveId { get; set; }
        public virtual Employee EmployeeAprove { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}