using System.Collections.Generic;
using JD.Invoicing.Roles.Dto;
using JD.Invoicing.Users.Dto;

namespace JD.Invoicing.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
