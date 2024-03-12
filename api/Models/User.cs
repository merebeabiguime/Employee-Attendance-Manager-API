using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class User
    {
        public int Id { get; set; }
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public String Uid { get; set; } = String.Empty;

        // Declare companyID as a foreign key referencing the Company entity
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public int Role { get; set; }

        public Company Company { get; set; }
    }
}