using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using api.Dtos;

namespace api.Mappers
{
    public static class UserMapper
    {
        public static UserDto ToUserDto(this User userModel)
        {
            return new UserDto
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Uid = userModel.Uid,
                Role = userModel.Role,
                CompanyName = userModel.Company.CompanyName,
            };
        }
    }

}