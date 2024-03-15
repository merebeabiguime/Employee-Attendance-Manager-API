using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class User
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public String FirstName { get; set; } = String.Empty;

        [Column(TypeName = "varchar(50)")]
        public String LastName { get; set; } = String.Empty;

        [Column(TypeName = "varchar(100)")]
        public String Uid { get; set; } = String.Empty;
        public int Role { get; set; }
        public Company Company { get; set; }
    }
}