using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        public String CompanyName { get; set; } = String.Empty;
        public List<User> UserList { get; set; } = new List<User>();
    }
}