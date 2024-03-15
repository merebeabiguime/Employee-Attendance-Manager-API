using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos
{
    public class UpdateUserRequestDto
    {
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public String Uid { get; set; } = String.Empty;
        public int Role { get; set; }
        public int CompanyId { get; set; }

    }
}