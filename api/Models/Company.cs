using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Company
    {
        public String companyID { get; set; } = String.Empty;
        public String companyName { get; set; } = String.Empty;
        public List<Employee> employeeList { get; set; } = new List<Employee>();
    }
}