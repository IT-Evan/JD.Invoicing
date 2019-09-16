using System.Collections.Generic;

namespace JD.Invoicing.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<PermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}