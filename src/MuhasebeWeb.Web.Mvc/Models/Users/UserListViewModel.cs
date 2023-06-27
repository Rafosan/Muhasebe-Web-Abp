using System.Collections.Generic;
using MuhasebeWeb.Roles.Dto;

namespace MuhasebeWeb.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
