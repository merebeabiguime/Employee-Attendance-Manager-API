using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Company
    {
        public int Id { get; set; }
        public String CompanyName { get; set; } = String.Empty;
        public List<User> UserList { get; set; } = new List<User>();
    }
}