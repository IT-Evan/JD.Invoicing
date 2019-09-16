using Abp.AutoMapper;
using JD.Invoicing.Roles.Dto;
using JD.Invoicing.Web.Models.Common;

namespace JD.Invoicing.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public EditRoleModalViewModel(GetRoleForEditOutput output)
        {
            output.MapTo(this);
        }

        public bool HasPermission(PermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
