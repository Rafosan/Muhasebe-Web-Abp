using Abp.AutoMapper;
using MuhasebeWeb.Roles.Dto;
using MuhasebeWeb.Web.Models.Common;

namespace MuhasebeWeb.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
