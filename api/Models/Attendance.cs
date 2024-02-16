using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Attendance
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public String hour { get; set; } = String.Empty;
    }
}