using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class User
    {
        public String uid { get; set; } = String.Empty;
        public String email { get; set; } = String.Empty;
        public String password { get; set; } = String.Empty;
        public String companyID { get; set; } = String.Empty;
        public int role { get; set; }
    }
}