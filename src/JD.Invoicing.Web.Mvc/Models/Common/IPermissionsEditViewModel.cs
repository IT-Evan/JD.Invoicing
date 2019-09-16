using System.Collections.Generic;
using JD.Invoicing.Roles.Dto;

namespace JD.Invoicing.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<PermissionDto> Permissions { get; set; }
    }
}