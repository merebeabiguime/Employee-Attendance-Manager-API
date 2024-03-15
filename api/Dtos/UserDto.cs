using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public String Uid { get; set; } = String.Empty;
        public int Role { get; set; }
        public String CompanyName { get; set; } = String.Empty;
    }
}