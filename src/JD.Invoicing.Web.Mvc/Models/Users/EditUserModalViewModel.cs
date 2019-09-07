using System.Collections.Generic;
using System.Linq;
using JD.Invoicing.Roles.Dto;
using JD.Invoicing.Users.Dto;

namespace JD.Invoicing.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
