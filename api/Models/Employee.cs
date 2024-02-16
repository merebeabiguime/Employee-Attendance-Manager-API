using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Employee : User
    {
        public String firstName { get; set; } = String.Empty;
        public String lastName { get; set; } = String.Empty;
        public List<Attendance> attendaceList { get; set; } = new List<Attendance>();
    }
}