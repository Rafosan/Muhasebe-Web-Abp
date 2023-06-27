using System.Collections.Generic;
using MuhasebeWeb.Roles.Dto;

namespace MuhasebeWeb.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}