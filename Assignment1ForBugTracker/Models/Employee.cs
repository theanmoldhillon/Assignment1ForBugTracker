using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1ForBugTracker.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}