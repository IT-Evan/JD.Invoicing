using System.Collections.Generic;
using JD.Invoicing.Roles.Dto;

namespace JD.Invoicing.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
