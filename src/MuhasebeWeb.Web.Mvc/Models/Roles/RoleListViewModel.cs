using System.Collections.Generic;
using MuhasebeWeb.Roles.Dto;

namespace MuhasebeWeb.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
